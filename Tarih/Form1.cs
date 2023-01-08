using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarih
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        string tarih, zaman;

        private void button1_Click(object sender, EventArgs e)
        {
            tarih = numericGun.Value + "/" + numericAy.Value + "/" + numericYil.Value;
            zaman = numericSaat.Value + "." + numericDakika.Value;
            MessageBox.Show("Tarih: " + tarih + "\nZaman: " + zaman);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            numericAy.Minimum = 1; numericAy.Maximum = 12;
            numericGun.Minimum = 1; numericGun.Maximum = 31;
            numericYil.Minimum = 1934; numericYil.Maximum = 9999;
            numericSaat.Minimum = 1; numericSaat.Maximum = 23;
            numericDakika.Minimum = 1; numericDakika.Maximum = 59;
            numericSaniye.Minimum = 1; numericSaniye.Maximum = 59;

            numericYil.Value = DateTime.Now.Year;
            numericAy.Value = DateTime.Now.Month;
            numericGun.Value = DateTime.Now.Day;
            numericSaat.Value = DateTime.Now.Hour;
            numericDakika.Value = DateTime.Now.Minute;
            numericSaniye.Value = DateTime.Now.Second;

        }
    }
}
