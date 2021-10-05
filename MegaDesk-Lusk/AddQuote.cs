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
    public partial class AddQuote : Form
    {
        private Form _mainMenu;

        private DateTime today = DateTime.Today;
        public AddQuote(Form mainMenu)
        {
            InitializeComponent();

            _mainMenu = mainMenu;

            lblAddQuoteDate.Text = today.ToShortDateString();
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            _mainMenu.Show();
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            if (!(numericUpDown1.Value >= 12 && numericUpDown1.Value <= 48))
            {
                // Shouldn't ever get to this point where min/max are set in the numericUpDown
                WidthWarningLabel.Text = "Please enter a value between 12 and 48 inches";
            } else
            {
                WidthWarningLabel.Text = "";
            }
        }

        private void widthBox_ValueChanged(object sender, EventArgs e)
        {
            if (!(widthBox.Value >= 24 && widthBox.Value <= 96))
            {
                // Shouldn't ever get to this point where min/max are set in the numericUpDown
                WidthWarningLabel.Text = "Please enter a value between 25 and 96 inches";
            }
            else
            {
                WidthWarningLabel.Text = "";
            }
        }

        private void btnSubmitAddQuote_Click(object sender, EventArgs e)
        {
            this.Hide();
            _mainMenu.Show();
        }

    }
}
