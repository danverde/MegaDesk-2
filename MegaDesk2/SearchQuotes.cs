using Newtonsoft.Json;
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
        public SearchQuotes()
        {
            InitializeComponent();
            var materials = new List<Desk.Surface>();

            materials = Enum.GetValues(typeof(Desk.Surface))
                .Cast<Desk.Surface>()
                .ToList();

            SearchBox.DataSource = materials;

            ReadQuotes();
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
            var fileName = @"H:\Documents\S8\CIT 365\MegaDesk-2\MegaDesk2\quotes.json";

            if (File.Exists(fileName))
            {
                try
                {
                    var quotes = File.ReadAllLines(fileName);  //....Storing the lines in a string[]
                    var quoteList = new List<string>(quotes);  //....Truning it into a list
                    /*
                     * Here I am using a Data Table that can be easily loaded into the dataGridView
                     * It starts by creating the columns then the rows and adding everything to the table 
                     */
                    //Creating a table
                    DataTable table = new DataTable();


                    //Setting up the column, row and view
                    DataColumn column;
                    DataRow row;

                    //Creating individual columns
                    //Name column
                    column = new DataColumn();       //....................................Creating a column object
                    column.DataType = System.Type.GetType("System.String"); //.............Setting the data type
                    column.ColumnName = "Name";     //.....................................Giving the column a name
                    table.Columns.Add(column);      //.....................................Finally Adding the column to the table

                    //Width
                    column = new DataColumn();
                    column.DataType = System.Type.GetType("System.Int32");
                    column.ColumnName = "Width";
                    table.Columns.Add(column);

                    //Depth
                    column = new DataColumn();
                    column.DataType = System.Type.GetType("System.Int32");
                    column.ColumnName = "Depth";
                    table.Columns.Add(column);

                    //Drawers
                    column = new DataColumn();
                    column.DataType = System.Type.GetType("System.Int32");
                    column.ColumnName = "Drawers";
                    table.Columns.Add(column);

                    //Material
                    column = new DataColumn();
                    column.DataType = System.Type.GetType("System.String");
                    column.ColumnName = "Material";
                    table.Columns.Add(column);

                    //Order
                    column = new DataColumn();
                    column.DataType = System.Type.GetType("System.String");
                    column.ColumnName = "Order";
                    table.Columns.Add(column);

                    //Date
                    column = new DataColumn();
                    column.DataType = System.Type.GetType("System.DateTime");
                    column.ColumnName = "Date";
                    table.Columns.Add(column);

                    //Total Price
                    column = new DataColumn();
                    column.DataType = System.Type.GetType("System.String");
                    column.ColumnName = "Total";
                    table.Columns.Add(column);

                    // remove all rows
                    foreach (string quote in quoteList)
                    {
                        // Every item in the list will be deserialized into a QuoteData object
                        QuoteData json = JsonConvert.DeserializeObject<QuoteData>(quote);
                        // get search criteria
                        var searchMaterial = (Desk.Surface)SearchBox.SelectedValue;
                        var searchStuff = searchMaterial.ToString();
                        if (json.Material == searchStuff)
                        {
                            //Them added as a row in the DataTable
                            row = table.NewRow();
                            row["Name"] = json.Name;
                            row["Width"] = json.Width;
                            row["Depth"] = json.Depth;
                            row["Drawers"] = json.Drawers;
                            row["Material"] = json.Material;
                            row["Order"] = json.Order;
                            row["Date"] = json.Date;
                            row["Total"] = json.Total + "$";
                            table.Rows.Add(row);
                        }
                    }
                    SearchAll.DataSource = table;

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

        // COULD BE  A SELECTED INDEX CHANGE EVENT (of comboBox)
        private void SearchButton_Click(object sender, EventArgs e)
        {
            ReadQuotes();
        }
    }
}
