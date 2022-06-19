using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessLayer;
using ServiceLayer;
using System.Linq;

namespace PresentationLayer
{
    public partial class CommentsForm : Form
    {

        private CommentManager commentManager;
        private UserManager userManager;
        private PostManager postManager;
        private Comment selectedComment;
        private User selectedUser;
        private Post selectedPost;
        private List<Comment> comments;
        int selectedRowIndex = -1;


        public CommentsForm()
        {
            InitializeComponent();

            commentManager = new CommentManager(DbContextManager.CreateContext());
            userManager = new UserManager(DbContextManager.CreateContext());
            postManager = new PostManager(DbContextManager.CreateContext());

            HeaderRowLoading();
            CommentsLoading();
            UsersLoading();
            PostsLoading();
        }

        private void HeaderRowLoading()
        {
            dgvComments.Columns.Add("id", "ID");
            dgvComments.Columns.Add("content", "Content");
            dgvComments.Columns.Add("username", "User");
            dgvComments.Columns.Add("postId", "PostID");
        }

        private void CommentsLoading()
        {
            comments = commentManager.ReadAll().ToList();

            foreach (Comment comment in comments)
            {
                DataGridViewRow row = (DataGridViewRow)dgvComments.Rows[0].Clone();

                row.Cells[0].Value = comment.ID;
                row.Cells[1].Value = comment.Content;
                row.Cells[2].Value = userManager.Read(comment.UserID).Username;
                row.Cells[3].Value = postManager.Read(comment.PostID).ID;
                dgvComments.Rows.Add(row);
            }
        }

        private void UsersLoading()
        {
            lbUsers.DataSource = userManager.ReadAll();
            lbUsers.DisplayMember = "Username";
            lbUsers.ValueMember = "ID";
        }

        private void PostsLoading()
        {
            lbPosts.DataSource = postManager.ReadAll();
            lbPosts.DisplayMember = "ID";
            lbPosts.ValueMember = "ID";
        }

        private void ClearData()
        {
            ContentTextBox.Text = string.Empty;
            selectedComment = null;
            selectedUser = null;
            selectedPost = null;
        }

        private void lbUsers_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lbUsers.SelectedValue != null)
            {
                selectedUser = (User)lbUsers.SelectedItem;
            }
        }

        private void lbPosts_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lbPosts.SelectedValue != null)
            {
                selectedPost = (Post)lbPosts.SelectedItem;
            }
        }

        private bool ValidateData()
        {
            if (ContentTextBox.Text != string.Empty)
            {
                return true;
            }
            return false;
        }

        private void AddCommentRow(Comment comment)
        {
            DataGridViewRow row = (DataGridViewRow)dgvComments.Rows[0].Clone();

            row.Cells[0].Value = comment.ID;
            row.Cells[1].Value = comment.Content;
            row.Cells[2].Value = userManager.Read(comment.UserID).Username;
            row.Cells[3].Value = postManager.Read(comment.PostID).ID;
            dgvComments.Rows.Add(row);
        }

        private void UpdateCommentRow()
        {
            dgvComments.Rows[selectedRowIndex].Cells[0].Value = selectedComment.ID;
            dgvComments.Rows[selectedRowIndex].Cells[1].Value = selectedComment.Content;
            dgvComments.Rows[selectedRowIndex].Cells[2].Value = userManager.Read(selectedComment.UserID).Username;
            dgvComments.Rows[selectedRowIndex].Cells[3].Value = postManager.Read(selectedComment.PostID).ID;
        }

        private void DeleteCommentRow()
        {
            dgvComments.Rows.RemoveAt(selectedRowIndex);
        }

        private void CommentsForm_Load(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateCommentBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedComment != null)
                {
                    MessageBox.Show("You have selected comment!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if(ValidateData() && selectedUser != null && selectedPost != null)
                {
                    string content = ContentTextBox.Text;
                    Comment comment = new Comment(content, selectedPost, selectedUser);
                    commentManager.Create(comment);
                    MessageBox.Show("Comment created successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddCommentRow(comment);
                    ClearData();
                }
                else
                {
                    MessageBox.Show("Content, selected User and selected post are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }

        private void UpdateCommenBtn_Click(object sender, EventArgs e)
        {
            if (ValidateData() && selectedComment != null)
            {
                selectedComment.Content = ContentTextBox.Text;
                commentManager.Update(selectedComment);
                MessageBox.Show("Comment updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateCommentRow();
                ClearData();
            }
            else
            {
                MessageBox.Show("The given fields can't be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteCommentBtn_Click(object sender, EventArgs e)
        {
            if (selectedComment != null)
            {
                commentManager.Delete(selectedComment.ID);
                MessageBox.Show("Comment deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DeleteCommentRow();
                ClearData();
            }
            else
            {
                MessageBox.Show("There is no comment selected. You need to select comment in order to delete it!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvComments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                comments = commentManager.ReadAll().ToList();
                if (e.RowIndex < comments.Count())
                {
                    int id = Convert.ToInt32(dgvComments.Rows[e.RowIndex].Cells[0].Value);
                    string content = dgvComments.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string username = dgvComments.Rows[e.RowIndex].Cells[2].Value.ToString();
                    int postID = Convert.ToInt32(dgvComments.Rows[e.RowIndex].Cells[3].Value.ToString());
                    selectedComment = comments.Find(c => c.ID == id);
                    ContentTextBox.Text = content;
                    lbUsers.SelectedItem = userManager.Read(selectedComment.UserID);
                    lbPosts.SelectedItem = postManager.Read(selectedComment.PostID);
                    selectedRowIndex = e.RowIndex;
                }
                else
                {
                    ClearData();
                }
            }
        }
    }
}
