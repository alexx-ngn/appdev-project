namespace Y
{
    partial class UserOverview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Home");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Search");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("My Profile");
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.sideListView = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.post1 = new Y.Post();
            this.post2 = new Y.Post();
            this.post3 = new Y.Post();
            this.post4 = new Y.Post();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.sideListView);
            this.panel1.Location = new System.Drawing.Point(12, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 409);
            this.panel1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.Location = new System.Drawing.Point(0, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Post";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // sideListView
            // 
            this.sideListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideListView.HideSelection = false;
            this.sideListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.sideListView.Location = new System.Drawing.Point(0, 0);
            this.sideListView.Name = "sideListView";
            this.sideListView.Size = new System.Drawing.Size(123, 409);
            this.sideListView.TabIndex = 1;
            this.sideListView.UseCompatibleStateImageBehavior = false;
            this.sideListView.View = System.Windows.Forms.View.Tile;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Post";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.post4);
            this.panel2.Controls.Add(this.post3);
            this.panel2.Controls.Add(this.post2);
            this.panel2.Controls.Add(this.post1);
            this.panel2.Location = new System.Drawing.Point(146, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(729, 509);
            this.panel2.TabIndex = 8;
            // 
            // post1
            // 
            this.post1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.post1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.post1.Location = new System.Drawing.Point(3, 3);
            this.post1.Name = "post1";
            this.post1.Size = new System.Drawing.Size(665, 138);
            this.post1.TabIndex = 0;
            // 
            // post2
            // 
            this.post2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.post2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.post2.Location = new System.Drawing.Point(3, 147);
            this.post2.Name = "post2";
            this.post2.Size = new System.Drawing.Size(665, 138);
            this.post2.TabIndex = 1;
            // 
            // post3
            // 
            this.post3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.post3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.post3.Location = new System.Drawing.Point(3, 291);
            this.post3.Name = "post3";
            this.post3.Size = new System.Drawing.Size(665, 138);
            this.post3.TabIndex = 2;
            // 
            // post4
            // 
            this.post4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.post4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.post4.Location = new System.Drawing.Point(3, 435);
            this.post4.Name = "post4";
            this.post4.Size = new System.Drawing.Size(665, 138);
            this.post4.TabIndex = 3;
            // 
            // UserOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1095, 594);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserOverview";
            this.Text = "User Overview";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView sideListView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private Post post4;
        private Post post3;
        private Post post2;
        private Post post1;
    }
}
