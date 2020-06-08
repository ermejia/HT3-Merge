using System;
using System.IO;

namespace HT3Formaters{
    public class FileFormat : IFormats {
       
        public void CSVConvert(string[] file)
        {
            System.Console.WriteLine("CSV FILES");
            float tamaño = file.Length;
            String lines = "";
            string docPath = Directory.GetCurrentDirectory();;
            File.WriteAllText(Path.Combine(docPath, "csv.csv"), "");
            for (int i = 0; i < tamaño; i++)
            {
                string text = System.IO.File.ReadAllText(@file[i]);
                text= text.Replace(" ", ",");
                System.Console.WriteLine("CSV FILE: " +(i+1)+"\n"+text + "\n");
                lines = "CSV FILE NO. : " + (i + 1) + "\n" + text + "\n";
                File.AppendAllText(Path.Combine(docPath, "csv.csv"),lines );
                
            }
        }

        public void FormatFile(string[] file)
        {
            throw new NotImplementedException();
        }
    }
}