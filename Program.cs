using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
namespace ConsoleApp1
{
    class Program
    {      
              
        static void Main(string[] args)
        {
            string[] somewords = { "1absd efgh2" };  //
            
            revesenumbersan(somewords[0]);

            Console.ReadKey();

        }





        static void revesenumbersan(string str)
        {

            char[] inputArray = str.ToCharArray();
            char[] result  = new char[str.Length];
            
            Regex regexnumbers= new Regex("[0-9]");
            Regex regexspaces = new Regex("[ ]");
 
            for (int i = 0; i < str.Length; i++)
            {

                Match match = regexspaces.Match(inputArray[i].ToString());

                if (match.Success)
                {
                    result [i] = ' ';
                }
                 
            }
            for(int i=0;i<str.Length;i++)
            {
                if(regexnumbers.Match(inputArray[i].ToString()).Success)
                {
                    result [i] = inputArray[i];
                }



            }

            
            int j = result .Length - 1;

            for (int i = 0; i < str.Length; i++)
            {
                if(!regexnumbers.Match(str[i].ToString()).Success)
                {
                    if (inputArray[i] != ' ')
                    {                      
                        
                        if (regexnumbers.Match(result[j].ToString()).Success)
                    {
                        j--;
                    }
                        if (result[j] == ' ')
                        {
                            j--;
                        }
                        result[j] = inputArray[i];
                        j--;

                    }
                                   
                }
                
            }
            for (int i = 0; i < result .Length; i++)
                Console.Write(result[i]);

        }
          
    }
}
