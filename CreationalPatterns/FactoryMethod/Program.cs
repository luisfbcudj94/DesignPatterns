namespace FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DocumentRenderer renderer = new DocumentRenderer();

            DocumentFactory wordFactory = new WordDocumentFactory();
            DocumentFactory pdfFactory = new PDFDocumentFactory();
            DocumentFactory xlsxFctory = new XLSXDocumentFactory();

            renderer.RenderDocument(wordFactory); 
            renderer.RenderDocument(pdfFactory);
            renderer.RenderDocument(xlsxFctory);
        }
    }
}
