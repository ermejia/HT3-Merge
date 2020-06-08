using System;

namespace HT3Csv
{
    public class ConverterCsv
    {
        public void converterCsv(String[] archivo)
        {
  
            float a = archivo.Length;
            for (int nFile = 0; nFile < a; nFile++)
            {
                string text = System.IO.File.ReadAllText(@archivo[nFile]);
                text= text.Replace(" ", ",");
                System.Console.WriteLine("File Number : " +(nFile+1));
                System.Console.WriteLine(text+"\n");
                
            }
            
        } 
    }
}