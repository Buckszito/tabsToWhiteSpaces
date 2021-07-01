using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Spaces
{
    class Program
    {
        static void Main(string[] args)
        {



            string filePath = @"C:\demo\MeditechIn.txt";

            string writeTo = @"C:\demo\MeditechOut.txt";
            //string[] line = File.ReadAllLines(filePath);
            List<string> list = new List<string>();
            List<string> newValue = new List<string>(); ;
            List<string> DoneValue = new List<string>();
            List<string> splittedStringArray = new List<string>(); ;
            string x="";

            string[] lines = File.ReadAllLines(filePath); //reads and stores line in line array

            foreach (String line in lines)
            {
                x = line;// stores string in x
                splittedStringArray = x.Split('\t').ToList(); //splits string by empty space and stores each word in list of strings
                newValue = new List<string>();
                for (int i = 0; i < splittedStringArray.Count; i++)
                {

                    int count = splittedStringArray[i].Length;
                    int spacees = 0;

                    if (count <= 8)
                    {
                        for (int xx = count; count < 8; count++)
                        {
                            spacees++;
                        }
                        newValue.Add(splittedStringArray[i] + new string(' ', spacees));//adds word plus missing spaces
                    }
                    else if (count > 8 && count <= 16)
                    {
                        for (int xx = count; count < 16; count++)
                        {
                            spacees++;
                        }
                        newValue.Add(splittedStringArray[i] + new string(' ', spacees));//adds word plus missing spaces

                    }
                    else if (count > 16 && count <= 24)
                    {
                        for (int xx = count; count < 24; count++)
                        {
                            spacees++;
                        }
                        newValue.Add(splittedStringArray[i] + new string(' ', spacees));//adds word plus missing spaces
                    }
                    else if (count > 24 && count <= 32)
                    {
                        for (int xx = count; count < 32; count++)
                        {
                            spacees++;
                        }
                        newValue.Add(splittedStringArray[i] + new string(' ', spacees));//adds word plus missing spaces
                    }
                    else if(count > 32 && count <= 40)
                    {
                        for (int xx = count; count < 40; count++)
                        {
                            spacees++;
                        }
                        newValue.Add(splittedStringArray[i] + new string(' ', spacees));//adds word plus missing spaces
                    }
                }

                DoneValue.Add(String.Concat(newValue));
            }

          

            File.WriteAllLines(writeTo, DoneValue);

            foreach (var item in DoneValue)
            {
                Console.WriteLine(item);
            }
           // concatenates strings from list into string 

            Console.ReadLine();


            
        }
    }
}
