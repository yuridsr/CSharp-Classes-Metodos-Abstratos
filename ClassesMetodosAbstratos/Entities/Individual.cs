using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMetodosAbstratos.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual()
        {

        }

        public Individual(string name, double anualIncome, double healthExpenditures)
            : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public sealed override double tax()
        {
            double totalTax = 0;

            if (AnualIncome < 20000)
            {
                totalTax = ((AnualIncome * 15) / 100) - ((HealthExpenditures * 50) / 100);
            }
            else if (AnualIncome >= 20000)
            {
                totalTax = ((AnualIncome * 25) / 100) - ((HealthExpenditures * 50) / 100);
            }

            return totalTax;
        }

    }
}
