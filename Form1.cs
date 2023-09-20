using System.Diagnostics.Eventing.Reader;

namespace SA_ID
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void validateButton_Click(object sender, EventArgs e)
        {

           
                // Get the ID number from the text box
                string idNumber = idNumberTextBox.Text;

                // Check if the ID number is valid
                if (IsValidIDNumber(idNumber))
                {
                    resultLabel.Text = "Valid ID number.";
                }
                else
                {
                    resultLabel.Text = "Invalid ID number.";
                }
            }

            private bool IsValidIDNumber(string idNumber)
            {
                // Check if the ID number is exactly 13 characters long
                if (idNumber.Length != 13)
                {
                    return false;
                }

                // Check that all characters in the ID number are digits
                if (!IsAllDigits(idNumber))
                {
                    return false;
                }

                // Check the year of birth (first 2 digits)
                int year = int.Parse(idNumber.Substring(0, 2));
                int currentYear = DateTime.Now.Year % 100;
                if (year > currentYear)
                {
                    year += 1900;
                }
                else
                {
                    year += 2000;
                }

                // Check the month of birth (next 2 digits)
                int month = int.Parse(idNumber.Substring(2, 2));
                if (month < 1 || month > 12)
                {
                    return false;
                }

                // Check the day of birth (next 2 digits)
                int day = int.Parse(idNumber.Substring(4, 2));
                if (day < 1 || day > DateTime.DaysInMonth(year, month))
                {
                    return false;
                }

                // Check the citizenship status (next digit)
                int citizenship = int.Parse(idNumber.Substring(10, 1));
                if (citizenship != 0 && citizenship != 1)
                {
                    return false;
                }

                // Check the gender (second to last digit)
                int gender = int.Parse(idNumber.Substring(11, 1));
                if (gender < 0 || gender > 4)
                {
                    return false;
                }

                // Check the check digit (last digit)
                int checkDigit = int.Parse(idNumber.Substring(12, 1));
                int checkSum = 0;
                for (int i = 0; i < 12; i++)
                {
                    int digit = int.Parse(idNumber.Substring(i, 1));
                    checkSum += digit * (2 - (i % 2));
                }
                int calculatedCheckDigit = (10 - (checkSum % 10)) % 10;
                if (checkDigit != calculatedCheckDigit)
                {
                    return false;
                }

                return true;
            }

            private bool IsAllDigits(string input)
            {
                foreach (char c in input)
                {
                    if (!Char.IsDigit(c))
                    {
                        return false;
                    }
                }
                return true;
            }
        }






    }



