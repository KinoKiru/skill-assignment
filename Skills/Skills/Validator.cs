using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skills
{
	class Validator
	{
		private static string title = "Entry Error";

		public static string Title
		{
			get
			{
				return title;
			}
			set
			{
				title = value;
			}
		}

		public static bool IsPresent(TextBox textBox)
		{
			if (textBox.Text == "")
			{
				MessageBox.Show(textBox.Tag + " is a required field.", title);
				textBox.Focus();
				return false;
			}
			return true;
		}

		public static bool IsDecimal(TextBox textBox)
		{
			decimal number = 0m;
			if (Decimal.TryParse(textBox.Text, out number))
			{
				return true;
			}
			else
			{
				MessageBox.Show(textBox.Tag + " must be a decimal value.", title);
				textBox.Focus();
				return false;
			}
		}

	    //checks the given TextBox if it is an int32
		public static bool IsInt32(TextBox textBox)
		{
			int number = 0;
			if (Int32.TryParse(textBox.Text, out number))
			{
				return true;
			}
			else
			{
				MessageBox.Show(textBox.Tag + " must be an integer.", title);
				textBox.Focus();
				return false;
			}
		}

		//checks if the value of the textbox is between the given max/min
		public static bool IsWithinRange(TextBox textBox, decimal min, decimal max)
		{
			decimal number = Convert.ToDecimal(textBox.Text);
			if (number < min || number > max)
			{
				MessageBox.Show(textBox.Tag + " must be between " + min
					+ " and " + max + ".", Title);
				textBox.Focus();
				return false;
			}
			return true;
		}

		public static bool IsValidEmail(TextBox textbox)
		{

			if (textbox.Text.Contains("@") && (textbox.Text.Contains(".com") || textbox.Text.Contains(".nl")))
			{
				return true;
			}
			MessageBox.Show("Enter a valid email", title);
			return false;

		}

		public static bool IsValidUrl(TextBox textbox) {
			if (textbox.Text.Contains("https") || textbox.Text.Contains("http"))
			{
				return true;
			}
			MessageBox.Show("Enter a valid url", title);
			return false;
		} 
	}
}
