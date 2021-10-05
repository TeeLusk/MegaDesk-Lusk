using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Lusk
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btn_AddNewQuote_Click(object sender, EventArgs e)
        {
            try
            {
                var addQuoteForm = new AddQuote(this);
                addQuoteForm.Show();

                this.Hide();
            }
            catch (Exception err)
            {
                lblMainMenuMsg.Text = "An error has occurred: " + err;
            }

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_ViewQuotes_Click(object sender, EventArgs e)
        {
            var viewQuoteForm = new DisplayQuote(this);
            viewQuoteForm.Show();

            this.Hide();
        }

        private void btn_SearchQuotes_Click(object sender, EventArgs e)
        {
            var searchQuotesForm = new SearchQuotes(this);
            searchQuotesForm.Show();

            this.Hide();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
