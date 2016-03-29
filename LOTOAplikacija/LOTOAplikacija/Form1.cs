using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOTOAplikacija
{
    public partial class Form1 : Form
    {
        private Loto loto;
        public Form1()
        {
            InitializeComponent();
            loto = new Loto();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<string> vrijednosti = new List<string>();
            vrijednosti.Add(textBox1.Text);
            vrijednosti.Add(textBox2.Text);
            vrijednosti.Add(textBox3.Text);
            vrijednosti.Add(textBox4.Text);
            vrijednosti.Add(textBox5.Text);
            vrijednosti.Add(textBox6.Text);
            vrijednosti.Add(textBox7.Text);
            bool ispravnaKombinacija = loto.UnesiUplaceneBrojeve(vrijednosti);
            if (ispravnaKombinacija == true)
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
                MessageBox.Show("Kombinacija uplaćenih brojeva nije ispravna!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            loto.GenerirajDobitnuKombinaciju();
            textBox8.Text = loto.DobitniBrojevi[0].ToString();
            textBox9.Text = loto.DobitniBrojevi[0].ToString();
            textBox10.Text = loto.DobitniBrojevi[0].ToString();
            textBox11.Text = loto.DobitniBrojevi[0].ToString();
            textBox12.Text = loto.DobitniBrojevi[0].ToString();
            textBox13.Text = loto.DobitniBrojevi[0].ToString();
            textBox14.Text = loto.DobitniBrojevi[0].ToString();

            int brojPogodaka = loto.IzracunajBrojPogodaka();
            label2.Text = brojPogodaka.ToString();
        }
    }
}
