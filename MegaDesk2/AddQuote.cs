using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
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
        private DeskQuote savedQuote;

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

        private void CloseAddQuoteButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void GetQuoteButton_Click(object sender, EventArgs e)
        {
            // ADD VALIDATION!
            /* Create the desk object */
            Desk newDesk = new Desk
            {
                Depth = DepthInput.Value,
                Width = WidthInput.Value,
                NumDrawers = (int)NumDrawersInput.Value,
                SurfaceMaterial = (int)((Desk.Surface)MaterialInput.SelectedValue)
            };

            /* Convert Rush order to int so it can be added to the deskQuote object */
            int deliveryTime = (int)((DeskQuote.Delivery)RushOrderInput.SelectedValue);
            try
            {
                savedQuote = new DeskQuote(newDesk, customerNameInput.Text, deliveryTime, DateTime.Now);
                Message.Text = $"Quote: ${savedQuote.Price}";
                GetQuoteButton.Visible = false;
                saveQuoteButton.Visible = true;
            }
            catch (Exception Err)
            {
                Message.Text = Err.Message;
            }
        }

        private void SaveQuoteButton_Click(object sender, EventArgs e)
        {
            /*Save to quotes.csv */
            try
            {
                SaveQuote(savedQuote);
                saveQuoteButton.Visible = false;
                closeAddQuoteButton.Text = "Close";
            }
            catch (Exception Err)
            {
                Message.Text = Err.Message;
            }
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
            string fileName = @"H:\Documents\S8\CIT 365\MegaDesk-2\MegaDesk2\quotes.json";
            
            try
            {
                if (File.Exists(fileName))
                {
                    //Creating an object to store the data in
                    QuoteData jsonData = new QuoteData();
                    
                    //Storing the data
                    jsonData.Date  = quote.OrderDate;
                    jsonData.Name = quote.CustomerName;
                    jsonData.Total = (int)quote.Price;
                    jsonData.Order = (int)((DeskQuote.Delivery)RushOrderInput.SelectedValue);
                    Desk.Surface mType;
                    Enum.TryParse(MaterialInput.SelectedValue.ToString(), out mType);
                    jsonData.Material = mType.ToString();
                    jsonData.Drawers = quote.Desk.NumDrawers;
                    jsonData.Width = (int)quote.Desk.Width;
                    jsonData.Depth = (int)quote.Desk.Depth;


                    //Serializing the object
                    string quoteString = JsonConvert.SerializeObject(jsonData);

                    //Writing to the file
                    File.AppendAllText(fileName, quoteString + Environment.NewLine);

                    Message.Text = $"Price: ${quote.Price}";
                }
                else
                {
                    throw new Exception($"Unable to find {fileName}");
                }
            }
            catch (Exception)
            {
                throw;
            }
            
        }
    }
}
