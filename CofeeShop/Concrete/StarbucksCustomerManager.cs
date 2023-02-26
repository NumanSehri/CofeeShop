using CofeeShop.Abstract;
using CofeeShop.Adaptars;
using CofeeShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofeeShop.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
      private  ICustomercheckService _customercheckService; 

        public  StarbucksCustomerManager(ICustomercheckService customercheckService)
        {
            _customercheckService = customercheckService;
        }

        public StarbucksCustomerManager(MernisServiceAdapter mernisServiceAdapter)
        {
        }

        public override void Save(Customer customer)
        {
            if (_customercheckService.CheckIfRealPerson(customer))
            {
                
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a Valid Person");
            }
            
            
        }

      
    }
}
