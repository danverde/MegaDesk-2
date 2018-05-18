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
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
            var materials = new List<Desk.Surface>();
            var delivery = new List<DeskQuote.Delivery>();

            materials = Enum.GetValues(typeof(Desk.Surface))
                .Cast<Desk.Surface>()
                .ToList();

            delivery = Enum.GetValues(typeof(DeskQuote.Delivery))
                .Cast<DeskQuote.Delivery>()
                .ToList();

            RushOrderInput.DataSource = delivery;
            MaterialInput.DataSource = materials;
        }

        private void closeAddQuoteButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void saveNewQuoteButton_Click(object sender, EventArgs e)
        {
            // ADD VALIDATION!
            Desk newDesk = new Desk
            {
                Depth = DepthInput.Value,
                Width = WidthInput.Value,
                NumDrawers = (int)NumDrawersInput.Value,
                SurfaceMaterial = (int)((Desk.Surface)MaterialInput.SelectedValue)
            };

            int deliveryTime = (int)((DeskQuote.Delivery)RushOrderInput.SelectedValue);
            DeskQuote newQuote = new DeskQuote(newDesk, customerNameInput.Text, deliveryTime, DateTime.Now);

            // Save to quotes.csv
            SaveQuote(newQuote);

            // Make the UI make sense
            saveNewQuoteButton.Visible = false;
            closeAddQuoteButton.Text = "Close";
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenu mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            mainMenu.Show();
        }

        private void SaveQuote(DeskQuote quote)
        {
            // @"" means you don't have to escape \ characters in the string
            string fileName = "quotes.csv";
            
            if (File.Exists(fileName))
            {
                try
                {
                    string quoteString = $"{quote.OrderDate}," +
                        $"{quote.CustomerName}," +
                        $"{quote.Price}," +
                        $"{quote.DeliveryTime}," +
                        $"{quote.Desk.SurfaceMaterial}," +
                        $"{quote.Desk.NumDrawers}," +
                        $"{quote.Desk.Width}," +
                        $"{quote.Desk.Depth}\n";
                    File.AppendAllText(fileName, quoteString);
                    Message.Text = $"Price: ${quote.Price}";
                }
                catch (Exception Err)
                {
                    Message.Text = Err.Message;
                }
            }
            else
            {
                Message.Text = $"Unable to find {fileName}";
            }
        }
    }
}
