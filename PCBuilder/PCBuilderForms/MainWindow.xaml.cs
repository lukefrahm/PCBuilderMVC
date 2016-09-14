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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AccessToken _accessToken;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the btnLogin control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            var login = new LogIn(); // need to create login dialog
            var result = login.ShowDialog();
            this._accessToken = login._accessToken;
            
            if ( result == true && this._accessToken != null)
            {
                lblLoginMessage.Content = "Welcome back, " + _accessToken.FirstName + "!";
                // login succeeds
            }
        }

        /// <summary>
        /// Handles the Click event of the btnQuestionnaire control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void btnQuestionnaire_Click(object sender, RoutedEventArgs e)
        {
            var q = new Questionnaire();
            var result = q.ShowDialog();
            if (result == true)
            {
                QuestionnaireResults qr = q.QR;
                FinalizedBuild fb = q.FB;

                tabBuildOutput.IsEnabled = true;
                tabBuildOutput.Focus();

                Populator(qr, fb);
            }
        }

        /// <summary>
        /// Populators the specified labels based on questionnaire and build results.
        /// </summary>
        /// <param name="qr">The Questionnaire Results.</param>
        /// <param name="fb">The Finalized Build.</param>
        private void Populator(QuestionnaireResults qr, FinalizedBuild fb)
        {
            if (fb.message != "")
            {
                MessageBox.Show(fb.message, "Problem Building PC", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            lblCpuBrand.Content = fb.cpu.Brand.ToString();
            if (fb.gpu.Brand == null)
            {
                lblGpuBrand.Content = "None";
            }
            else
            {
                lblGpuBrand.Content = fb.gpu.Brand.ToString();
            }
            lblMotherboardBrand.Content = fb.motherboard.Brand.ToString();
            if (fb.optical.Brand == null)
            {
                lblOpticalBrand.Content = "None";
            }
            else
            {
                lblOpticalBrand.Content = fb.optical.Brand.ToString();
            }
            lblPsuBrand.Content = fb.psu.Brand.ToString();
            lblRamBrand.Content = fb.ram.Brand.ToString();
            lblStorageBrand.Content = fb.storage.Brand.ToString();

            lblCpuModel.Content = fb.cpu.Model.ToString();
            if (fb.gpu.Model == null)
            {
                lblGpuModel.Content = "None";
            }
            else
            {
                lblGpuModel.Content = fb.gpu.Model.ToString();
            }
            lblMotherboardModel.Content = fb.motherboard.Model.ToString();
            if (fb.optical.Model == null)
            {
                lblOpticalModel.Content = "None";
            }
            else
            {
                lblOpticalModel.Content = fb.optical.Model.ToString();
            }
            lblPsuModel.Content = fb.psu.Model.ToString();
            lblRamModel.Content = fb.ram.Model.ToString();
            lblStorageModel.Content = fb.storage.Model.ToString();

            lblCPUPrice.Content = fb.cpu.Price.ToString();
            if (fb.gpu.Model == "None")
            {
                lblGPUPrice.Content = "0.00";
            }
            else
            {
                lblGPUPrice.Content = fb.gpu.Price.ToString();
            }
            lblMotherboardPrice.Content = fb.motherboard.Price.ToString();
            if (fb.optical.Model == "None")
            {
                lblOpticalPrice.Content = "0.00";
            }
            else
            {
                lblOpticalPrice.Content = fb.optical.Price.ToString();
            }
            lblPSUPrice.Content = fb.psu.Price.ToString();
            lblRAMPrice.Content = fb.ram.Price.ToString();
            lblStoragePrice.Content = fb.storage.Price.ToString();

            lblTotalPrice.Content = Convert.ToDecimal(lblCPUPrice.Content) + Convert.ToDecimal(lblGPUPrice.Content) + Convert.ToDecimal(lblMotherboardPrice.Content) + Convert.ToDecimal(lblOpticalPrice.Content) + Convert.ToDecimal(lblPSUPrice.Content) + Convert.ToDecimal(lblRAMPrice.Content) + Convert.ToDecimal(lblStoragePrice.Content);
        }

        /// <summary>
        /// Handles the Click event of the mnuExit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void mnuExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
