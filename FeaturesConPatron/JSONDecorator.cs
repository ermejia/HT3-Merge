using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HT3Formaters{
    public class JSONDecorator : DecoratorFormater {

        public JSONDecorator() {
        }
        public void JSONConvert(String[] file) {
            float size = file.Length;
            String nlines = "";
            string docPath = Directory.GetCurrentDirectory();;
            File.WriteAllText(Path.Combine(docPath, "json.json"), "");
            System.Console.WriteLine("\nJSON Format Files\n");
            for (int i = 0; i < size; i++)
            {
                string text = System.IO.File.ReadAllText(@file[i]);
                List<string> result = text.Split(' ').ToList();
                System.Console.WriteLine("\"JSON FILE NO."+ (i+1)+"\": [");
                File.AppendAllText(Path.Combine(docPath, "json.json"), ("\"JSON FILE NO."+ (i+1)+"\": [") );
                result.ForEach(delegate(String output)
                {
                    Console.WriteLine("\t {\"" +output+"\"" + "},");
                    nlines = "\t {\"" +output+"\"" + "},";
                    File.AppendAllText(Path.Combine(docPath, "json.json"),nlines );
                });
                System.Console.WriteLine("\t ]\n");
                File.AppendAllText(Path.Combine(docPath, "json.json"), ("\t ]\n"));
            }
        }

        public override void FormatFile(string[] file)
        {
            this.JSONConvert(file);
        }
    }
}