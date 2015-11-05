using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Test
{
    class TxtTest
    {
        public string[,] test;
        public string[] file;
        public string path;
        public int amountOfQuestions;
        
        public TxtTest(string path)
        {
            this.path = path;
            this.file = File.ReadAllLines(path);
            this.amountOfQuestions = file.Length/4;
            this.test = new string[amountOfQuestions, 3];
            TxtParser();
            
        }
        private void TxtParser()
        {
            for (int i = 0; i < file.Length; i++)
            {
                test[(int)(i / 4), 0] = file[i++];
                test[(int)(i / 4), 1] = file[i++];
                test[(int)(i / 4), 2] = file[i++];                
            }
        }

        public void Show()
        {
            for (int i = 0; i < amountOfQuestions; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(test[i, j]);
                }
            }
        }
         
    }

}
