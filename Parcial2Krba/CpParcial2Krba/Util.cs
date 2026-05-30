using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace CpParcial2Krba
{
    internal class Util
    {
        public static bool notPaste = true;

        public static void onlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 22 && notPaste) e.Handled = true;
            else if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)) e.Handled = false;
            else e.Handled = true;
        }

        public static void onlyDecimals(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 22 && notPaste)
            {
                e.Handled = true;
                return;
            }

            char separator = char.Parse(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            char group = char.Parse(CultureInfo.CurrentCulture.NumberFormat.NumberGroupSeparator);
            int points = ((Control)sender).Text.Split(separator).Count();

            if (group.Equals(e.KeyChar)) e.KeyChar = separator;
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)) e.Handled = false;
            else if (separator.Equals(e.KeyChar) && points <= 1) e.Handled = false;
            else e.Handled = true;

            ((Control)sender).Text = ((Control)sender).Text.Replace(group, separator);
        }
    }
}