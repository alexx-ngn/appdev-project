namespace Y.view.admin
{
    partial class PostReport
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
            this.userPost1 = new Y.UserPost();
            this.reasonUserControl1 = new Y.view.ReasonUserControl();
            this.banButton = new System.Windows.Forms.Button();
            this.allowButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userPost1
            // 
            this.userPost1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userPost1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userPost1.Location = new System.Drawing.Point(12, 291);
            this.userPost1.Name = "userPost1";
            this.userPost1.Size = new System.Drawing.Size(1200, 242);
            this.userPost1.TabIndex = 0;
            // 
            // reasonUserControl1
            // 
            this.reasonUserControl1.Location = new System.Drawing.Point(12, 12);
            this.reasonUserControl1.Name = "reasonUserControl1";
            this.reasonUserControl1.Size = new System.Drawing.Size(1200, 262);
            this.reasonUserControl1.TabIndex = 1;
            // 
            // banButton
            // 
            this.banButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.banButton.ForeColor = System.Drawing.Color.Red;
            this.banButton.Location = new System.Drawing.Point(1140, 547);
            this.banButton.Name = "banButton";
            this.banButton.Size = new System.Drawing.Size(72, 33);
            this.banButton.TabIndex = 18;
            this.banButton.Text = "BAN";
            this.banButton.UseVisualStyleBackColor = true;
            // 
            // allowButton
            // 
            this.allowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allowButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.allowButton.Location = new System.Drawing.Point(1031, 547);
            this.allowButton.Name = "allowButton";
            this.allowButton.Size = new System.Drawing.Size(103, 33);
            this.allowButton.TabIndex = 19;
            this.allowButton.Text = "DISMISS";
            this.allowButton.UseVisualStyleBackColor = true;
            // 
            // PostReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 592);
            this.Controls.Add(this.allowButton);
            this.Controls.Add(this.banButton);
            this.Controls.Add(this.reasonUserControl1);
            this.Controls.Add(this.userPost1);
            this.Name = "PostReport";
            this.Text = "PostReport";
            this.ResumeLayout(false);

        }

        #endregion

        private UserPost userPost1;
        private ReasonUserControl reasonUserControl1;
        private System.Windows.Forms.Button banButton;
        private System.Windows.Forms.Button allowButton;
    }
}