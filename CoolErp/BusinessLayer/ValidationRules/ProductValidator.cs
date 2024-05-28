using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Ürün adı boş geçilemez");
            RuleFor(x => x.ProductName).MaximumLength(50).WithMessage("Maksimum 50 karakter yazabilirsiniz");
            RuleFor(x => x.ProductName).MinimumLength(2).WithMessage("Minimum 2 karakter yazabilirsiniz");
            RuleFor(x => x.UnitPrice).NotEmpty().WithMessage("Ürün Fiyat boş geçilemez");
            RuleFor(x => x.UnitsInStock).NotEmpty().WithMessage("Ürün Stok boş geçilemez");

        }
    }
}
