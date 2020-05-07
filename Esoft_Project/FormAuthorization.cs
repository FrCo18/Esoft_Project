using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esoft_Project
{
    public struct User
    {
        public string login;
        public string password;
        public string type;
    }
    public partial class FormAuthorization : Form
    {
        public static User users = new User();
        public FormAuthorization()
        {
            InitializeComponent();
        }
        private void buttonOK_Click(object sender, EventArgs e)
        {
            users.login = "";
            users.password = "";
            users.type = "";
            Menu menu = new Menu();
            foreach (Users user in Program.wftDb.Users)
                {
                    if (textBoxLogin.Text == user.Login && textBoxPassword.Text == user.Password)
                    {
                        users.login = textBoxLogin.Text.ToString();
                        users.password = textBoxPassword.Text.ToString();
                    users.type = user.Type;
                    menu.Show();
                }
                }
            if (menu.Visible == false)
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
