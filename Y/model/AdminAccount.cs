using System;
using System.Linq;
using Y.controller;

namespace Y
{
    public class AdminAccount : Account
    {
        // Singleton instance of the ReportSystem for administrative operations
        ReportSystem ReportSystem = ReportSystem.Instance;

        // Static field to generate unique IDs for new admin accounts
        private static int idCount = 1;

        /// <summary>
        /// Constructor to initialize an admin account with an existing ID.
        /// </summary>
        /// <param name="id">The unique ID for the admin account.</param>
        /// <param name="name">The name of the admin.</param>
        /// <param name="email">The email address of the admin.</param>
        /// <param name="password">The password for the admin account.</param>
        public AdminAccount(int id, string name, string email, string password) : base(id, name, email, password)
        {
        }

        /// <summary>
        /// Constructor to initialize a new admin account and generate a unique ID.
        /// </summary>
        /// <param name="name">The name of the admin.</param>
        /// <param name="email">The email address of the admin.</param>
        /// <param name="password">The password for the admin account.</param>
        public AdminAccount(string name, string email, string password) : base(name, email, password)
        {
            Id = idCount++; // Automatically assign a unique ID to the admin
        }

        /// <summary>
        /// Remove a specific post from the system by delegating the operation to the user who owns the post.
        /// </summary>
        /// <param name="post">The post to be removed.</param>
        public override void removePost(Post post)
        {
            // Find the user account that owns the post
            UserAccount user = FindAccountWithPost(post);

            if (user != null)
            {
                // Remove the post from the user's account
                user.removePost(post);
            }
        }

        /// <summary>
        /// Find the user account that owns a specific post.
        /// </summary>
        /// <param name="post">The post whose owner is to be identified.</param>
        /// <returns>The UserAccount that owns the post, or null if no owner is found.</returns>
        private UserAccount FindAccountWithPost(Post post)
        {
            // Iterate through all user accounts fetched from the ReportSystem
            foreach (UserAccount user in ReportSystem.GetUserAccounts()) // Assuming GetUserAccounts fetches all users
            {
                // Check if the user's list of posts contains the specified post
                if (user.GetPosts().Contains(post))
                {
                    return user; // Return the user that owns the post
                }
            }

            // Return null if no user is found to own the post
            return null;
        }
    }
}
