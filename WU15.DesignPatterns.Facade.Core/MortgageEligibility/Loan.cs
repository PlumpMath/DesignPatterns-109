﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WU15.DesignPatterns.Facade.Core.MortgageEligibility
{
    //Subsystem
    public class Loan
    {
        public bool HasNoBadLoans(Customer customer)
        {
            Console.WriteLine(
                "# Checking {0} {1} has any bad loans.",
                customer.FirstName,
                customer.LastName);

            return true;
        }
    }
}
