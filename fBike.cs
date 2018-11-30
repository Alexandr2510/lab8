using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab08
{
    public partial class fBike : Form
    {
        private Bike TheBike;
        internal fBike(Bike t)
        {
            TheBike = t;
            InitializeComponent();
        }
        
        private void btnOk_Click(object sender, EventArgs e)
        {
            TheBike.Nazv = tbNazv.Text.Trim();
            TheBike.Klass  = tbKlass.Text.Trim();
            TheBike.Type = tbType.Text.Trim();
            TheBike.Color = tbColor.Text.Trim();
            TheBike.Katafoti = int.Parse(tbKatafoti.Text.Trim());
            TheBike.Dzvonik = chbDzvonik.Checked;
            TheBike.Brakes_Disc = chbBrakes_Disc.Checked;
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void fBike_Load(object sender, EventArgs e)
        {
            if (TheBike != null)
            {
                tbNazv.Text = TheBike.Nazv;
                tbKlass.Text = TheBike.Klass;
                tbType.Text = TheBike.Type;
                tbColor.Text = TheBike.Color;
                tbKatafoti.Text = TheBike.Katafoti.ToString();
                chbDzvonik.Checked = TheBike.Dzvonik;
                chbBrakes_Disc.Checked = TheBike.Brakes_Disc;
            }
        }

       
    }
}
