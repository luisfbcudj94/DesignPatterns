using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class WordDocument : IDocument
    {
        public string Render()
        {
            return "Rendering a Word document.";
        }
    }
}
