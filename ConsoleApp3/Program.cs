using AbstractDemo.Abstract;
using AbstractDemo.Adapters;
using AbstractDemo.Concrete;
using AbstractDemo.Entity;

BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
customerManager.Save(new Customer() { Id = 1, FirstName = "Fatih", LastName = "Aydın", NationalityId = "35873180016", DateOfBirth = new DateTime(2000, 11, 11) });
Console.ReadLine();