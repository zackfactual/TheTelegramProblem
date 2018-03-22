using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TheTelegramProblem
{
	public partial class Default : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void goButton_Click(object sender, EventArgs e)
		{
			// reset resultLabel
			resultLabel.Text = "";
			int lineLimit;
			string line = "";

			// read character limit of lines from integer text box
			if (int.TryParse(integerTextBox.Text, out lineLimit))
			{
				// read string from stringTextBox
				if(stringTextBox.Text.Trim().Length != 0)
				{
					// split string into an array of words by spaces
					string[] wordsInString = stringTextBox.Text.Split(' ');

					foreach (var word in wordsInString)
					{
						// throw exception if any word in the string is longer than the lineLimit
						if (word.Length > lineLimit)
						{
							resultLabel.Text = String.Format("Please enter a string with no words longer than {0} characters!",
								lineLimit);
							return;
						}
						// if line length + word length <= lineLimit, add word to line
						else if ((line.Length + word.Length) <= lineLimit)
						{
							line += (word + " ");
						}
						// if line length + word length > lineLimit, break and display line, then reset line to word
						else if ((line.Length + word.Length) > lineLimit)
						{
							line += "<br />";
							resultLabel.Text += line;
							line = (word + " ");
						}
					}
					// add last word in string
					resultLabel.Text += wordsInString[wordsInString.Length - 1];
				}
				// throw exception if no string or integer is input by the user
				else
				{
					resultLabel.Text = "Please enter a valid string!";
				}
			}
			else
			{
				resultLabel.Text = "Please enter a valid integer!";
			}
		}
	}
}