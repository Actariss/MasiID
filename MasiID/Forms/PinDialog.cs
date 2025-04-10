using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasiID.Forms
{
    public partial class PinDialog : MaterialForm
    {

        public string Pin => PinBox.Text;

        public PinDialog()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (PinBox.Text.Length != 4 || !PinBox.Text.All(char.IsDigit))
            {
                MessageBox.Show("Le code PIN doit contenir 4 chiffres.");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
