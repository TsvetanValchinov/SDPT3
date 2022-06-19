using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm();
            usersForm.ShowDialog();
        }

        private void PostsButton_Click(object sender, EventArgs e)
        {
            PostsForm postsForm = new PostsForm();
            postsForm.ShowDialog();
        }

        private void CommentsButton_Click(object sender, EventArgs e)
        {
            CommentsForm commentsForm = new CommentsForm();
            commentsForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
