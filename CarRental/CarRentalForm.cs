namespace CarRental
{
    public partial class CarRentalForm : Form
    {
        public CarRentalForm()
        {
            InitializeComponent();
            SetDefaults();
        }

        void SetDefaults()
        {
            CustomerNameTextBox.Text = "";
            AddressTextBox.Text = "";
            CityTextBox.Text = "";
            StateTextBox.Text = "";
            BeginingOdometerTextBox.Text = "";
            EndingOdometerTextBox.Text = "";
            NumberOfDaysTextBox.Text = "";
            MilesRadioButton.Checked = true;
            DistanceDrivenTextBox.Text = "";
            MileageChargeTextBox.Text = "";
            DayChargeTextBox.Text = "";
            MinusDiscountTextBox.Text = "";
            YouOweTextBox.Text = "";
            AAACheckBox.Checked = false;
            SeniorCheckBox.Checked = false;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //Closes the form
            this.Close();
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }
    }
}
