
namespace PresentationLayer
{
    partial class PostsForm
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
            this.ExitBtn = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ContentLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.ContentTextBox = new System.Windows.Forms.TextBox();
            this.lbUsers = new System.Windows.Forms.ListBox();
            this.UsersLabel = new System.Windows.Forms.Label();
            this.dgvPosts = new System.Windows.Forms.DataGridView();
            this.PostsLabel = new System.Windows.Forms.Label();
            this.CreatePostBtn = new System.Windows.Forms.Button();
            this.UpdatePostBtn = new System.Windows.Forms.Button();
            this.DeletePostBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosts)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(13, 13);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(94, 29);
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(12, 75);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(41, 20);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Title:";
            // 
            // ContentLabel
            // 
            this.ContentLabel.AutoSize = true;
            this.ContentLabel.Location = new System.Drawing.Point(12, 125);
            this.ContentLabel.Name = "ContentLabel";
            this.ContentLabel.Size = new System.Drawing.Size(64, 20);
            this.ContentLabel.TabIndex = 2;
            this.ContentLabel.Text = "Content:";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(98, 72);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(150, 27);
            this.TitleTextBox.TabIndex = 1;
            // 
            // ContentTextBox
            // 
            this.ContentTextBox.Location = new System.Drawing.Point(98, 122);
            this.ContentTextBox.Name = "ContentTextBox";
            this.ContentTextBox.Size = new System.Drawing.Size(150, 27);
            this.ContentTextBox.TabIndex = 2;
            // 
            // lbUsers
            // 
            this.lbUsers.FormattingEnabled = true;
            this.lbUsers.ItemHeight = 20;
            this.lbUsers.Location = new System.Drawing.Point(98, 190);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.Size = new System.Drawing.Size(150, 164);
            this.lbUsers.TabIndex = 3;
            this.lbUsers.SelectedValueChanged += new System.EventHandler(this.lbUsers_SelectedValueChanged);
            // 
            // UsersLabel
            // 
            this.UsersLabel.AutoSize = true;
            this.UsersLabel.Location = new System.Drawing.Point(13, 190);
            this.UsersLabel.Name = "UsersLabel";
            this.UsersLabel.Size = new System.Drawing.Size(47, 20);
            this.UsersLabel.TabIndex = 6;
            this.UsersLabel.Text = "Users:";
            // 
            // dgvPosts
            // 
            this.dgvPosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosts.Location = new System.Drawing.Point(382, 65);
            this.dgvPosts.Name = "dgvPosts";
            this.dgvPosts.RowHeadersWidth = 51;
            this.dgvPosts.RowTemplate.Height = 29;
            this.dgvPosts.Size = new System.Drawing.Size(390, 289);
            this.dgvPosts.TabIndex = 6;
            this.dgvPosts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPosts_CellClick);
            // 
            // PostsLabel
            // 
            this.PostsLabel.AutoSize = true;
            this.PostsLabel.Location = new System.Drawing.Point(573, 22);
            this.PostsLabel.Name = "PostsLabel";
            this.PostsLabel.Size = new System.Drawing.Size(42, 20);
            this.PostsLabel.TabIndex = 8;
            this.PostsLabel.Text = "Posts";
            // 
            // CreatePostBtn
            // 
            this.CreatePostBtn.Location = new System.Drawing.Point(13, 395);
            this.CreatePostBtn.Name = "CreatePostBtn";
            this.CreatePostBtn.Size = new System.Drawing.Size(94, 29);
            this.CreatePostBtn.TabIndex = 4;
            this.CreatePostBtn.Text = "Create";
            this.CreatePostBtn.UseVisualStyleBackColor = true;
            this.CreatePostBtn.Click += new System.EventHandler(this.CreatePostBtn_Click);
            // 
            // UpdatePostBtn
            // 
            this.UpdatePostBtn.Location = new System.Drawing.Point(154, 395);
            this.UpdatePostBtn.Name = "UpdatePostBtn";
            this.UpdatePostBtn.Size = new System.Drawing.Size(94, 29);
            this.UpdatePostBtn.TabIndex = 5;
            this.UpdatePostBtn.Text = "Update";
            this.UpdatePostBtn.UseVisualStyleBackColor = true;
            this.UpdatePostBtn.Click += new System.EventHandler(this.UpdatePostBtn_Click);
            // 
            // DeletePostBtn
            // 
            this.DeletePostBtn.Location = new System.Drawing.Point(532, 395);
            this.DeletePostBtn.Name = "DeletePostBtn";
            this.DeletePostBtn.Size = new System.Drawing.Size(94, 29);
            this.DeletePostBtn.TabIndex = 7;
            this.DeletePostBtn.Text = "Delete";
            this.DeletePostBtn.UseVisualStyleBackColor = true;
            this.DeletePostBtn.Click += new System.EventHandler(this.DeletePostBtn_Click);
            // 
            // PostsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeletePostBtn);
            this.Controls.Add(this.UpdatePostBtn);
            this.Controls.Add(this.CreatePostBtn);
            this.Controls.Add(this.PostsLabel);
            this.Controls.Add(this.dgvPosts);
            this.Controls.Add(this.UsersLabel);
            this.Controls.Add(this.lbUsers);
            this.Controls.Add(this.ContentTextBox);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.ContentLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.ExitBtn);
            this.Name = "PostsForm";
            this.Text = "PostsForm";
            this.Load += new System.EventHandler(this.PostsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label ContentLabel;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox ContentTextBox;
        private System.Windows.Forms.ListBox lbUsers;
        private System.Windows.Forms.Label UsersLabel;
        private System.Windows.Forms.DataGridView dgvPosts;
        private System.Windows.Forms.Label PostsLabel;
        private System.Windows.Forms.Button CreatePostBtn;
        private System.Windows.Forms.Button UpdatePostBtn;
        private System.Windows.Forms.Button DeletePostBtn;
    }
}