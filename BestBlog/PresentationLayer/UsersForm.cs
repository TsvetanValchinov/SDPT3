using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ServiceLayer;
using BusinessLayer;
using System.Linq;

namespace PresentationLayer
{
    public partial class UsersForm : Form
    {

        private UserManager userManager;
        private User selectedUser;
        List<User> users;
        int selectedRow = -1;

        public UsersForm()
        {
            InitializeComponent();

            userManager = new UserManager(DbContextManager.CreateContext());
            HeaderRowLoading();
            UsersLoading();

        }

        private void HeaderRowLoading()
        {
            dgvUsers.Columns.Add("id", "ID");
            dgvUsers.Columns.Add("username", "Username");
            dgvUsers.Columns.Add("password", "Password");
        }

        private void UsersLoading()
        {
            users = userManager.ReadAll().ToList();

            foreach (User user in users)
            {
                DataGridViewRow row = (DataGridViewRow)dgvUsers.Rows[0].Clone();

                row.Cells[0].Value = user.ID;
                row.Cells[1].Value = user.Username;
                row.Cells[2].Value = user.Password;
                dgvUsers.Rows.Add(row);
            }
        }

        private void AddUserRow(User user)
        {
            DataGridViewRow row = (DataGridViewRow)dgvUsers.Rows[0].Clone();

            row.Cells[0].Value = user.ID;
            row.Cells[1].Value = user.Username;
            row.Cells[2].Value = user.Password;
            dgvUsers.Rows.Add(row);
        }

        private void UpdateUserRow()
        {
            dgvUsers.Rows[selectedRow].Cells[0].Value = selectedUser.ID;
            dgvUsers.Rows[selectedRow].Cells[1].Value = selectedUser.Username;
            dgvUsers.Rows[selectedRow].Cells[2].Value = selectedUser.Password;
        }

        private void DeleteUserRow()
        {
            dgvUsers.Rows.RemoveAt(selectedRow);
        }

        private void ClearData()
        {
            UsernameTextBox.Text = string.Empty;
            PasswordTextBox.Text = string.Empty;
        }

        private bool ValidateData()
        {
            if (UsernameTextBox.Text != string.Empty && PasswordTextBox.Text != string.Empty)
            {
                return true;
            }

            return false;
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {

        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateUserBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(selectedUser!=null)
                {
                    MessageBox.Show("You have selected existing user!", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

                if(ValidateData())
                {
                    string username = UsernameTextBox.Text;
                    string password = PasswordTextBox.Text;
                    User user = new User(username, password);
                    userManager.Create(user);
                    MessageBox.Show("User created successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddUserRow(user);
                    ClearData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateUserBtn_Click(object sender, EventArgs e)
        {
            if(ValidateData() && selectedUser!=null)
            {
                selectedUser.Username = UsernameTextBox.Text;
                selectedUser.Password = PasswordTextBox.Text;
                userManager.Update(selectedUser);
                MessageBox.Show("User updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateUserRow();
                ClearData();
            }
            else
            {
                MessageBox.Show("The given fields can't be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteUserBtn_Click(object sender, EventArgs e)
        {
            if(selectedUser!=null)
            {
                userManager.Delete(selectedUser.ID);
                MessageBox.Show("User deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DeleteUserRow();
                ClearData();
            }
            else
            {
                MessageBox.Show("There is no user selected. You need to select user in order to delete it!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                users = userManager.ReadAll().ToList();
                if(e.RowIndex < users.Count)
                {
                    int id = Convert.ToInt32(dgvUsers.Rows[e.RowIndex].Cells[0].Value);
                    string username = dgvUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string password = dgvUsers.Rows[e.RowIndex].Cells[2].Value.ToString();

                    selectedUser = users.Find(u => u.ID == id);
                    UsernameTextBox.Text = username;
                    PasswordTextBox.Text = password;
                    selectedRow = e.RowIndex;
                }
                else
                {
                    ClearData();
                }
            }
        }
    }
}
