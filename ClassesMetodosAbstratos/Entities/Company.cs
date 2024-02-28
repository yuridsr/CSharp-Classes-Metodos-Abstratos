using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMetodosAbstratos.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double anualIncome, int numberOfEmployees)
            : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double tax()
        {
            double totalTax = 0;

            if (NumberOfEmployees < 10)
            {
                totalTax = ((AnualIncome * 16)/100);
            }
            else 
            {
                totalTax = ((AnualIncome * 14)/100);
            }
            return totalTax;
        }
    }
}
