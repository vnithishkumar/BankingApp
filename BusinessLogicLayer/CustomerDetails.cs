using System;
using System.Collections.Generic;
using Banking.DataBase;


namespace Banking.Business
{
    public class CustomerDetails
    {
        public static string GetCustomerName(int customerId)
        {
            string name = FetchingData.GetCustomerName(customerId);

            return name;
        }
    }
}

