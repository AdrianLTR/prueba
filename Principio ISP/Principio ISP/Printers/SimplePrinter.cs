using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_ISP.Printers
{
    public class SimplePrinter : IPrint
    {
        public void Print(Document doc)
        {
            Console.WriteLine($"Imprimiendo Documento: {doc.Name}");
        }
    }
}
