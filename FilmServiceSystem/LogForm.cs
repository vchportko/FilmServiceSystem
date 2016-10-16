using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FilmServiceSystem.DAL.Concrete.Repositories;
using System.Configuration;
using FilmServiceSystem.Model;
using FilmServiceSystem.DAL.Concrete.Services;

namespace FilmServiceSystem
{
    
    public partial class LogForm : Form
    {
        UserRepository uR;
        public LogForm()
        {
            InitializeComponent();
            string s = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            uR = new UserRepository(s);
        }

        private void LogButton_Click(object sender, EventArgs e)
        {
            User user = uR.GetUserByLogin(LogTextBox.Text, PassTextBox.Text);
            if(user == null)
            {
                MessageBox.Show("The email and password you entered did not match our records. Please double-check and try again.");
            }
            else
            {
                CurentUserItialization(user);
                this.Hide();
                (new MainForm()).ShowDialog();
               
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (dataIsValid())
            {
                List<User> allUsers = uR.GettAll();
                // check if passing login is unique
                bool isUniqueLogin = (from u in allUsers
                                      where u.Login == loginTB.Text
                                      select u).Count() == 0;
                if (isUniqueLogin)
                {
                    uR.RegisterUser(loginTB.Text, passTB.Text, nameTB.Text, snameTB.Text);
                    User user = uR.GetUserByLogin(loginTB.Text, passTB.Text);
                    CurentUserItialization(user);
                    this.Hide();
                    (new MainForm()).ShowDialog();
                }
                else
                {
                    MessageBox.Show("There is some user with that login,please change login");
                }
            }
            else
            {
                MessageBox.Show("Your data is invalid , please correct them.Your password should include from 4 to 20 symbols");
            }
        }

        private void logOptionButton_Click(object sender, EventArgs e)
        {
            swapPanel(0, 1);
        }

        private void regOptionButton_Click(object sender, EventArgs e)
        {
            swapPanel(1, 0);
        }
        // function for swapping children`s panels at parent FloawLayOutPanel
        private void swapPanel(int logIndex, int regIndex)
        {
            flowLayoutPanel.Controls.SetChildIndex(logPanel, logIndex);
            flowLayoutPanel.Controls.SetChildIndex(registerPanel, regIndex);
        }

        private void CurentUserItialization(User user)
        {
            CurrentUser.Login = user.Login;
            CurrentUser.FirstName = user.FirstName;
            CurrentUser.LastName = user.LastName;
            CurrentUser.Balance = user.Balance;
            CurrentUser.ID = user.ID;
        }

        private bool dataIsValid()
        {
            if (passTB.Text.Length > 4 && passTB.Text.Length < 20)
            {
                if ((System.Text.RegularExpressions.Regex.IsMatch(nameTB.Text, "^[a-zA-Z]"))
                    && (System.Text.RegularExpressions.Regex.IsMatch(snameTB.Text, "^[a-zA-Z]")))
                {
                    return true;
                }
            }
            return false;
       }
    }
}
