using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HT3Formaters{
    public class HTMLDecorator : DecoratorFormater {

        public HTMLDecorator() {
        }

        public void HTMLConvert(String[] file) {
            float size = file.Length;
            String nline = "";
            string docPath = Directory.GetCurrentDirectory();;
            File.WriteAllText(Path.Combine(docPath, "html.html"), "<html> \n <head>\n <title> 'HTML' </title>\n </head>\n <body>\n");
            for (int i = 0; i < size; i++)
            {
                string text = System.IO.File.ReadAllText(@file[i]);
                List<string> result = text.Split(' ').ToList();
                System.Console.WriteLine("\nHTML FILE NO. : " +(i+1));
                File.AppendAllText(Path.Combine(docPath,"html.html"), ("<h3> Archivo No. : " +(i+1))+ "</h3>");
                result.ForEach(delegate(String newText)
                {
                    Console.WriteLine("<p> "+newText+" </p>");
                    nline = "<p> " + newText + " </p>";
                    File.AppendAllText(Path.Combine(docPath, "html.html"),nline );
                });
            }

            File.AppendAllText(Path.Combine(docPath, "html.html"), "</body>\n </html>");
        }
        public override void FormatFile(string[] file)
        {
            this.HTMLConvert(file);
        }
    }
}