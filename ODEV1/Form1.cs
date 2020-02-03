using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ODEV1
{
    public partial class Form1 : Form
    {
        public static int ksa, ksb;
        public Form1()
        {
            InitializeComponent();
        }
        class işlem
        {
            public int k1a, k1b,k2a,k2b;
            

            public void topla()
            {
               
                ksa = k1a + k2a ;
                ksb = k1b + k2b;
    

            }
            
            public void çıkar()
            {
                ksa = k1a - k2a;
                ksb = k1b - k2b;


            }


        }


        private void button1_Click(object sender, EventArgs e)
        {

             işlem işlem1 = new işlem();

            

            işlem1.k1a = Convert.ToInt32(a1.Text);
            işlem1.k1b = Convert.ToInt32(b1.Text);
            işlem1.k2a = Convert.ToInt32(a2.Text);
            işlem1.k2b = Convert.ToInt32(b2.Text);



            
            

            if (comboBox1.Text == "TOPLAMA")
            {
                işlem1.topla();
            }
            else if(comboBox1.Text == "ÇIKARMA")
            {
                işlem1.çıkar();
            }

            Form2 yeni = new Form2();
            yeni.Show();






        }   
    }
}

