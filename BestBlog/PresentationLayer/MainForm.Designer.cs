
namespace PresentationLayer
{
    partial class MainForm
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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.UsersButton = new System.Windows.Forms.Button();
            this.PostsButton = new System.Windows.Forms.Button();
            this.CommentsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WelcomeLabel.Location = new System.Drawing.Point(279, 61);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(200, 25);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Welcome to BestBlog !";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(12, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(94, 29);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // UsersButton
            // 
            this.UsersButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsersButton.Location = new System.Drawing.Point(101, 226);
            this.UsersButton.Name = "UsersButton";
            this.UsersButton.Size = new System.Drawing.Size(145, 60);
            this.UsersButton.TabIndex = 2;
            this.UsersButton.Text = "USERS";
            this.UsersButton.UseVisualStyleBackColor = true;
            this.UsersButton.Click += new System.EventHandler(this.UsersButton_Click);
            // 
            // PostsButton
            // 
            this.PostsButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PostsButton.Location = new System.Drawing.Point(325, 226);
            this.PostsButton.Name = "PostsButton";
            this.PostsButton.Size = new System.Drawing.Size(145, 60);
            this.PostsButton.TabIndex = 3;
            this.PostsButton.Text = "POSTS";
            this.PostsButton.UseVisualStyleBackColor = true;
            this.PostsButton.Click += new System.EventHandler(this.PostsButton_Click);
            // 
            // CommentsButton
            // 
            this.CommentsButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CommentsButton.Location = new System.Drawing.Point(553, 226);
            this.CommentsButton.Name = "CommentsButton";
            this.CommentsButton.Size = new System.Drawing.Size(145, 60);
            this.CommentsButton.TabIndex = 4;
            this.CommentsButton.Text = "COMMENTS";
            this.CommentsButton.UseVisualStyleBackColor = true;
            this.CommentsButton.Click += new System.EventHandler(this.CommentsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CommentsButton);
            this.Controls.Add(this.PostsButton);
            this.Controls.Add(this.UsersButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.WelcomeLabel);
            this.Name = "MainForm";
            this.Text = "BestBlog";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button UsersButton;
        private System.Windows.Forms.Button PostsButton;
        private System.Windows.Forms.Button CommentsButton;
    }
}