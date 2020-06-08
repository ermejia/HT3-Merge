using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HT3Formaters{
    public class XMLDecorator : DecoratorFormater {

        public XMLDecorator() {
        }
        
        public void XMLConvert(String[] file) {
            float size = file.Length;
            string docPath = Directory.GetCurrentDirectory();;
            File.WriteAllText(Path.Combine(docPath, "xml.xml"), "");
            for (int i = 0; i < size; i++)
            {
                string text = System.IO.File.ReadAllText(@file[i]);
                List<string> result = text.Split(' ').ToList();
                System.Console.WriteLine("<File" + (i + 1)+">");
                File.AppendAllText(Path.Combine(docPath, "xml.xml"), ("<File" + (i + 1)+">"));
                result.ForEach(delegate(String name)
                {
                    Console.WriteLine("   <paragraph> " + name + " </paragraph>");
                    File.AppendAllText(Path.Combine(docPath, "xml.xml"), ("   <paragraph> " + name + " </paragraph>"));
                });
                System.Console.WriteLine("</File" + (i + 1)+"> \n");
                File.AppendAllText(Path.Combine(docPath, "xml.xml"), ("</File" + (i + 1)+"> \n"));
            }
            
        }
        
        public override void FormatFile(string[] file)
        {
            this.XMLConvert(file);
        }

        
    }
}