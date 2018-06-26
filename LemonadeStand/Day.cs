using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Day
    {
        Weather weather;
        List<Customer> customers;
        Random random;

        public Day()
        {
            weather = new Weather();
            random = new Random();

            AddCustomers();
        }

        private void AddCustomers()
        {
            int howManyCustomers = random.Next(75, 126);

            for (int i = 0; i < howManyCustomers; i++)
            {
                customers.Add(new Customer(weather));
            }
        }


    }
}
