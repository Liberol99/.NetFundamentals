using Bogus;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data
{
    public class FakeData
    {
        public static async Task Seed1()
        {
            Context context = new Context();
            var employeeFaker = new Faker<Employee>("en")
            .RuleFor(i => i.FirstName, i => i.Name.FirstName())
            .RuleFor(i => i.LastName, i => i.Name.LastName())
            .RuleFor(i => i.Mail, i => i.Person.Email)
            .RuleFor(i => i.Password, i => i.Finance.CreditCardCvv())
            .RuleFor(i => i.Image, i => i.Image.PicsumUrl())
            .RuleFor(i => i.Title, i => i.Person.Avatar)
            .RuleFor(i => i.BirthDate, i => i.Person.DateOfBirth)
            .RuleFor(i => i.Address, i => i.Address.FullAddress())
            .RuleFor(i => i.City, i => i.Address.City())
            .RuleFor(i => i.Region, i => i.Address.Country());

            List<Employee> employee = employeeFaker.Generate(20);

            if (!context.Employees.Any())
            {
                //context.Set<Employee>().AddRange(employee);
                //context.SaveChanges();
            }
        }

        public static async Task Seed2()
        {
            Context context = new Context();
            var bankFaker = new Faker<Bank>("en")
            .RuleFor(i => i.CustomerId, i => i.Finance.GetHashCode())
            .RuleFor(i => i.PaymentAmount, i => i.Finance.Amount())
            .RuleFor(i => i.NameOnCard, i => i.Finance.AccountName())
            .RuleFor(i => i.CardNumber, i => i.Finance.CreditCardNumber())
            .RuleFor(i => i.CVV, i => i.Finance.CreditCardCvv())
            .RuleFor(i => i.Expiration, i => i.Person.DateOfBirth.AddMonths(30/12));

            List<Bank> bank = bankFaker.Generate(10);

            if (!context.Banks.Any())
            {
                context.Set<Bank>().AddRange(bank);
                context.SaveChanges();
            }
        }
    }
}
