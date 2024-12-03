namespace Y
{
    partial class NewPost
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
            global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(NewPost));
            this.postRichTextBox = new global::System.Windows.Forms.RichTextBox();
            this.newPostLabel = new global::System.Windows.Forms.Label();
            this.postButton = new global::System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // postRichTextBox
            // 
            resources.ApplyResources(this.postRichTextBox, "postRichTextBox");
            this.postRichTextBox.Name = "postRichTextBox";
            // 
            // newPostLabel
            // 
            resources.ApplyResources(this.newPostLabel, "newPostLabel");
            this.newPostLabel.Name = "newPostLabel";
            // 
            // postButton
            // 
            resources.ApplyResources(this.postButton, "postButton");
            this.postButton.Name = "postButton";
            this.postButton.UseVisualStyleBackColor = true;
            this.postButton.Click += new global::System.EventHandler(this.postButton_Click);
            // 
            // NewPost
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.postButton);
            this.Controls.Add(this.newPostLabel);
            this.Controls.Add(this.postRichTextBox);
            this.Name = "NewPost";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private global::System.Windows.Forms.RichTextBox postRichTextBox;
        private global::System.Windows.Forms.Label newPostLabel;
        private global::System.Windows.Forms.Button postButton;
    }
}