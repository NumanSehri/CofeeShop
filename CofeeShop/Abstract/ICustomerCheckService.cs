using CofeeShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofeeShop.Abstract
{
    public interface ICustomercheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
