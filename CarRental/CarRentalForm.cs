namespace CarRental
{
    public partial class CarRentalForm : Form
    {
        public CarRentalForm()
        {
            InitializeComponent();
            SetDefaults();
        }

        int customerNumberTotal = 0;
        decimal milesDrivenTotal = 0;
        decimal totalCharges = 0;
        decimal customerMiles = 0;
        decimal amountDue = 0;

        void SetDefaults()
        {
            CustomerNameTextBox.Text = "";
            CustomerNameTextBox.BackColor = Color.LightYellow;
            AddressTextBox.Text = "";
            AddressTextBox.BackColor = Color.LightYellow;
            CityTextBox.Text = "";
            CityTextBox.BackColor = Color.LightYellow;
            StateTextBox.Text = "";
            StateTextBox .BackColor = Color.LightYellow;
            BeginingOdometerTextBox.Text = "";
            BeginingOdometerTextBox .BackColor = Color.LightYellow;
            EndingOdometerTextBox.Text = "";
            EndingOdometerTextBox.BackColor = Color.LightYellow;
            NumberOfDaysTextBox.Text = "";
            NumberOfDaysTextBox .BackColor = Color.LightYellow;
            MilesRadioButton.Checked = true;
            DistanceDrivenTextBox.Text = "";
            MileageChargeTextBox.Text = "";
            DayChargeTextBox.Text = "";
            MinusDiscountTextBox.Text = "";
            YouOweTextBox.Text = "";
            AAACheckBox.Checked = false;
            SeniorCheckBox.Checked = false;
        }

        private bool ValidateFields()
        {
            bool valid = true;

            if (CustomerNameTextBox.Text != "")
            {
                CustomerNameTextBox.BackColor = Color.White;
            }
            else
            {
                CustomerNameTextBox.BackColor = Color.LightYellow;
                valid = false;
            }

            if (AddressTextBox.Text != "")
            {
                AddressTextBox.BackColor = Color.White;
            }
            else
            {
                AddressTextBox.BackColor = Color.LightYellow;
                valid = false;
            }

            if (CityTextBox.Text != "")
            {
                CityTextBox.BackColor = Color.White;
            }
            else
            {
                CityTextBox.BackColor = Color.LightYellow;
                valid = false;
            }

            if (StateTextBox.Text != "")
            {
                StateTextBox.BackColor = Color.White;
            }
            else
            {
                StateTextBox.BackColor = Color.LightYellow;
                valid = false;
            }

            if (ZipCodeTextBox.Text != "")
            {
                ZipCodeTextBox.BackColor = Color.White;
            }
            else
            {
                ZipCodeTextBox.BackColor = Color.LightYellow;
                valid = false;
            }

            try
            {
                if (int.Parse(BeginingOdometerTextBox.Text) >= 0 && 
                   (int.Parse(BeginingOdometerTextBox.Text)) < 
                   (int.Parse(EndingOdometerTextBox.Text)))
                {
                    BeginingOdometerTextBox.BackColor = Color.White;
                }
                else
                {
                    BeginingOdometerTextBox.BackColor = Color.LightYellow;
                    valid = false;
                }
            }
            catch (Exception)
            {
                BeginingOdometerTextBox.BackColor = Color.LightYellow;
                valid = false;
            }

            try
            {
                if (int.Parse(EndingOdometerTextBox.Text) >= 0)
                {
                    EndingOdometerTextBox.BackColor = Color.White;
                }
                else
                {
                    EndingOdometerTextBox.BackColor = Color.LightYellow;
                    valid = false;
                }
            }
            catch (Exception)
            {
                EndingOdometerTextBox.BackColor = Color.LightYellow;
                valid = false;
            }

            try
            {
                if (int.Parse(NumberOfDaysTextBox.Text) >= 1 && int.Parse(NumberOfDaysTextBox.Text) <= 45)
                {
                    NumberOfDaysTextBox.BackColor = Color.White;
                }
                else
                {
                    NumberOfDaysTextBox.BackColor = Color.LightYellow;
                    valid = false;
                }
            }
            catch (Exception)
            {
                NumberOfDaysTextBox.BackColor = Color.LightYellow;
                valid = false;
            }
            return valid;
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
