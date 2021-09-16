using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ParserUtils.ParserUtil;

namespace InvoiceTask
{
    class Invoice
    {
        private readonly int _account;
        private readonly string _customer;
        private readonly string _provider;
        private string _article;
        private int _quantity;

        public Invoice(int account, string customer, string provider)
        {
            _account = account;
            _customer = customer;
            _provider = provider;
        }

        public static Invoice CreateInvoice()
        {
            var account = ValidateAndParseIntRange("account", 0, 100_000);
            var customer = ParseString("customer");
            var provider = ParseString("provider");
            return new Invoice(account, customer, provider)
            {
                _article = ParseString("article"),
                _quantity = ValidateAndParseIntRange("quantity", 0, 100)
            };
        }

        private double WithVat(int percentage)
        {
            var result = _account*(1- percentage/100.0);
            result *= _quantity;
            return result;
        }
        private double WithoutVat()
        {
            return _account* _quantity;
        }

        public void printInfo()
        {
        Console.WriteLine($"Account: {_account}, Customer: {_customer}, Provider {_provider}, Article: {_article}, Quantity: {_quantity}");
        Console.WriteLine($"With vat: {WithVat(20)}, without vat: {WithoutVat()}");
        }
    }
}