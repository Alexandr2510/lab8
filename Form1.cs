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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnAddBike_Click(object sender, EventArgs e)
        {
            Bike bike = new Bike();
            fBike ft = new fBike(bike);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                tbBikeInfo.Text +=
                string.Format("Назва: {0} , Клас: {1} , Тип: {2} , Колiр: {3} , Кількість катафотiв: {4},  {5} , {6} \r\n",
                bike.Nazv, bike.Klass, bike.Type,
                bike.Color, bike.Katafoti,
                bike.Dzvonik ? "Є дзвоник" : "Немає дзвоника",
                bike.Brakes_Disc ? "Дискові гальма" : "Не дискові гальма");
                
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Припинити роботу застосунку?",
           "Припинити роботу", MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }

        private void fMain_Load(object sender, EventArgs e)
        {

        }

        private void tbBikeInfo_TextChanged(object sender, EventArgs e)
        {

        }
    }

    class tbBikeInfo
    {
        internal static string Text;
    }
}
