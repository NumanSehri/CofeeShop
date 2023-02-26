using CofeeShop.Abstract;
using System;
using CofeeShop.Concrete;
using CofeeShop.Adaptars;

namespace CofeeShop
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Entities.Customer {DateOfBirth=new DateTime(1992,07,13),FirstName="Numan",LastName="ŞEHRİ",NationalityId="15472474532" });
        }
    }
}
