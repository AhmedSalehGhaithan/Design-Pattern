using Document_Format_Converters.DocumentFormatConverters;
using Factory_Method_Design_Pattern.CreditCardSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DocumentFormatConverters();
            Console.ReadLine();
        }
        static void DocumentFormatConverters()
        {
            var documentService = new DocumentService();
            // User wants to export to PDF:
            documentService.ExportDocument(new PdfConverterFactory(), "source.docx", "output.pdf");
            // User wants to export to DOCX:
            documentService.ExportDocument(new DocxConverterFactory(), "source.pdf", "output.docx");
            // User wants to export to TXT:
            documentService.ExportDocument(new TxtConverterFactory(), "source.pdf", "output.txt");
        }
        static void CreditCardExample()
        {
            // The client code works with an instance of a concrete creator
            // The CreateProduct will return the actual product instance via the product interface
            //PlatinumFactory CreateProduct method will return an instance of Platinum Product via the CreditCard interface
            CreditCard creditCard = new PlatinumFactory().CreateProduct();
            if (creditCard != null)
            {
                Console.WriteLine("Card Type : " + creditCard.GetCardType());
                Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
                Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
            Console.WriteLine("--------------");
            //MoneyBackFactory CreateProduct method will return an instance of Platinum Product via the CreditCard interface
            creditCard = new TitaniumFactory().CreateProduct();
            if (creditCard != null)
            {
                Console.WriteLine("Card Type : " + creditCard.GetCardType());
                Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
                Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }
        }
    }
}
