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
            this.postButton = new System.Windows.Forms.Button();
            this.sideListView = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.overviewFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.postButton);
            this.panel1.Controls.Add(this.sideListView);
            this.panel1.Location = new System.Drawing.Point(12, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 409);
            this.panel1.TabIndex = 7;
            // 
            // postButton
            // 
            this.postButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.postButton.Location = new System.Drawing.Point(0, 386);
            this.postButton.Name = "postButton";
            this.postButton.Size = new System.Drawing.Size(123, 23);
            this.postButton.TabIndex = 2;
            this.postButton.Text = "Post";
            this.postButton.UseVisualStyleBackColor = true;
            this.postButton.Click += new System.EventHandler(this.postButton_Click);
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
            // overviewFlowLayoutPanel
            // 
            this.overviewFlowLayoutPanel.AutoScroll = true;
            this.overviewFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.overviewFlowLayoutPanel.Location = new System.Drawing.Point(146, 47);
            this.overviewFlowLayoutPanel.Name = "overviewFlowLayoutPanel";
            this.overviewFlowLayoutPanel.Size = new System.Drawing.Size(729, 509);
            this.overviewFlowLayoutPanel.TabIndex = 9;
            // 
            // UserOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1095, 594);
            this.Controls.Add(this.overviewFlowLayoutPanel);
            this.Controls.Add(this.panel1);
            this.Name = "UserOverview";
            this.Text = "User Overview";
            this.Load += new System.EventHandler(this.UserOverview_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.overviewFlowLayoutPanel, 0);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView sideListView;
        private System.Windows.Forms.Button postButton;
        private System.Windows.Forms.FlowLayoutPanel overviewFlowLayoutPanel;
    }
}
