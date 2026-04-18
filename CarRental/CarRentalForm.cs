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
        decimal distanceDrivenTotal = 0;
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
            ZipCodeTextBox.Text = "";
            ZipCodeTextBox .BackColor = Color.LightYellow;
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
                    BeginingOdometerTextBox.Text = "";
                    valid = false;
                }
            }
            catch (Exception)
            {
                BeginingOdometerTextBox.BackColor = Color.LightYellow;
                BeginingOdometerTextBox.Text = "";
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
                    EndingOdometerLabel.Text = "";
                    valid = false;
                }
            }
            catch (Exception)
            {
                EndingOdometerTextBox.BackColor = Color.LightYellow;
                EndingOdometerTextBox.Text = "";
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
                    NumberOfDaysTextBox.Text = "";
                    valid = false;
                }
            }
            catch (Exception)
            {
                NumberOfDaysTextBox.BackColor = Color.LightYellow;
                NumberOfDaysTextBox.Text = "";
                valid = false;
            }
            return valid;
        }
        private bool InputMessagesCheck()
        {
            bool valid = true;
            string message = "";
            if (CustomerNameTextBox.Text == "")
            {
                message += "Please enter a valid name.\n";
            }
            if (AddressTextBox.Text == "")
            {
                message += "Please enter a valid address.\n";
            }
            if (CityTextBox.Text == "")
            {
                message += "Please enter a valid city.\n";
            }
            if (StateTextBox.Text == "")
            {
                message += "Please enter a valid state.\n";
            }
            if (ZipCodeTextBox.Text == "")
            {
                message += "Please enter a valid zip code.\n";
            }
            try
            {
                if (int.Parse(BeginingOdometerTextBox.Text) < 0 || int.Parse(BeginingOdometerTextBox.Text) > (int.Parse(EndingOdometerTextBox.Text)))
                {
                    message += "Please enter a valid begining number that is less than or equal to the ending number.\n";
                }
            }
            catch (Exception)
            {
                message += "Please enter a valid begining number that is less than or equal to the ending number.\n";
            }
            try
            {

                if (int.Parse(EndingOdometerTextBox.Text) < 0)
                {
                    message += "Please enter a valid ending number.\n";
                }

            }
            catch (Exception)
            {
                message += "Please enter a valid ending number.\n";
            }
            try
            {
                if (int.Parse(NumberOfDaysTextBox.Text) < 0 || int.Parse(NumberOfDaysTextBox.Text) > 45)
                {
                    message += "Please enter a valid number of days (0-45).\n";
                }
            }
            catch (Exception)
            {
                message += "Please enter a valid number of days (0-45).\n";
            }

            if (message != "")
            {
                valid = false;
                MessageBox.Show(message);
            }

            return true;
        }
   
        decimal CalculateAAADiscount(decimal thisAmount)
        {
            decimal discount = 0;
            if (AAACheckBox.Checked)
            {
                discount = thisAmount * 0.05m;
            }
            return discount;
        }

        decimal CalculateSeniorDiscount(decimal thisAmount)
        {
            decimal discount = 0;
            if (SeniorCheckBox.Checked)
            {
                discount = thisAmount * 0.03m;
            }
            return discount;
        }

        private decimal CalculateDistanceDriven(decimal distanceDriven)
        {
            if (KilometersRadioButton.Checked)
            {
                DistanceDrivenLabel.Text = "Distance Driven in Kilometers";
                distanceDriven = (decimal.Parse(EndingOdometerTextBox.Text) - decimal.Parse(BeginingOdometerTextBox.Text)) * 0.62m;
            }
            else if (MilesRadioButton.Checked)
            {
                DistanceDrivenLabel.Text = "Distance Driven in Miles";
                distanceDriven = decimal.Parse(EndingOdometerTextBox.Text) - decimal.Parse(BeginingOdometerTextBox.Text);
            }
            DistanceDrivenTextBox.Text = distanceDriven.ToString();
            customerMiles = distanceDriven;
            return distanceDriven;
        }

        private decimal CalculateDistanceCharge(decimal distanceCharge)
        {
            if (customerMiles <= 200)
            {
                distanceCharge = 0.00m;
                MileageChargeTextBox.Text = $"{distanceCharge:C}";
            }
            if (customerMiles >= 201 && customerMiles >= 500)
            {
                distanceCharge = customerMiles * 0.12m;
                MileageChargeTextBox.Text = $"{distanceCharge:C}";
            }
            if (customerMiles >= 501)
            {
                distanceCharge = customerMiles * 0.10m;
                MileageChargeTextBox.Text = $"{distanceCharge:C}";
            }
            return distanceCharge;
        }

      
        private decimal CalculateDayCharge(decimal dayCharge)
        {
            dayCharge = decimal.Parse(NumberOfDaysTextBox.Text) * 15.00m;
            DayChargeTextBox.Text = $"{dayCharge:C}";
            return dayCharge;
        }

        void TotalCalculation()
        {
            decimal originalAmount = 0;
            decimal distanceDriven = 0;
            decimal distanceCharge = 0;
            decimal dayCharge = 0;
            decimal totalDiscount = 0;

            CalculateDistanceDriven(distanceDriven);
            distanceCharge = CalculateDistanceCharge(originalAmount);
            dayCharge = CalculateDayCharge(originalAmount + distanceCharge);
            totalDiscount += CalculateAAADiscount(originalAmount + distanceCharge + dayCharge);
            totalDiscount += CalculateSeniorDiscount(originalAmount + distanceCharge + dayCharge);
            MinusDiscountTextBox.Text = $"{totalDiscount:C}";
            amountDue = (originalAmount + distanceCharge + dayCharge) - totalDiscount;
            YouOweTextBox.Text = $"{amountDue:C}";
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

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                TotalCalculation();
            }
            else
            {
                InputMessagesCheck();
            }
        }
    }
}
