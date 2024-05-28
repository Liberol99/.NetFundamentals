using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Validators
{
    public class CustomerValidator : AbstractValidator<Customer> //Hangi sınıfın validator'ı olduğunu göstermek için o sınıfın AbstractValidator'ının inherit aldım 
    {
        //Fluent validation eklemeleri
        public CustomerValidator()
        {
            // İletişim adı (ContactName) doğrulama kuralları
            RuleFor(x => x.ContactName)
                .NotEmpty().WithMessage("Name cannot be empty")
                .Length(5, 100).WithMessage("Name length should be between 5 and 100 characters")
                .WithName("Customer Name");

            // Şirket adı (CompanyName) doğrulama kuralları
            RuleFor(x => x.CompanyName)
                .NotEmpty().WithMessage("Company name cannot be empty")
                .Length(5, 100).WithMessage("Company name length should be between 5 and 100 characters")
                .WithName("Customer Company Name");

            // Telefon (Phone) doğrulama kuralları
            RuleFor(x => x.Phone)
                .NotEmpty().WithMessage("Phone cannot be empty")
                .Matches(@"^0(\d{3}) (\d{3}) (\d{2}) (\d{2})$").WithMessage("Phone number format is not valid")
                .WithName("Customer Phone Number");

            // Adres (Address) doğrulama kuralları
            RuleFor(x => x.Address)
                .NotEmpty().WithMessage("Address cannot be empty")
                .WithName("Customer Address");
        }
    }
}
