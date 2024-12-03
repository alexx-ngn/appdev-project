namespace Y.view.admin
{
    partial class AdminPost
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
            this.deleteButton = new global::System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 19.8F, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new global::System.Drawing.Point(1127, 231);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new global::System.Drawing.Size(66, 66);
            this.deleteButton.TabIndex = 16;
            this.deleteButton.Text = "🗑️";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new global::System.EventHandler(this.deleteButton_Click);
            // 
            // AdminPost
            // 
            this.AutoScaleDimensions = new global::System.Drawing.SizeF(8F, 16F);
            this.Controls.Add(this.deleteButton);
            this.Name = "AdminPost";
            this.Size = new global::System.Drawing.Size(1196, 301);
            this.Controls.SetChildIndex(this.deleteButton, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private global::System.Windows.Forms.Button deleteButton;
    }
}
