﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class PDFDocumentFactory: DocumentFactory
    {
        public override IDocument CreateDocument()
        {
            return new PDFDocument();
        }
    }
}
