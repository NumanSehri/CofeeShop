using CofeeShop.Abstract;
using CofeeShop.Entities;
using MernisServieReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofeeShop.Concrete
{
    public class CustomerCheckManager : ICustomercheckService
    {
       public bool CheckIfRealPerson(Customer customer)
        {
            return true;

        }
    }
}
