
namespace PresentationLayer
{
    partial class CommentsForm
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
            this.ContentLabel = new System.Windows.Forms.Label();
            this.ContentTextBox = new System.Windows.Forms.TextBox();
            this.UsersLabel = new System.Windows.Forms.Label();
            this.lbUsers = new System.Windows.Forms.ListBox();
            this.PostsLabel = new System.Windows.Forms.Label();
            this.lbPosts = new System.Windows.Forms.ListBox();
            this.CommentsLabel = new System.Windows.Forms.Label();
            this.dgvComments = new System.Windows.Forms.DataGridView();
            this.CreateCommentBtn = new System.Windows.Forms.Button();
            this.UpdateCommenBtn = new System.Windows.Forms.Button();
            this.DeleteCommentBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComments)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(12, 12);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(94, 29);
            this.ExitBtn.TabIndex = 0;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // ContentLabel
            // 
            this.ContentLabel.AutoSize = true;
            this.ContentLabel.Location = new System.Drawing.Point(12, 97);
            this.ContentLabel.Name = "ContentLabel";
            this.ContentLabel.Size = new System.Drawing.Size(64, 20);
            this.ContentLabel.TabIndex = 1;
            this.ContentLabel.Text = "Content:";
            // 
            // ContentTextBox
            // 
            this.ContentTextBox.Location = new System.Drawing.Point(101, 94);
            this.ContentTextBox.Name = "ContentTextBox";
            this.ContentTextBox.Size = new System.Drawing.Size(150, 27);
            this.ContentTextBox.TabIndex = 1;
            // 
            // UsersLabel
            // 
            this.UsersLabel.AutoSize = true;
            this.UsersLabel.Location = new System.Drawing.Point(12, 169);
            this.UsersLabel.Name = "UsersLabel";
            this.UsersLabel.Size = new System.Drawing.Size(47, 20);
            this.UsersLabel.TabIndex = 2;
            this.UsersLabel.Text = "Users:";
            // 
            // lbUsers
            // 
            this.lbUsers.FormattingEnabled = true;
            this.lbUsers.ItemHeight = 20;
            this.lbUsers.Location = new System.Drawing.Point(101, 169);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.Size = new System.Drawing.Size(150, 104);
            this.lbUsers.TabIndex = 2;
            this.lbUsers.SelectedValueChanged += new System.EventHandler(this.lbUsers_SelectedValueChanged);
            // 
            // PostsLabel
            // 
            this.PostsLabel.AutoSize = true;
            this.PostsLabel.Location = new System.Drawing.Point(12, 311);
            this.PostsLabel.Name = "PostsLabel";
            this.PostsLabel.Size = new System.Drawing.Size(45, 20);
            this.PostsLabel.TabIndex = 3;
            this.PostsLabel.Text = "Posts:";
            // 
            // lbPosts
            // 
            this.lbPosts.FormattingEnabled = true;
            this.lbPosts.ItemHeight = 20;
            this.lbPosts.Location = new System.Drawing.Point(101, 311);
            this.lbPosts.Name = "lbPosts";
            this.lbPosts.Size = new System.Drawing.Size(150, 104);
            this.lbPosts.TabIndex = 3;
            this.lbPosts.SelectedValueChanged += new System.EventHandler(this.lbPosts_SelectedValueChanged);
            // 
            // CommentsLabel
            // 
            this.CommentsLabel.AutoSize = true;
            this.CommentsLabel.Location = new System.Drawing.Point(540, 39);
            this.CommentsLabel.Name = "CommentsLabel";
            this.CommentsLabel.Size = new System.Drawing.Size(80, 20);
            this.CommentsLabel.TabIndex = 4;
            this.CommentsLabel.Text = "Comments";
            // 
            // dgvComments
            // 
            this.dgvComments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComments.Location = new System.Drawing.Point(370, 94);
            this.dgvComments.Name = "dgvComments";
            this.dgvComments.RowHeadersWidth = 51;
            this.dgvComments.RowTemplate.Height = 29;
            this.dgvComments.Size = new System.Drawing.Size(395, 235);
            this.dgvComments.TabIndex = 7;
            this.dgvComments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComments_CellClick);
            // 
            // CreateCommentBtn
            // 
            this.CreateCommentBtn.Location = new System.Drawing.Point(370, 377);
            this.CreateCommentBtn.Name = "CreateCommentBtn";
            this.CreateCommentBtn.Size = new System.Drawing.Size(94, 29);
            this.CreateCommentBtn.TabIndex = 4;
            this.CreateCommentBtn.Text = "Create";
            this.CreateCommentBtn.UseVisualStyleBackColor = true;
            this.CreateCommentBtn.Click += new System.EventHandler(this.CreateCommentBtn_Click);
            // 
            // UpdateCommenBtn
            // 
            this.UpdateCommenBtn.Location = new System.Drawing.Point(526, 377);
            this.UpdateCommenBtn.Name = "UpdateCommenBtn";
            this.UpdateCommenBtn.Size = new System.Drawing.Size(94, 29);
            this.UpdateCommenBtn.TabIndex = 5;
            this.UpdateCommenBtn.Text = "Update";
            this.UpdateCommenBtn.UseVisualStyleBackColor = true;
            this.UpdateCommenBtn.Click += new System.EventHandler(this.UpdateCommenBtn_Click);
            // 
            // DeleteCommentBtn
            // 
            this.DeleteCommentBtn.Location = new System.Drawing.Point(671, 377);
            this.DeleteCommentBtn.Name = "DeleteCommentBtn";
            this.DeleteCommentBtn.Size = new System.Drawing.Size(94, 29);
            this.DeleteCommentBtn.TabIndex = 6;
            this.DeleteCommentBtn.Text = "Delete";
            this.DeleteCommentBtn.UseVisualStyleBackColor = true;
            this.DeleteCommentBtn.Click += new System.EventHandler(this.DeleteCommentBtn_Click);
            // 
            // CommentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteCommentBtn);
            this.Controls.Add(this.UpdateCommenBtn);
            this.Controls.Add(this.CreateCommentBtn);
            this.Controls.Add(this.dgvComments);
            this.Controls.Add(this.CommentsLabel);
            this.Controls.Add(this.lbPosts);
            this.Controls.Add(this.PostsLabel);
            this.Controls.Add(this.lbUsers);
            this.Controls.Add(this.UsersLabel);
            this.Controls.Add(this.ContentTextBox);
            this.Controls.Add(this.ContentLabel);
            this.Controls.Add(this.ExitBtn);
            this.Name = "CommentsForm";
            this.Text = "CommentsForm";
            this.Load += new System.EventHandler(this.CommentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label ContentLabel;
        private System.Windows.Forms.TextBox ContentTextBox;
        private System.Windows.Forms.Label UsersLabel;
        private System.Windows.Forms.ListBox lbUsers;
        private System.Windows.Forms.Label PostsLabel;
        private System.Windows.Forms.ListBox lbPosts;
        private System.Windows.Forms.Label CommentsLabel;
        private System.Windows.Forms.DataGridView dgvComments;
        private System.Windows.Forms.Button CreateCommentBtn;
        private System.Windows.Forms.Button UpdateCommenBtn;
        private System.Windows.Forms.Button DeleteCommentBtn;
    }
}