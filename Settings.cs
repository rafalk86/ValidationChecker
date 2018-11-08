using System;
using System.Windows.Forms;

namespace ValidationChecker
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void accept_Click(object sender, EventArgs e)
        {
            if(currency.Text == "" || amount.Text == "" || description.Text == "")
            {
                MessageBox.Show("Co najmniej jedno z pól jest puste.");
            }
            else
            {
                Properties.Settings.Default["currency"] = currency.Text;
                Properties.Settings.Default["amount"] = amount.Text;
                Properties.Settings.Default["description"] = description.Text;
                Properties.Settings.Default.Save();
                Close();
            }
        }
    }
}
