using System;

namespace InvoiceTask
{
    class InvoiceExecute
    {
        static void Main(string[] args)
        {
            var invoice = Invoice.CreateInvoice();
            invoice.printInfo();
        }
    }
}
