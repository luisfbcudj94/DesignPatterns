using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class DocumentRenderer
    {
        public void RenderDocument(DocumentFactory factory)
        {
            IDocument document = factory.CreateDocument();
            Console.WriteLine(document.Render());
        }
    }
}
