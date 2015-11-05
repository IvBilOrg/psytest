using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public int i = 0;
        

        public Form1()
        {
           
            InitializeComponent();
            this.labelStart.Location = new System.Drawing.Point(0,0);            
            this.labelStart.Size = this.Size;

            //labelStart.Size = System.Windows.Forms.Form;
            nextPage();
            i--;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((radioButtonVariantA.Checked == false) && (radioButtonVariantB.Checked == false))
                MessageBox.Show("Выберите ответ");
            else 
            {
                if (radioButtonVariantA.Checked == true) BackEnd.answ[i] = 'а';
                else BackEnd.answ[i] = 'б';
                
                nextPage();
               
            }
           
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void nextPage() 
        {
            radioButtonVariantA.Checked = false;
            radioButtonVariantB.Checked = false;
            if (i < BackEnd.txtTest.amountOfQuestions)
            {
                i++;
                labelQuestion.Text = BackEnd.txtTest.test[i, 0];
                radioButtonVariantA.Text = BackEnd.txtTest.test[i, 1];
                radioButtonVariantB.Text = BackEnd.txtTest.test[i, 2];
                
            }
            else
            {
                this.Close();
            }
        }

        private void labelStart_Click(object sender, EventArgs e)
        {
            labelStart.Visible = false;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.labelStart.Location = new System.Drawing.Point(0, 0);
            this.labelStart.Size = this.Size;
        }
    }
}