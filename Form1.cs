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
    public partial class MainForm : Form
    {
        private BindingList<Bike> bikes;

        public MainForm()
        {
            InitializeComponent();
            bikes = new BindingList<Bike>();
            listBox1.DisplayMember = "Name";
            listBox1.DataSource = bikes;
            listBox1.SelectedIndexChanged += new EventHandler(ListBox1_SelectedIndexChanged);
        }

        private void BtnAddBike_Click(object sender, EventArgs e)
        {
            Bike bike = new Bike();
            BikeForm af = new BikeForm(bike);
            if (af.ShowDialog() == DialogResult.OK)
            {
                bikes.Add(bike);
            }
        }

        void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bike bike = (Bike)listBox1.SelectedItem;
            MessageBox.Show("Назва:   " + bike.Nazv + " \n " +
                "Клас: " + bike.Klass + " \n " +
                "Тип: " + bike.Type + " \n " +
                "Колір: " + bike.Color + "\n" +
                "Кількість катафотів: " + bike.Katafoti + "\n" +
                "Вага: " + bike.Weight + " кг",
                "Інформація про велосипед", MessageBoxButtons.OK);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Завершити роботу?", "Закінчення работи", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}