using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CofeeShop.Abstract;
using CofeeShop.Entities;
using MernisServieReference;

namespace CofeeShop.Adaptars
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(customer.NationalityId), customer.FirstName.ToUpper(),
                customer.LastName.ToUpper(), customer.DateOfBirth.Year);
        }
    }
}
