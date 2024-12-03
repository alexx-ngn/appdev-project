namespace Y
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private global::System.ComponentModel.IContainer components = null;

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
            global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.YLabel = new global::System.Windows.Forms.Label();
            this.usernameTextBox = new global::System.Windows.Forms.TextBox();
            this.usernameLabel = new global::System.Windows.Forms.Label();
            this.label1 = new global::System.Windows.Forms.Label();
            this.passwordTextBox = new global::System.Windows.Forms.TextBox();
            this.enterButton = new global::System.Windows.Forms.Button();
            this.registerLabel = new global::System.Windows.Forms.LinkLabel();
            this.languageComboBox = new global::System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // YLabel
            // 
            resources.ApplyResources(this.YLabel, "YLabel");
            this.YLabel.Name = "YLabel";
            // 
            // usernameTextBox
            // 
            resources.ApplyResources(this.usernameTextBox, "usernameTextBox");
            this.usernameTextBox.Name = "usernameTextBox";
            // 
            // usernameLabel
            // 
            resources.ApplyResources(this.usernameLabel, "usernameLabel");
            this.usernameLabel.Name = "usernameLabel";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // passwordTextBox
            // 
            resources.ApplyResources(this.passwordTextBox, "passwordTextBox");
            this.passwordTextBox.Name = "passwordTextBox";
            // 
            // enterButton
            // 
            resources.ApplyResources(this.enterButton, "enterButton");
            this.enterButton.Name = "enterButton";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new global::System.EventHandler(this.enterButton_Click);
            // 
            // registerLabel
            // 
            resources.ApplyResources(this.registerLabel, "registerLabel");
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.TabStop = true;
            this.registerLabel.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerLabel_LinkClicked);
            // 
            // languageComboBox
            // 
            resources.ApplyResources(this.languageComboBox, "languageComboBox");
            this.languageComboBox.FormattingEnabled = true;
            this.languageComboBox.Items.AddRange(new object[] {
            resources.GetString("languageComboBox.Items"),
            resources.GetString("languageComboBox.Items1")});
            this.languageComboBox.Name = "languageComboBox";
            this.languageComboBox.SelectedIndexChanged += new global::System.EventHandler(this.languageComboBox_SelectedIndexChanged);
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.languageComboBox);
            this.Controls.Add(this.registerLabel);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.YLabel);
            this.Name = "Login";
            this.Load += new global::System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private global::System.Windows.Forms.Label YLabel;
        private global::System.Windows.Forms.TextBox usernameTextBox;
        private global::System.Windows.Forms.Label usernameLabel;
        private global::System.Windows.Forms.Label label1;
        private global::System.Windows.Forms.TextBox passwordTextBox;
        private global::System.Windows.Forms.Button enterButton;
        private global::System.Windows.Forms.LinkLabel registerLabel;
        private global::System.Windows.Forms.ComboBox languageComboBox;
    }
}

