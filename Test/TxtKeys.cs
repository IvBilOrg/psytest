using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Test
{
    class TxtKeys
    {
        public char[] keys;
        public string[] file;
        public string path;
        public int amountOfQuestions;

        public TxtKeys(string path)
        {
            this.path = path;
            this.file = File.ReadAllLines(path);
            this.amountOfQuestions = file.Length-1;
            this.keys = new char[amountOfQuestions];
            TxtParser();
        }
        private void TxtParser()
        {
            for (int i = 0; i < file.Length-1; i++)
            {
                keys[i] = file[i][2];
            }
        }

        public void Show()
        {
            for (int i = 0; i < amountOfQuestions; i++)
            {
                Console.WriteLine(keys[i]);
            }
        }
    }
}
