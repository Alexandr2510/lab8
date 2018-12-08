using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_8
{
    public partial class BikeForm : Form
    {
        public Bike TheBike;

        public BikeForm(Bike t)
        {
            TheBike = t;
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                TheBike.Nazv = tbNazv.Text.Trim();
                TheBike.Klass = tbKlass.Text.Trim();
                TheBike.Type = tbType.Text.Trim();
                TheBike.Color = tbColor.Text.Trim();
                TheBike.Katafoti = int.Parse(tbKatafoti.Text.Trim());
                TheBike.Weight = int.Parse(tbWeight.Text.Trim());
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                string err = String.Format("Error number. {0}", ex.Message);
                MessageBox.Show(err, "Conversion error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void BikeForm_Load(object sender, EventArgs e)
        {
            if (TheBike != null)
            {
                tbNazv.Text = TheBike.Nazv;
                tbKlass.Text = TheBike.Klass;
                tbType.Text = TheBike.Type;
                tbColor.Text = TheBike.Color;
                tbKatafoti.Text = TheBike.Katafoti.ToString();
                tbWeight.Text = TheBike.Weight.ToString();
            }
        }
    }
}