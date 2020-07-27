using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Словарик
{
    public partial class FormTest : Form
    {
        Form obj;
        public FormTest(Form obj)
        {
            this.obj = obj;
            InitializeComponent();
        }
       public int po = 0;
        string p = "Правильных ответов ";
        string o = " из 8";
        string op;
        //int i = 0;
        //int j = 0;
        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = imageList1.Images[0];
            pictureBox2.Image = imageList1.Images[13];
            pictureBox3.Image = imageList1.Images[9];
            pictureBox4.Image = imageList1.Images[16];
            pictureBox5.Image = imageList1.Images[20];
            pictureBox6.Image = imageList1.Images[5];
            pictureBox7.Image = imageList1.Images[22];
            pictureBox8.Image = imageList1.Images[2];
        }

       

        public void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //po++;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            // Form1 sf = new Form1();
            //sf.Show();
             //Form1.ActiveForm.Visible = true;
            //Form1.ActiveForm.Activate();
            
            if (radioButton1.Checked == true) po++;
            if (radioButton10.Checked == true) po++;
            if (radioButton16.Checked == true) po++;
            if (radioButton19.Checked == true) po++;
            if (radioButton28.Checked == true) po++;
            if (radioButton33.Checked == true) po++;
            if (radioButton41.Checked == true) po++;
            if (radioButton46.Checked == true) po++;
                    
                        op = p + po + o;
            MessageBox.Show(op);
            

            Close();
            obj.Show();
            


        }

        private void Form2_Leave(object sender, EventArgs e)
        {
           /* Form1.ActiveForm.Visible = true;
            Form1.ActiveForm.Show();
            MessageBox.Show("Вот такие пироги");*/
        }





    }
}
