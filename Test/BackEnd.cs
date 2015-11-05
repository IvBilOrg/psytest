using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
     class BackEnd
    {
        
         public  const string PATH_TEXT = "TestFile.txt";
         public  const string PATH_KEYS = "KeysFile.txt";
         public  const string PATH_RESULTS = "ResultsFile.txt";


         

         public static TxtTest txtTest = new TxtTest(PATH_TEXT);
         public static TxtKeys txtKeys = new TxtKeys(PATH_KEYS);
         public static char[] answ = new char[txtKeys.amountOfQuestions];



         public static int compareResults(char[] answ, char[] keys)
        {
            int result = 0;
            for (int i = 0; i < BackEnd.txtTest.amountOfQuestions; i++)
            {
                if (answ[i] == keys[i]) result++;
            }
            return result;
            
        }
        // compareResults(answ, TxtKeys); kkk
    }
}
