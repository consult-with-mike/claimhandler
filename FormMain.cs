using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaimHandler
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void textBoxTotalRepairHours_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(textBoxTotalRepairHours.Text, out var totalRepairHours))
            {
                return;
            }

            textBoxRepairDays.Text = $"{Math.Round(totalRepairHours / 4, 0):N0}";
        }

        private void comboBoxSpokeWithShop_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxSpokeWithShop.ReadOnly = comboBoxSpokeWithShop.SelectedIndex > 1;
            if (textBoxSpokeWithShop.ReadOnly)
            {
                textBoxSpokeWithShop.Text = string.Empty;
            }
        }

        private void comboBoxChangesMade_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxChangesMade.ReadOnly = comboBoxChangesMade.SelectedIndex != 0;
            if (textBoxChangesMade.ReadOnly)
            {
                textBoxChangesMade.Text = string.Empty;
            }
        }

        private void comboBoxAgreedPriceReached_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxAgreedPriceReached.ReadOnly = comboBoxAgreedPriceReached.SelectedIndex != 0;
            if (textBoxAgreedPriceReached.ReadOnly)
            {
                textBoxAgreedPriceReached.Text = string.Empty;
            }
        }

        private void comboBoxAnyDenial_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxAnyDenialPartialFull.Enabled = comboBoxAnyDenial.SelectedIndex == 0;
            textBoxAnyDenial.ReadOnly = comboBoxAnyDenial.SelectedIndex != 0;
            if (textBoxAnyDenial.ReadOnly)
            {
                comboBoxAnyDenialPartialFull.SelectedIndex = -1;
                textBoxAnyDenial.Text = string.Empty;
            }
        }

        private void HandleNumericKeysOnly(object sender, KeyPressEventArgs e)
        {
            // only allow tab, digits, decimal point, and negative sign
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void CalculateNetTotalAmount(object sender, EventArgs e)
        {
            decimal.TryParse(textBoxGrossRepairAmount.Text, out var grossRepairAmount);
            decimal.TryParse(textBoxDeductible.Text, out var deductible);
            decimal.TryParse(textBoxAnyOtherAmounts.Text, out var anyOtherAmounts);

            textBoxNetTotalAmount.Text = $"{grossRepairAmount - deductible + anyOtherAmounts:C2}";
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            var output = $@"Insured or claimant: {comboBoxInsuredOrClaimant.Text}
Summary of repairs: {textBoxSummaryOfRepairs.Text}
Total Loss? {comboBoxTotalLoss.Text}
Total repair hours: {textBoxTotalRepairHours.Text}
Repair days: {textBoxRepairDays.Text}
Drivable: {comboBoxDrivable.Text}
Currently in rental? {comboBoxCurrentlyInRental.Text}
Spoke with shop? {comboBoxSpokeWithShop.Text}{textBoxSpokeWithShop.Text.PrintIfNotEmpty()}
Changes made: {comboBoxChangesMade.Text}{textBoxChangesMade.Text.PrintIfNotEmpty()}
Agreed price reached? {comboBoxAgreedPriceReached.Text}{textBoxAgreedPriceReached.Text.PrintIfNotEmpty()}
Any denial? {comboBoxAnyDenial.Text}{comboBoxAnyDenialPartialFull.Text.PrintIfNotEmpty()}{textBoxAnyDenial.Text.PrintIfNotEmpty()}
Gross repair amount: {textBoxGrossRepairAmount.Text.PrintAsCurrency()}
Deductible: {textBoxDeductible.Text.PrintAsCurrency()}
Any other amounts: {textBoxAnyOtherAmounts.Text.PrintAsCurrency()}
Net total amount: {textBoxNetTotalAmount.Text}

**CUSTOMER NEEDS TO PROVIDE INSURANCE APPROVED ESTIMATE TO SHOP OF CHOICE**

THE ESTIMATE IS WRITTEN FROM WHAT CAN BE SEEN FROM THE PHOTOS PROVIDED - ANY ADDITIONAL
DAMAGE CAN BE COMPLETED AS A SUPPLEMENT IF NECESSARY WHEN VEHICLE IS AT THE REPAIR
FACILITY AND AFTER TEAR DOWN WITH ADDITIONAL DOCUMENTATION AND PHOTOS.
";

            Clipboard.SetData(DataFormats.Text, output);

            MessageBox.Show("Copied to clipboard.", "Copy Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            comboBoxInsuredOrClaimant.SelectedIndex = -1;
            textBoxSummaryOfRepairs.Text = null;
            comboBoxTotalLoss.SelectedIndex = -1;
            textBoxTotalRepairHours.Text = null;
            textBoxRepairDays.Text = null;
            comboBoxDrivable.SelectedIndex = -1;
            comboBoxCurrentlyInRental.SelectedIndex = -1;
            comboBoxSpokeWithShop.SelectedIndex = -1;
            textBoxSpokeWithShop.Text = null;
            comboBoxChangesMade.SelectedIndex = -1;
            textBoxChangesMade.Text = null;
            comboBoxAgreedPriceReached.SelectedIndex = -1;
            textBoxAgreedPriceReached.Text = null;
            comboBoxAnyDenial.SelectedIndex = -1;
            comboBoxAnyDenialPartialFull.SelectedIndex = -1;
            textBoxAnyDenial.Text = null;
            textBoxGrossRepairAmount.Text = null;
            textBoxDeductible.Text = null;
            textBoxAnyOtherAmounts.Text = null;
            textBoxNetTotalAmount.Text = null;

            comboBoxInsuredOrClaimant.Focus();
        }
    }
}
