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
using System.Windows.Forms;

namespace PCBuilderForms
{
    /// <summary>
    /// Interaction logic for Questionnaire.xaml
    /// </summary>
    public partial class Questionnaire : Window
    {
        // used to pass back objects after form close
        public FinalizedBuild FB { get; set; }
        public QuestionnaireResults QR { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Questionnaire"/> class.
        /// </summary>
        public Questionnaire()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the ValueChanged event of the sldPerformance control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedPropertyChangedEventArgs{System.Double}"/> instance containing the event data.</param>
        private void sldPerformance_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
        }

        /// <summary>
        /// Handles the Checked event of the radRAMSelectManual control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void radRAMSelectManual_Checked(object sender, RoutedEventArgs e)
        {
            sldRamSize.Visibility = Visibility.Visible;
            lblManualRamSelect.Visibility = Visibility.Visible;
            lblManualRamSelectLabel.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Handles the Unchecked event of the radRAMSelectManual control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void radRAMSelectManual_Unchecked(object sender, RoutedEventArgs e)
        {
            sldRamSize.Visibility = Visibility.Hidden;
            lblManualRamSelect.Visibility = Visibility.Hidden;
            lblManualRamSelectLabel.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Handles the Click event of the btnReset control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            var result = System.Windows.Forms.MessageBox.Show("Are you sure you want to reset all data? This cannot be reversed!", "Confirm Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                ResetForm();
            }
        }

        /// <summary>
        /// Handles the Click event of the btnCancel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            // Closes the GUI window
            var result = System.Windows.Forms.MessageBox.Show("Are you sure you want to quit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                ResetForm(); 
                this.Close();
            }
        }

        /// <summary>
        /// Resets the form.
        /// </summary>
        private void ResetForm()
        {
            sldPerformance.Value = 200;
            chkUseBasic.IsChecked = false;
            chkUseDevelopment.IsChecked = false;
            chkUseGaming.IsChecked = false;
            chkUseOfficeModerate.IsChecked = false;
            chkUseVideoEdit.IsChecked = false;
            sldStorageSize.Value = 64;
            radHDD.IsChecked = true;
            radRAMRecommended.IsChecked = true;
            sldNumCores.Value = 2;
            radCaseSizeFull.IsChecked = true;
        }

        /// <summary>
        /// Handles the Click event of the btnAccept control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void btnAccept_Click(object sender, RoutedEventArgs e)
        {
            if (chkUseBasic.IsChecked != true && chkUseDevelopment.IsChecked != true && chkUseGaming.IsChecked != true && chkUseOfficeModerate.IsChecked != true && chkUseVideoEdit.IsChecked != true)
            {
                System.Windows.Forms.MessageBox.Show("Please select one or more uses for your system to continue.", "No Use Selected", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                QuestionnaireResults qr = new QuestionnaireResults();
                BuildProcessor bp = new BuildProcessor();

                qr.SldPerformance = this.sldPerformance.Value;
                qr.ChkUseBasic = this.chkUseBasic.IsChecked ?? false;
                qr.ChkUseVideoEdit = this.chkUseVideoEdit.IsChecked ?? false;
                qr.ChkUseGaming = this.chkUseGaming.IsChecked ?? false;
                qr.ChkUseDevelopment = this.chkUseDevelopment.IsChecked ?? false;
                qr.ChkUseOfficeModerate = this.chkUseOfficeModerate.IsChecked ?? false;
                qr.SldStorageSize = this.sldStorageSize.Value;
                qr.RadSSD = this.radSSD.IsChecked ?? false;
                qr.RadHDD = this.radHDD.IsChecked ?? false;
                qr.RadRAMRecommended = this.radRAMRecommended.IsChecked ?? false;
                qr.RadRAMSelectManual = this.radRAMSelectManual.IsChecked ?? false;
                qr.SldRamSize = this.sldRamSize.Value;
                qr.SldNumCores = this.sldNumCores.Value;
                qr.RadCaseSizeFull = this.radCaseSizeFull.IsChecked ?? false;
                qr.RadCaseSizeMid = this.radCaseSizeMid.IsChecked ?? false;
                qr.RadCaseSizeMicro = this.radCaseSizeMicro.IsChecked ?? false;
                qr.RadCaseSizeMini = this.radCaseSizeMini.IsChecked ?? false;
                qr.RadCaseSizeConsole = this.radCaseSizeConsole.IsChecked ?? false;
                qr.RadOpticalNone = this.radOpticalNone.IsChecked ?? false;
                qr.RadBRBurner = this.radBRBurner.IsChecked ?? false;
                qr.RadBRReader = this.radBRReader.IsChecked ?? false;
                qr.RadDVDBurner = this.radDVDBurner.IsChecked ?? false;

                FinalizedBuild fb = bp.DataBuilder(qr);

                this.FB = fb;
                this.QR = qr;
                this.DialogResult = true;
                this.Close();
            }
        }
    }
}
