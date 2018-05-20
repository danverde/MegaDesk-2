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
    public partial class SearchQuotes : Form
    {
        private String[] DeskQuotes;

        public SearchQuotes()
        {
            InitializeComponent();
            ReadQuotes();

            var materials = new List<Desk.Surface>();

            materials = Enum.GetValues(typeof(Desk.Surface))
                .Cast<Desk.Surface>()
                .ToList();

            SearchBox.DataSource = materials;
        }

        private void CloseSearchQuotesButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void SearchQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenu mainMenu = (MainMenu)Tag;
            mainMenu.Show();
        }

        // this is a copy of the code from viewAllQuote
        private void ReadQuotes()
        {
            var fileName = "quotes.csv";
            // string[] quotes;

            if (File.Exists(fileName))
            {
                try
                {
                    DeskQuotes = File.ReadAllLines(fileName);
                    for (int i = 1; i < DeskQuotes.Length; i++)
                    {
                        // this has got to be an awful way to do this...
                        var quote = DeskQuotes[i].Split(',').ToArray();
                        SearchAll.Rows.Add(quote[0], quote[1], quote[2], quote[3], quote[4], quote[5], quote[6], quote[7]);
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

        private void SearchButton_Click(object sender, EventArgs e)
        {
            // get search criteria
            var searchMaterial = (Desk.Surface)SearchBox.SelectedValue;
            var searchStuff = searchMaterial.ToString();

            // remove all rows
            SearchAll.Rows.Clear();

            // add matching rows
            for (int i = 1; i < DeskQuotes.Length; i++)
            {
                var quote = DeskQuotes[i].Split(',').ToArray();
                if (quote[4] == searchStuff)
                {
                    SearchAll.Rows.Add(quote[0], quote[1], quote[2], quote[3], quote[4], quote[5], quote[6], quote[7]);
                }
                
            }
        }
    }
}
