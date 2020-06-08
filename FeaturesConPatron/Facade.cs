using System;

namespace HT3Formaters{
    public class Facade {

        public Facade() {
        }

        public void FormatConvert(String[] args) {
            String format = args[args.Length - 1];
            Array.Resize(ref args, args.Length - 1);
            IFormats formater=new FileFormat();
            switch (format)
            {   case "CSV":
                    formater.FormatFile(args);
                    break;
                case "HTML":
                    DecoratorFormater htmldecorator=new HTMLDecorator();
                    htmldecorator.SetFormat(formater);
                    htmldecorator.FormatFile(args);
                    break;
                case "XML":
                    DecoratorFormater xmldecorator=new XMLDecorator();
                    xmldecorator.SetFormat(formater);
                    xmldecorator.FormatFile(args);
                    break;
                case "JSON":
                    DecoratorFormater jsondecorator=new JSONDecorator();
                    jsondecorator.SetFormat(formater);
                    jsondecorator.FormatFile(args);
                    break;
                default: System.Console.WriteLine("ERROR! You have to specify the file extension");
                    break;
            }
            
        }

    }
}