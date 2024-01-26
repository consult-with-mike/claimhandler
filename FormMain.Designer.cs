namespace ClaimHandler
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.labelInsuredOrClaimant = new System.Windows.Forms.Label();
            this.comboBoxInsuredOrClaimant = new System.Windows.Forms.ComboBox();
            this.labelSummaryOfRepairs = new System.Windows.Forms.Label();
            this.textBoxSummaryOfRepairs = new System.Windows.Forms.TextBox();
            this.comboBoxTotalLoss = new System.Windows.Forms.ComboBox();
            this.labelTotalLoss = new System.Windows.Forms.Label();
            this.labelTotalRepairHours = new System.Windows.Forms.Label();
            this.textBoxRepairDays = new System.Windows.Forms.TextBox();
            this.labelRepairDays = new System.Windows.Forms.Label();
            this.comboBoxDrivable = new System.Windows.Forms.ComboBox();
            this.labelDrivable = new System.Windows.Forms.Label();
            this.comboBoxCurrentlyInRental = new System.Windows.Forms.ComboBox();
            this.labelCurrentlyInRental = new System.Windows.Forms.Label();
            this.textBoxSpokeWithShop = new System.Windows.Forms.TextBox();
            this.labelSpokeWithShop = new System.Windows.Forms.Label();
            this.comboBoxChangesMade = new System.Windows.Forms.ComboBox();
            this.labelChangesMade = new System.Windows.Forms.Label();
            this.textBoxChangesMade = new System.Windows.Forms.TextBox();
            this.textBoxAgreedPriceReached = new System.Windows.Forms.TextBox();
            this.comboBoxAgreedPriceReached = new System.Windows.Forms.ComboBox();
            this.labelAgreedPriceReached = new System.Windows.Forms.Label();
            this.textBoxAnyDenial = new System.Windows.Forms.TextBox();
            this.comboBoxAnyDenial = new System.Windows.Forms.ComboBox();
            this.labelAnyDenial = new System.Windows.Forms.Label();
            this.comboBoxAnyDenialPartialFull = new System.Windows.Forms.ComboBox();
            this.textBoxTotalRepairHours = new System.Windows.Forms.TextBox();
            this.textBoxGrossRepairAmount = new System.Windows.Forms.TextBox();
            this.labelGrossRepairAmount = new System.Windows.Forms.Label();
            this.textBoxDeductible = new System.Windows.Forms.TextBox();
            this.labelDeductible = new System.Windows.Forms.Label();
            this.textBoxAnyOtherAmounts = new System.Windows.Forms.TextBox();
            this.labelAnyOtherAmounts = new System.Windows.Forms.Label();
            this.textBoxNetTotalAmount = new System.Windows.Forms.TextBox();
            this.labelNetTotalAmount = new System.Windows.Forms.Label();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInsuredOrClaimant
            // 
            this.labelInsuredOrClaimant.AutoSize = true;
            this.labelInsuredOrClaimant.Location = new System.Drawing.Point(15, 21);
            this.labelInsuredOrClaimant.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelInsuredOrClaimant.Name = "labelInsuredOrClaimant";
            this.labelInsuredOrClaimant.Size = new System.Drawing.Size(144, 20);
            this.labelInsuredOrClaimant.TabIndex = 0;
            this.labelInsuredOrClaimant.Text = "Insured or claimant";
            // 
            // comboBoxInsuredOrClaimant
            // 
            this.comboBoxInsuredOrClaimant.FormattingEnabled = true;
            this.comboBoxInsuredOrClaimant.Items.AddRange(new object[] {
            "Insured",
            "Claimant"});
            this.comboBoxInsuredOrClaimant.Location = new System.Drawing.Point(206, 18);
            this.comboBoxInsuredOrClaimant.Name = "comboBoxInsuredOrClaimant";
            this.comboBoxInsuredOrClaimant.Size = new System.Drawing.Size(121, 28);
            this.comboBoxInsuredOrClaimant.TabIndex = 1;
            // 
            // labelSummaryOfRepairs
            // 
            this.labelSummaryOfRepairs.AutoSize = true;
            this.labelSummaryOfRepairs.Location = new System.Drawing.Point(15, 55);
            this.labelSummaryOfRepairs.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSummaryOfRepairs.Name = "labelSummaryOfRepairs";
            this.labelSummaryOfRepairs.Size = new System.Drawing.Size(146, 20);
            this.labelSummaryOfRepairs.TabIndex = 2;
            this.labelSummaryOfRepairs.Text = "Summary of repairs";
            // 
            // textBoxSummaryOfRepairs
            // 
            this.textBoxSummaryOfRepairs.Location = new System.Drawing.Point(206, 52);
            this.textBoxSummaryOfRepairs.Name = "textBoxSummaryOfRepairs";
            this.textBoxSummaryOfRepairs.Size = new System.Drawing.Size(567, 26);
            this.textBoxSummaryOfRepairs.TabIndex = 3;
            // 
            // comboBoxTotalLoss
            // 
            this.comboBoxTotalLoss.FormattingEnabled = true;
            this.comboBoxTotalLoss.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBoxTotalLoss.Location = new System.Drawing.Point(206, 84);
            this.comboBoxTotalLoss.Name = "comboBoxTotalLoss";
            this.comboBoxTotalLoss.Size = new System.Drawing.Size(121, 28);
            this.comboBoxTotalLoss.TabIndex = 5;
            // 
            // labelTotalLoss
            // 
            this.labelTotalLoss.AutoSize = true;
            this.labelTotalLoss.Location = new System.Drawing.Point(15, 87);
            this.labelTotalLoss.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTotalLoss.Name = "labelTotalLoss";
            this.labelTotalLoss.Size = new System.Drawing.Size(85, 20);
            this.labelTotalLoss.TabIndex = 4;
            this.labelTotalLoss.Text = "Total loss?";
            // 
            // labelTotalRepairHours
            // 
            this.labelTotalRepairHours.AutoSize = true;
            this.labelTotalRepairHours.Location = new System.Drawing.Point(15, 120);
            this.labelTotalRepairHours.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTotalRepairHours.Name = "labelTotalRepairHours";
            this.labelTotalRepairHours.Size = new System.Drawing.Size(132, 20);
            this.labelTotalRepairHours.TabIndex = 6;
            this.labelTotalRepairHours.Text = "Total repair hours";
            // 
            // textBoxRepairDays
            // 
            this.textBoxRepairDays.Location = new System.Drawing.Point(206, 150);
            this.textBoxRepairDays.Name = "textBoxRepairDays";
            this.textBoxRepairDays.ReadOnly = true;
            this.textBoxRepairDays.Size = new System.Drawing.Size(100, 26);
            this.textBoxRepairDays.TabIndex = 9;
            // 
            // labelRepairDays
            // 
            this.labelRepairDays.AutoSize = true;
            this.labelRepairDays.Location = new System.Drawing.Point(15, 153);
            this.labelRepairDays.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelRepairDays.Name = "labelRepairDays";
            this.labelRepairDays.Size = new System.Drawing.Size(93, 20);
            this.labelRepairDays.TabIndex = 8;
            this.labelRepairDays.Text = "Repair days";
            // 
            // comboBoxDrivable
            // 
            this.comboBoxDrivable.FormattingEnabled = true;
            this.comboBoxDrivable.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBoxDrivable.Location = new System.Drawing.Point(206, 182);
            this.comboBoxDrivable.Name = "comboBoxDrivable";
            this.comboBoxDrivable.Size = new System.Drawing.Size(121, 28);
            this.comboBoxDrivable.TabIndex = 11;
            // 
            // labelDrivable
            // 
            this.labelDrivable.AutoSize = true;
            this.labelDrivable.Location = new System.Drawing.Point(15, 185);
            this.labelDrivable.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelDrivable.Name = "labelDrivable";
            this.labelDrivable.Size = new System.Drawing.Size(75, 20);
            this.labelDrivable.TabIndex = 10;
            this.labelDrivable.Text = "Drivable?";
            // 
            // comboBoxCurrentlyInRental
            // 
            this.comboBoxCurrentlyInRental.FormattingEnabled = true;
            this.comboBoxCurrentlyInRental.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBoxCurrentlyInRental.Location = new System.Drawing.Point(206, 216);
            this.comboBoxCurrentlyInRental.Name = "comboBoxCurrentlyInRental";
            this.comboBoxCurrentlyInRental.Size = new System.Drawing.Size(121, 28);
            this.comboBoxCurrentlyInRental.TabIndex = 13;
            // 
            // labelCurrentlyInRental
            // 
            this.labelCurrentlyInRental.AutoSize = true;
            this.labelCurrentlyInRental.Location = new System.Drawing.Point(15, 219);
            this.labelCurrentlyInRental.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCurrentlyInRental.Name = "labelCurrentlyInRental";
            this.labelCurrentlyInRental.Size = new System.Drawing.Size(141, 20);
            this.labelCurrentlyInRental.TabIndex = 12;
            this.labelCurrentlyInRental.Text = "Currently in rental?";
            // 
            // textBoxSpokeWithShop
            // 
            this.textBoxSpokeWithShop.Location = new System.Drawing.Point(206, 250);
            this.textBoxSpokeWithShop.Name = "textBoxSpokeWithShop";
            this.textBoxSpokeWithShop.Size = new System.Drawing.Size(567, 26);
            this.textBoxSpokeWithShop.TabIndex = 15;
            // 
            // labelSpokeWithShop
            // 
            this.labelSpokeWithShop.AutoSize = true;
            this.labelSpokeWithShop.Location = new System.Drawing.Point(15, 253);
            this.labelSpokeWithShop.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSpokeWithShop.Name = "labelSpokeWithShop";
            this.labelSpokeWithShop.Size = new System.Drawing.Size(135, 20);
            this.labelSpokeWithShop.TabIndex = 14;
            this.labelSpokeWithShop.Text = "Spoke with shop?";
            // 
            // comboBoxChangesMade
            // 
            this.comboBoxChangesMade.FormattingEnabled = true;
            this.comboBoxChangesMade.Items.AddRange(new object[] {
            "Yes",
            "No",
            "N/A"});
            this.comboBoxChangesMade.Location = new System.Drawing.Point(206, 282);
            this.comboBoxChangesMade.Name = "comboBoxChangesMade";
            this.comboBoxChangesMade.Size = new System.Drawing.Size(121, 28);
            this.comboBoxChangesMade.TabIndex = 17;
            this.comboBoxChangesMade.SelectedIndexChanged += new System.EventHandler(this.comboBoxChangesMade_SelectedIndexChanged);
            // 
            // labelChangesMade
            // 
            this.labelChangesMade.AutoSize = true;
            this.labelChangesMade.Location = new System.Drawing.Point(15, 285);
            this.labelChangesMade.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelChangesMade.Name = "labelChangesMade";
            this.labelChangesMade.Size = new System.Drawing.Size(126, 20);
            this.labelChangesMade.TabIndex = 16;
            this.labelChangesMade.Text = "Changes made?";
            // 
            // textBoxChangesMade
            // 
            this.textBoxChangesMade.Location = new System.Drawing.Point(206, 316);
            this.textBoxChangesMade.Name = "textBoxChangesMade";
            this.textBoxChangesMade.ReadOnly = true;
            this.textBoxChangesMade.Size = new System.Drawing.Size(567, 26);
            this.textBoxChangesMade.TabIndex = 18;
            // 
            // textBoxAgreedPriceReached
            // 
            this.textBoxAgreedPriceReached.Location = new System.Drawing.Point(206, 382);
            this.textBoxAgreedPriceReached.Name = "textBoxAgreedPriceReached";
            this.textBoxAgreedPriceReached.ReadOnly = true;
            this.textBoxAgreedPriceReached.Size = new System.Drawing.Size(567, 26);
            this.textBoxAgreedPriceReached.TabIndex = 21;
            // 
            // comboBoxAgreedPriceReached
            // 
            this.comboBoxAgreedPriceReached.FormattingEnabled = true;
            this.comboBoxAgreedPriceReached.Items.AddRange(new object[] {
            "Yes",
            "No",
            "N/A"});
            this.comboBoxAgreedPriceReached.Location = new System.Drawing.Point(206, 348);
            this.comboBoxAgreedPriceReached.Name = "comboBoxAgreedPriceReached";
            this.comboBoxAgreedPriceReached.Size = new System.Drawing.Size(121, 28);
            this.comboBoxAgreedPriceReached.TabIndex = 20;
            this.comboBoxAgreedPriceReached.SelectedIndexChanged += new System.EventHandler(this.comboBoxAgreedPriceReached_SelectedIndexChanged);
            // 
            // labelAgreedPriceReached
            // 
            this.labelAgreedPriceReached.AutoSize = true;
            this.labelAgreedPriceReached.Location = new System.Drawing.Point(15, 351);
            this.labelAgreedPriceReached.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAgreedPriceReached.Name = "labelAgreedPriceReached";
            this.labelAgreedPriceReached.Size = new System.Drawing.Size(170, 20);
            this.labelAgreedPriceReached.TabIndex = 19;
            this.labelAgreedPriceReached.Text = "Agreed price reached?";
            // 
            // textBoxAnyDenial
            // 
            this.textBoxAnyDenial.Location = new System.Drawing.Point(206, 448);
            this.textBoxAnyDenial.Name = "textBoxAnyDenial";
            this.textBoxAnyDenial.ReadOnly = true;
            this.textBoxAnyDenial.Size = new System.Drawing.Size(567, 26);
            this.textBoxAnyDenial.TabIndex = 25;
            // 
            // comboBoxAnyDenial
            // 
            this.comboBoxAnyDenial.FormattingEnabled = true;
            this.comboBoxAnyDenial.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBoxAnyDenial.Location = new System.Drawing.Point(206, 414);
            this.comboBoxAnyDenial.Name = "comboBoxAnyDenial";
            this.comboBoxAnyDenial.Size = new System.Drawing.Size(121, 28);
            this.comboBoxAnyDenial.TabIndex = 23;
            this.comboBoxAnyDenial.SelectedIndexChanged += new System.EventHandler(this.comboBoxAnyDenial_SelectedIndexChanged);
            // 
            // labelAnyDenial
            // 
            this.labelAnyDenial.AutoSize = true;
            this.labelAnyDenial.Location = new System.Drawing.Point(15, 417);
            this.labelAnyDenial.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAnyDenial.Name = "labelAnyDenial";
            this.labelAnyDenial.Size = new System.Drawing.Size(91, 20);
            this.labelAnyDenial.TabIndex = 22;
            this.labelAnyDenial.Text = "Any denial?";
            // 
            // comboBoxAnyDenialPartialFull
            // 
            this.comboBoxAnyDenialPartialFull.Enabled = false;
            this.comboBoxAnyDenialPartialFull.FormattingEnabled = true;
            this.comboBoxAnyDenialPartialFull.Items.AddRange(new object[] {
            "Partial",
            "Full"});
            this.comboBoxAnyDenialPartialFull.Location = new System.Drawing.Point(333, 414);
            this.comboBoxAnyDenialPartialFull.Name = "comboBoxAnyDenialPartialFull";
            this.comboBoxAnyDenialPartialFull.Size = new System.Drawing.Size(121, 28);
            this.comboBoxAnyDenialPartialFull.TabIndex = 24;
            // 
            // textBoxTotalRepairHours
            // 
            this.textBoxTotalRepairHours.Location = new System.Drawing.Point(206, 118);
            this.textBoxTotalRepairHours.Name = "textBoxTotalRepairHours";
            this.textBoxTotalRepairHours.Size = new System.Drawing.Size(100, 26);
            this.textBoxTotalRepairHours.TabIndex = 7;
            this.textBoxTotalRepairHours.TextChanged += new System.EventHandler(this.textBoxTotalRepairHours_TextChanged);
            this.textBoxTotalRepairHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HandleNumericKeysOnly);
            // 
            // textBoxGrossRepairAmount
            // 
            this.textBoxGrossRepairAmount.Location = new System.Drawing.Point(206, 480);
            this.textBoxGrossRepairAmount.Name = "textBoxGrossRepairAmount";
            this.textBoxGrossRepairAmount.Size = new System.Drawing.Size(100, 26);
            this.textBoxGrossRepairAmount.TabIndex = 27;
            this.textBoxGrossRepairAmount.TextChanged += new System.EventHandler(this.CalculateNetTotalAmount);
            this.textBoxGrossRepairAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HandleNumericKeysOnly);
            // 
            // labelGrossRepairAmount
            // 
            this.labelGrossRepairAmount.AutoSize = true;
            this.labelGrossRepairAmount.Location = new System.Drawing.Point(15, 482);
            this.labelGrossRepairAmount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelGrossRepairAmount.Name = "labelGrossRepairAmount";
            this.labelGrossRepairAmount.Size = new System.Drawing.Size(154, 20);
            this.labelGrossRepairAmount.TabIndex = 26;
            this.labelGrossRepairAmount.Text = "Gross repair amount";
            // 
            // textBoxDeductible
            // 
            this.textBoxDeductible.Location = new System.Drawing.Point(206, 512);
            this.textBoxDeductible.Name = "textBoxDeductible";
            this.textBoxDeductible.Size = new System.Drawing.Size(100, 26);
            this.textBoxDeductible.TabIndex = 29;
            this.textBoxDeductible.TextChanged += new System.EventHandler(this.CalculateNetTotalAmount);
            this.textBoxDeductible.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HandleNumericKeysOnly);
            // 
            // labelDeductible
            // 
            this.labelDeductible.AutoSize = true;
            this.labelDeductible.Location = new System.Drawing.Point(15, 514);
            this.labelDeductible.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelDeductible.Name = "labelDeductible";
            this.labelDeductible.Size = new System.Drawing.Size(85, 20);
            this.labelDeductible.TabIndex = 28;
            this.labelDeductible.Text = "Deductible";
            // 
            // textBoxAnyOtherAmounts
            // 
            this.textBoxAnyOtherAmounts.Location = new System.Drawing.Point(206, 544);
            this.textBoxAnyOtherAmounts.Name = "textBoxAnyOtherAmounts";
            this.textBoxAnyOtherAmounts.Size = new System.Drawing.Size(100, 26);
            this.textBoxAnyOtherAmounts.TabIndex = 31;
            this.textBoxAnyOtherAmounts.TextChanged += new System.EventHandler(this.CalculateNetTotalAmount);
            this.textBoxAnyOtherAmounts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HandleNumericKeysOnly);
            // 
            // labelAnyOtherAmounts
            // 
            this.labelAnyOtherAmounts.AutoSize = true;
            this.labelAnyOtherAmounts.Location = new System.Drawing.Point(15, 546);
            this.labelAnyOtherAmounts.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelAnyOtherAmounts.Name = "labelAnyOtherAmounts";
            this.labelAnyOtherAmounts.Size = new System.Drawing.Size(143, 20);
            this.labelAnyOtherAmounts.TabIndex = 30;
            this.labelAnyOtherAmounts.Text = "Any other amounts";
            // 
            // textBoxNetTotalAmount
            // 
            this.textBoxNetTotalAmount.Location = new System.Drawing.Point(206, 576);
            this.textBoxNetTotalAmount.Name = "textBoxNetTotalAmount";
            this.textBoxNetTotalAmount.ReadOnly = true;
            this.textBoxNetTotalAmount.Size = new System.Drawing.Size(100, 26);
            this.textBoxNetTotalAmount.TabIndex = 33;
            // 
            // labelNetTotalAmount
            // 
            this.labelNetTotalAmount.AutoSize = true;
            this.labelNetTotalAmount.Location = new System.Drawing.Point(15, 578);
            this.labelNetTotalAmount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelNetTotalAmount.Name = "labelNetTotalAmount";
            this.labelNetTotalAmount.Size = new System.Drawing.Size(127, 20);
            this.labelNetTotalAmount.TabIndex = 32;
            this.labelNetTotalAmount.Text = "Net total amount";
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(206, 608);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(100, 30);
            this.buttonCopy.TabIndex = 34;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(312, 608);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(100, 30);
            this.buttonClear.TabIndex = 35;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.textBoxNetTotalAmount);
            this.Controls.Add(this.labelNetTotalAmount);
            this.Controls.Add(this.textBoxAnyOtherAmounts);
            this.Controls.Add(this.labelAnyOtherAmounts);
            this.Controls.Add(this.textBoxDeductible);
            this.Controls.Add(this.labelDeductible);
            this.Controls.Add(this.textBoxGrossRepairAmount);
            this.Controls.Add(this.labelGrossRepairAmount);
            this.Controls.Add(this.textBoxTotalRepairHours);
            this.Controls.Add(this.comboBoxAnyDenialPartialFull);
            this.Controls.Add(this.textBoxAnyDenial);
            this.Controls.Add(this.comboBoxAnyDenial);
            this.Controls.Add(this.labelAnyDenial);
            this.Controls.Add(this.textBoxAgreedPriceReached);
            this.Controls.Add(this.comboBoxAgreedPriceReached);
            this.Controls.Add(this.labelAgreedPriceReached);
            this.Controls.Add(this.textBoxChangesMade);
            this.Controls.Add(this.comboBoxChangesMade);
            this.Controls.Add(this.labelChangesMade);
            this.Controls.Add(this.textBoxSpokeWithShop);
            this.Controls.Add(this.labelSpokeWithShop);
            this.Controls.Add(this.comboBoxCurrentlyInRental);
            this.Controls.Add(this.labelCurrentlyInRental);
            this.Controls.Add(this.comboBoxDrivable);
            this.Controls.Add(this.labelDrivable);
            this.Controls.Add(this.textBoxRepairDays);
            this.Controls.Add(this.labelRepairDays);
            this.Controls.Add(this.labelTotalRepairHours);
            this.Controls.Add(this.comboBoxTotalLoss);
            this.Controls.Add(this.labelTotalLoss);
            this.Controls.Add(this.textBoxSummaryOfRepairs);
            this.Controls.Add(this.labelSummaryOfRepairs);
            this.Controls.Add(this.comboBoxInsuredOrClaimant);
            this.Controls.Add(this.labelInsuredOrClaimant);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormMain";
            this.Text = "AmFam Claim Handler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInsuredOrClaimant;
        private System.Windows.Forms.ComboBox comboBoxInsuredOrClaimant;
        private System.Windows.Forms.Label labelSummaryOfRepairs;
        private System.Windows.Forms.TextBox textBoxSummaryOfRepairs;
        private System.Windows.Forms.ComboBox comboBoxTotalLoss;
        private System.Windows.Forms.Label labelTotalLoss;
        private System.Windows.Forms.Label labelTotalRepairHours;
        private System.Windows.Forms.TextBox textBoxRepairDays;
        private System.Windows.Forms.Label labelRepairDays;
        private System.Windows.Forms.ComboBox comboBoxDrivable;
        private System.Windows.Forms.Label labelDrivable;
        private System.Windows.Forms.ComboBox comboBoxCurrentlyInRental;
        private System.Windows.Forms.Label labelCurrentlyInRental;
        private System.Windows.Forms.TextBox textBoxSpokeWithShop;
        private System.Windows.Forms.Label labelSpokeWithShop;
        private System.Windows.Forms.ComboBox comboBoxChangesMade;
        private System.Windows.Forms.Label labelChangesMade;
        private System.Windows.Forms.TextBox textBoxChangesMade;
        private System.Windows.Forms.TextBox textBoxAgreedPriceReached;
        private System.Windows.Forms.ComboBox comboBoxAgreedPriceReached;
        private System.Windows.Forms.Label labelAgreedPriceReached;
        private System.Windows.Forms.TextBox textBoxAnyDenial;
        private System.Windows.Forms.ComboBox comboBoxAnyDenial;
        private System.Windows.Forms.Label labelAnyDenial;
        private System.Windows.Forms.ComboBox comboBoxAnyDenialPartialFull;
        private System.Windows.Forms.TextBox textBoxTotalRepairHours;
        private System.Windows.Forms.TextBox textBoxGrossRepairAmount;
        private System.Windows.Forms.Label labelGrossRepairAmount;
        private System.Windows.Forms.TextBox textBoxDeductible;
        private System.Windows.Forms.Label labelDeductible;
        private System.Windows.Forms.TextBox textBoxAnyOtherAmounts;
        private System.Windows.Forms.Label labelAnyOtherAmounts;
        private System.Windows.Forms.TextBox textBoxNetTotalAmount;
        private System.Windows.Forms.Label labelNetTotalAmount;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonClear;
    }
}

