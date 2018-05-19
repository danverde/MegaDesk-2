using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk4
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
            ReadQuotes();
        }

        private void CloseViewAllQuotesButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void ViewAllQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenu mainMenu = (MainMenu)Tag;
            mainMenu.Show();
        }

        private void ReadQuotes()
        {
            var fileName = "quotes.csv";
            string[] quotes;

            if (File.Exists(fileName))
            {
                try
                {
                    quotes = File.ReadAllLines(fileName);
                    for (int i = 1; i < quotes.Length; i++)
                    {
                        // this has got to be an awful way to do this...
                        var quote = quotes[i].Split(',').ToArray();
                        viewAll.Rows.Add(quote[0], quote[1], quote[2], quote[3], quote[4], quote[5], quote[6], quote[7]);
                    }
                }
                catch (Exception Err)
                {
                    MessageLabel.Text = Err.Message;
                }
            }
            else
            {
                MessageLabel.Text = "Unable to find quotes file";
            }
        }
    }
}
