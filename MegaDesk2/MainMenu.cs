using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk4
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void newQuoteButton_Click(object sender, EventArgs e)
        {
            AddQuote addNewQuoteForm = new AddQuote(); // generate a new form
            addNewQuoteForm.Tag = this; // assign the new form's Tag to reference the main menu
            addNewQuoteForm.Show(this); //show the new form. this is the owner of the new form
            Hide(); // hide this form. Same as this.Hide()
        }

        private void CloseMainMenuButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ViewQuotesButton_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewQuotesForm = new ViewAllQuotes();
            viewQuotesForm.Tag = this;
            viewQuotesForm.Show(this);
            Hide();
        }

        private void SearchQuotesButton_Click(object sender, EventArgs e)
        {
            SearchQuotes searchQuotesForm = new SearchQuotes();
            searchQuotesForm.Tag = this;
            searchQuotesForm.Show(this);
            Hide();
        }
    }
}
