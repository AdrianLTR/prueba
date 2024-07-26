using Principio_ISP.Printers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principio_ISP
{
    internal class Program
    {
        static void Main(string[] args)
            {
                Document doc = new Document { Name = "Mi Documento", Description = "prueba." };

                IPrint simplePrinter = new SimplePrinter();
                simplePrinter.Print(doc);

                MultiFunctionPrinter mfp = new MultiFunctionPrinter();
                mfp.Print(doc);
                mfp.Scan(doc);

            Console.WriteLine("Presione Enter para finalizar...");
            Console.ReadLine();
        }
        


    }
}
