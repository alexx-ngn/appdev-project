using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;

namespace Y
{
    public static class ReportSystem
    {
        private static List<UserAccount> UserAccounts { get; set; } = new List<UserAccount>();
        private static List<AdminAccount> AdminAccounts { get; set; } = new List<AdminAccount>();
        private static Queue<Report> OpenReports { get; set; } = new Queue<Report>();
        private static Queue<Report> ProcessingReports { get; set; } = new Queue<Report>();
        private static List<Report> ClosedReports { get; set; } = new List<Report>();

        private static SqlConnection GetConnection()
        {
            string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"database\Y_DB.sqlite");
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={databasePath};Integrated Security=True;";
            return new SqlConnection(connectionString);
        }

        public static void AddUser(UserAccount user)
        {
            using (SqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO UserAccount (id, name, email, followerCount) VALUES (@id, @name, @email, @followerCount)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to avoid SQL injection
                        command.Parameters.AddWithValue("@id", user.Id);
                        command.Parameters.AddWithValue("@name", user.Name);
                        command.Parameters.AddWithValue("@email", user.Email);
                        command.Parameters.AddWithValue("@followerCount", user.FollowerCount);

                        command.ExecuteNonQuery();
                    }

                    Console.WriteLine("User added successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }
        }

        public static void RemoveUser(UserAccount user)
        {
            using (SqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = "DELETE FROM UserAccount WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", user.Id);
                        command.ExecuteNonQuery();
                    }

                    UserAccounts.Remove(user); // Also remove from in-memory list
                    Console.WriteLine("User removed successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error removing user: {ex.Message}");
                }
            }
        }

        public static void AddAdmin(AdminAccount admin)
        {
            using (SqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO AdminAccount (id, name, email) VALUES (@id, @name, @email)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", admin.Id);
                        command.Parameters.AddWithValue("@name", admin.Name);
                        command.Parameters.AddWithValue("@email", admin.Email);

                        command.ExecuteNonQuery();
                    }

                    AdminAccounts.Add(admin); // Add to in-memory list
                    Console.WriteLine("Admin added successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error adding admin: {ex.Message}");
                }
            }
        }

        public static void RemoveAdmin(AdminAccount admin)
        {
            using (SqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = "DELETE FROM AdminAccount WHERE id = @id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", admin.Id);
                        command.ExecuteNonQuery();
                    }

                    AdminAccounts.Remove(admin); // Also remove from in-memory list
                    Console.WriteLine("Admin removed successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error removing admin: {ex.Message}");
                }
            }
        }


        public static void FileReport(Report report)
        {
            using (SqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = string.Empty;

                    if (report is UserReport userReport)
                    {
                        // UserReport: Insert into UserReport table
                        query = "INSERT INTO UserReport (id, reportingUserId, reason, reportedUserId) VALUES (@id, @reportingUserId, @reason, @reportedUserId)";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@id", userReport.Id);
                            command.Parameters.AddWithValue("@reportingUserId", userReport.ReportingUserId);
                            command.Parameters.AddWithValue("@reason", userReport.Reason);
                            command.Parameters.AddWithValue("@reportedUserId", userReport.ReportedUserId);

                            command.ExecuteNonQuery();
                        }
                    }
                    else if (report is PostReport postReport)
                    {
                        // PostReport: Insert into PostReport table
                        query = "INSERT INTO PostReport (id, reportingUserId, reason, reportedPostId) VALUES (@id, @reportingUserId, @reason, @reportedPostId)";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@id", postReport.Id);
                            command.Parameters.AddWithValue("@reportingUserId", postReport.ReportingUserId);
                            command.Parameters.AddWithValue("@reason", postReport.Reason);
                            command.Parameters.AddWithValue("@reportedPostId", postReport.ReportedPostId);

                            command.ExecuteNonQuery();
                        }
                    }

                    Console.WriteLine("Report filed successfully.");
                    OpenReports.Enqueue(report);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error filing report: {ex.Message}");
                }
            }
        }

        public static Report FetchNextOpenReport()
        {
            if (OpenReports.Count > 0)
            {
                Report report = OpenReports.Dequeue();
                ProcessingReports.Enqueue(report);
                return report;
            }
            else
            {  
                return null;
            }
        }

        public static void FetchProcessingToClose()
        {
            if (ProcessingReports.Count > 0)
            {
                Report report = ProcessingReports.Dequeue();

                using (SqlConnection connection = GetConnection())
                {
                    try
                    {
                        connection.Open();

                        string query = string.Empty;

                        if (report is UserReport userReport)
                        {
                            // Delete the report from UserReport table
                            query = "DELETE FROM UserReport WHERE id = @id";
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@id", userReport.Id);
                                command.ExecuteNonQuery();
                            }
                        }
                        else if (report is PostReport postReport)
                        {
                            // Delete the report from PostReport table
                            query = "DELETE FROM PostReport WHERE id = @id";
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@id", postReport.Id);
                                command.ExecuteNonQuery();
                            }
                        }

                        // Add the report to the ClosedReports list after removing it from the database
                        ClosedReports.Add(report);
                        Console.WriteLine("Report processed and closed successfully.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error processing and closing the report: {ex.Message}");
                    }
                }
            }
            else
            {
                Console.WriteLine("No reports in the processing queue.");
            }
        }

        public static List<UserAccount> GetUserAccounts()
        {
            return UserAccounts;
        }
    }
}
