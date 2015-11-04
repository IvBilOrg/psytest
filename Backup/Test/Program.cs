using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Test
{
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            BackEnd backEnd = new BackEnd();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 mainForm = new Form1();
            Application.Run(mainForm);
            if (mainForm.i == BackEnd.txtTest.amountOfQuestions) Application.Run(new Form2());
        }
    }
}