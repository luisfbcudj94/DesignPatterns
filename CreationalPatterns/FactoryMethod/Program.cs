namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DocumentRenderer renderer = new DocumentRenderer();

            DocumentFactory wordFactory = new WordDocumentFactory();
            DocumentFactory pdfFactory = new PDFDocumentFactory();

            renderer.RenderDocument(wordFactory); 
            renderer.RenderDocument(pdfFactory);  
        }
    }
}
