using System;

namespace HT3Formaters{
    public abstract class DecoratorFormater : IFormats {

        public DecoratorFormater() {
        }

        protected IFormats format;
        
        public void SetFormat(IFormats format)
        {
            this.format = format;
        }
        
        public abstract void FormatFile(string[] archivo);
    }
}    