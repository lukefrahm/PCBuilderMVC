using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using BusinessObjects;
using BusinessLogic;
namespace PCBuilderForms
{
    /// <summary>
    /// Interaction logic for LogIn.xaml
    /// </summary>
    public partial class LogIn : Window
    {
        public AccessToken _accessToken;

        /// <summary>
        /// Initializes a new instance of the <see cref="LogIn"/> class.
        /// </summary>
        public LogIn()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Checked event of the chkNewUser control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void chkNewUser_Checked(object sender, RoutedEventArgs e)
        {
            lblPassConfirm.Visibility = Visibility.Visible;
            txtPassConfirm.Visibility = Visibility.Visible;
            lblFirstName.Visibility = Visibility.Visible;
            txtFirstName.Visibility = Visibility.Visible;
            lblLastName.Visibility = Visibility.Visible;
            txtLastName.Visibility = Visibility.Visible;
            lblAddress.Visibility = Visibility.Visible;
            txtAddress.Visibility = Visibility.Visible;
            lblCity.Visibility = Visibility.Visible;
            txtCity.Visibility = Visibility.Visible;
            lblState.Visibility = Visibility.Visible;
            txtState.Visibility = Visibility.Visible;
            lblZip.Visibility = Visibility.Visible;
            txtZip.Visibility = Visibility.Visible;
            lblPhone.Visibility = Visibility.Visible;
            txtPhone.Visibility = Visibility.Visible;
            lblEmail.Visibility = Visibility.Visible;
            txtEmail.Visibility = Visibility.Visible;

            lblPassword.Content = "Choose Password:";
        }

        /// <summary>
        /// Handles the Unchecked event of the chkNewUser control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void chkNewUser_Unchecked(object sender, RoutedEventArgs e)
        {
            lblPassConfirm.Visibility = Visibility.Hidden;
            txtPassConfirm.Visibility = Visibility.Hidden;
            lblFirstName.Visibility = Visibility.Hidden;
            txtFirstName.Visibility = Visibility.Hidden;
            lblLastName.Visibility = Visibility.Hidden;
            txtLastName.Visibility = Visibility.Hidden;
            lblAddress.Visibility = Visibility.Hidden;
            txtAddress.Visibility = Visibility.Hidden;
            lblCity.Visibility = Visibility.Hidden;
            txtCity.Visibility = Visibility.Hidden;
            lblState.Visibility = Visibility.Hidden;
            txtState.Visibility = Visibility.Hidden;
            lblZip.Visibility = Visibility.Hidden;
            txtZip.Visibility = Visibility.Hidden;
            lblPhone.Visibility = Visibility.Hidden;
            txtPhone.Visibility = Visibility.Hidden;
            lblEmail.Visibility = Visibility.Hidden;
            txtEmail.Visibility = Visibility.Hidden;

            lblPassword.Content = "Password:";
        }

        /// <summary>
        /// Handles the Click event of the btnSubmit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string username = this.txtUsername.Text;
            string password = this.txtPassword.Password;
            string passConfirm = this.txtPassConfirm.Password;

            try
            {
                if (chkNewUser.IsChecked == true)
                {
                    if (0 != string.Compare(password, passConfirm)) // 0 represents match
                    {
                        MessageBox.Show("Password Mismatch", "Passwords do not match. Please enter you password and confirmation again.", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    }
                    User usr = new User();
                    usr.FirstName = txtFirstName.Text;
                    usr.LastName = txtLastName.Text;
                    usr.Address = txtAddress.Text;
                    usr.City = txtCity.Text;
                    usr.State = txtState.Text;
                    usr.Zip = txtZip.Text;
                    usr.LocalPhone = txtPhone.Text;
                    usr.EmailAddress = txtEmail.Text;
                    usr.UserName = txtUsername.Text;
                    usr.Password = txtPassword.Password;
                    _accessToken = SecurityManager.ValidateNewUser(usr);
                }
                else
                {
                    _accessToken = SecurityManager.ValidateExistingUser(username, password);
                }
                this.DialogResult = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login failed:\n" + ex.Message);
                this.DialogResult = false;
            }
        }

        /// <summary>
        /// Handles the Click event of the btnCancel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            _accessToken = null; // not necessary, but explicity labels as null. Because of the next line, this occurs automatically
            this.DialogResult = false;
        }
    }
}