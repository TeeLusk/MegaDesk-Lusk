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
            var addQuoteForm = new AddQuote(this);
            addQuoteForm.Show();

            this.Hide();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
