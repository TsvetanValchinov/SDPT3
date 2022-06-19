using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLayer;
using ServiceLayer;

namespace PresentationLayer
{
    public partial class PostsForm : Form
    {
        private PostManager postManager;
        private UserManager userManager;
        private Post selectedPost;
        private User selectedUser;
        private List<Post> posts;
        int selectedRowIndex = -1;


        public PostsForm()
        {
            InitializeComponent();

            postManager = new PostManager(DbContextManager.CreateContext());
            userManager = new UserManager(DbContextManager.CreateContext());

            HeaderRowLoading();
            PostsLoading();
            UsersLoading();
        }

        private void HeaderRowLoading()
        {
            dgvPosts.Columns.Add("id", "Id");
            dgvPosts.Columns.Add("title", "Title");
            dgvPosts.Columns.Add("content", "Content");
            dgvPosts.Columns.Add("username", "user");
        }

        private void PostsLoading()
        {
            posts = postManager.ReadAll().ToList();

            foreach (Post post in posts)
            {
                DataGridViewRow row = (DataGridViewRow)dgvPosts.Rows[0].Clone();

                row.Cells[0].Value = post.ID;
                row.Cells[1].Value = post.Title;
                row.Cells[2].Value = post.Content;
                row.Cells[3].Value = userManager.Read(post.UserID).Username;
                dgvPosts.Rows.Add(row);
            }
        }

        private void UsersLoading()
        {
            lbUsers.DataSource = userManager.ReadAll();

            lbUsers.DisplayMember = "Username";
            lbUsers.ValueMember = "ID";
        }

        private void ClearData()
        {
            TitleTextBox.Text = string.Empty;
            ContentTextBox.Text = string.Empty;
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

        private void AddPostRow(Post post)
        {
            DataGridViewRow row = (DataGridViewRow)dgvPosts.Rows[0].Clone();

            row.Cells[0].Value = post.ID;
            row.Cells[1].Value = post.Title;
            row.Cells[2].Value = post.Content;
            row.Cells[3].Value = userManager.Read(post.UserID).Username;
            dgvPosts.Rows.Add(row);
        }

        private void UpdatePostRow()
        {
            dgvPosts.Rows[selectedRowIndex].Cells[0].Value = selectedPost.ID;
            dgvPosts.Rows[selectedRowIndex].Cells[1].Value = selectedPost.Title;
            dgvPosts.Rows[selectedRowIndex].Cells[2].Value = selectedPost.Content;
            dgvPosts.Rows[selectedRowIndex].Cells[3].Value = userManager.Read(selectedPost.UserID).Username;
        }

        private void DeletePostRow()
        {
            dgvPosts.Rows.RemoveAt(selectedRowIndex);
        }

        private bool ValidateData()
        {
            if (TitleTextBox.Text != string.Empty && ContentTextBox.Text != string.Empty)
            {
                return true;
            }

            return false;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreatePostBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(selectedPost!=null)
                {
                    MessageBox.Show("You have selected post! You can't dublicate posts!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if(ValidateData() && selectedUser!=null)
                {
                    string title = TitleTextBox.Text;
                    string content = ContentTextBox.Text;
                    User user = selectedUser;
                    Post post = new Post(user, title);
                    post.Content = content;
                    postManager.Create(post);
                    MessageBox.Show("Post created successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddPostRow(post);
                    ClearData();
                    
                }
                else
                {
                    MessageBox.Show("Title, Content and Selected player are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw ex;
            }
        }

        private void UpdatePostBtn_Click(object sender, EventArgs e)
        {
            if(ValidateData() && selectedPost!=null)
            {
                selectedPost.Title = TitleTextBox.Text;
                selectedPost.Content = ContentTextBox.Text;
                postManager.Update(selectedPost);
                MessageBox.Show("Post updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdatePostRow();
                ClearData();
            }
            else
            {
                MessageBox.Show("The given fields can't be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeletePostBtn_Click(object sender, EventArgs e)
        {
            if (selectedPost != null)
            {
                postManager.Delete(selectedPost.ID);
                MessageBox.Show("Post deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DeletePostRow();
                ClearData();
            }
            else
            {
                MessageBox.Show("There is no post selected. You need to select post in order to delete it!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPosts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                posts = postManager.ReadAll().ToList();
                if (e.RowIndex < posts.Count())
                {
                    int id = Convert.ToInt32(dgvPosts.Rows[e.RowIndex].Cells[0].Value);
                    string title = dgvPosts.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string content = dgvPosts.Rows[e.RowIndex].Cells[2].Value.ToString();
                    string username = dgvPosts.Rows[e.RowIndex].Cells[3].Value.ToString();
                    selectedPost = posts.Find(p => p.ID == id);
                    TitleTextBox.Text = title;
                    ContentTextBox.Text = content;
                    lbUsers.SelectedItem = userManager.Read(selectedPost.UserID);
                    selectedRowIndex = e.RowIndex;
                    
                }
                else
                {
                    ClearData();
                }
            }
        }

        private void PostsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
