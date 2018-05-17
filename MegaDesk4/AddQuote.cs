﻿using System;
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
            // it seems to me that most of this should be done in the constructor...
            // ADD VALIDATION!
            Desk newDesk = new Desk
            {
                Depth = DepthInput.Value,
                Width = WidthInput.Value,
                NumDrawers = (int)NumDrawersInput.Value,
                SurfaceMaterial = MaterialInput.Text
            };

            DeskQuote newQuote = new DeskQuote
            {
                Desk = newDesk,
                CustomerName = customerNameInput.Text,
                DeliveryTime = (int)RushOrderInput.SelectedValue,
                OrderDate = DateTime.Now
            };
            newQuote.Price = newQuote.CalcQuote();

            // Save to quotes.csv
            SaveQuote(newQuote);

            // Make the UI make sense
            saveNewQuoteButton.Visible = false;
            closeAddQuoteButton.Text = "Close";
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

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
                    Message.Text = $"Price: {quote.Price}";
                }
                catch (Exception Err)
                {
                    Message.Text = Err.Message;
                    // save err message
                }
            }
            else
            {
                Message.Text = $"Unable to find {fileName}";
            }
        }
    }
}
