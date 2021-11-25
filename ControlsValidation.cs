using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseInterface
{
    static class ControlsValidation
    {
        public static bool ValidateAllFieldFilled(Control FirstName, Control LastName, Control Address, Control DateOfBirth, Control SoA, Control Position)
        {
            bool ValidationResults;
            if (FirstName.Text != "" && LastName.Text != "" && Address.Text != "" && DateOfBirth.Text != "" && SoA.Text != "" && Position.Text != "")
            {
                ValidationResults = true;
            }
            else
            {
                ValidationResults = false;
                MessageBox.Show("Database update failed because you forget to fill all mandatory fields. ");
            }
            return ValidationResults;
        }
        public static bool ValidateDate(Control ctrl)
        {
            if (!string.IsNullOrEmpty(ctrl.Text))
            {
                string[] formats = { "dd/mm/yyyy" };
                DateTime value;

                if (!DateTime.TryParseExact(ctrl.Text, formats, new CultureInfo("en-EN"), DateTimeStyles.None, out value))
                {
                    MessageBox.Show("Database update failed because you filled date in wrong format. Please fill date in format dd/mm/yyyy");
                    return false;
                }
            }
            return true;
        }
    }
}
