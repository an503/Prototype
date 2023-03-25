using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var flowersbouquetBuilder = new FlowerBouquetBuilder();

            if (radioButton1.Checked) 
            {
                flowersbouquetBuilder.SetName("Rose");
                MessageBox.Show("Назва букету Rose");
            }
            if (radioButton2.Checked)
            {
                flowersbouquetBuilder.SetName("Orchids");
                MessageBox.Show("Назва букету Orchids");
            }

            if(radioButton4.Checked)
            {
                flowersbouquetBuilder.SetSize("15");
                MessageBox.Show("Вміст букету 15 квіток");
            }
            if (radioButton5.Checked) 
            {
                flowersbouquetBuilder.SetSize("7");
                MessageBox.Show("Вміст букету 7 квіток");
            }
            int pack = 144;
            if (radioButton6.Checked)
            {
                flowersbouquetBuilder.SetPack(pack);
                MessageBox.Show("В букеті" + pack +"обгортки");
            }
            if (radioButton7.Checked)
            {
                flowersbouquetBuilder.SetPack(pack);
                MessageBox.Show("В букеті " + pack + "обгортки");
            }
            
            var flowersbouquet = flowersbouquetBuilder.GetFlowersBouquet();
            var flowersbouquetImage = GetflowersbouquetImage(flowersbouquet);

            var copy = FlowerBouquet.DeepCopy();
            var flowersbouquetImages = CopyFlowersBouquet(copy);
        }

        private object CopyFlowersBouquet(object copy)
        {
            throw new NotImplementedException();
        }

        private object GetflowersbouquetImage(object flowersbouquet)
        {
            throw new NotImplementedException();
        }

        private Image GetflowersbouquetImage(FlowerBouquet flowersbouquet)
        {
            if (flowersbouquet.Pack == 144)
            {
                return pictureBox1.Image = Resource1._144;
            }
            else
            {
                return pictureBox1.Image = Resource1._120;
            }
        }

        private Image CopyFlowersBouquet(FlowerBouquet copy)
        {
            if (copy.Pack == 144)
            {
                return pictureBox2.Image = Resource1._144;
            }
            else
            {
                return pictureBox2.Image = Resource1._120;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }     
}
