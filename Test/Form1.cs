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
        public int numberOfQuestion;
        

        public Form1()
        {
            numberOfQuestion = 1;
            InitializeComponent();
            this.labelStart.Location = new System.Drawing.Point(0,0);            
            this.labelStart.Size = this.Size;

            //labelStart.Size = System.Windows.Forms.Form;
            //nextPage();
            //numberOfQuestions--;
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            if ((radioButtonVariantA.Checked == false) && (radioButtonVariantB.Checked == false))
                MessageBox.Show("Выберите ответ");
            else 
            {
                if (radioButtonVariantA.Checked == true) BackEnd.answ[numberOfQuestion-1] = 'а';
                else BackEnd.answ[numberOfQuestion-1] = 'б';

                if (numberOfQuestion != BackEnd.txtTest.amountOfQuestions)
                {
                    numberOfQuestion++;
                    nextPage();
                }
                else
                {
                    this.Close();
                }
            }
           
            
        }



        protected void nextPage()
        {
            radioButtonVariantA.Checked = false;
            radioButtonVariantB.Checked = false;

            labelQuestion.Text = BackEnd.txtTest.test[numberOfQuestion-1, 0];
            radioButtonVariantA.Text = BackEnd.txtTest.test[numberOfQuestion-1, 1];
            radioButtonVariantB.Text = BackEnd.txtTest.test[numberOfQuestion-1, 2];


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