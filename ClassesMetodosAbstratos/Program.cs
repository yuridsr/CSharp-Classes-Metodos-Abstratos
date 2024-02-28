using ClassesMetodosAbstratos.Entities;
using System.Collections.Generic;
using System.Xml.Schema;
using System.Globalization;

namespace program
{
    class program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            List<TaxPayer> listOfTaxpayer = new List<TaxPayer>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string nameTaxPayer = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncomeTaxPayer = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i' || ch == 'I')
                {
                    Console.Write("Health expenditures: ");
                    double healthexpendituresTaxPayer = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listOfTaxpayer.Add(new Individual(nameTaxPayer, anualIncomeTaxPayer, healthexpendituresTaxPayer));

                }
                else if (ch == 'c' || ch == 'C')
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployeesTaxPayer = int.Parse(Console.ReadLine());
                    listOfTaxpayer.Add(new Company(nameTaxPayer, anualIncomeTaxPayer, numberOfEmployeesTaxPayer));
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Taxes PAID");
            foreach (TaxPayer obj in listOfTaxpayer)
            {
                Console.WriteLine(obj);
            }

            double totalTaxes = 0;
            foreach (TaxPayer obj in listOfTaxpayer)
            {
                totalTaxes += obj.tax();
            }

            Console.WriteLine("");
            Console.Write("Total Taxes: $ {0}", totalTaxes.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("");
        }
    }
}