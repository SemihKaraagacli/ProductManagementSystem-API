using FluentValidation;
using ProductManagementManager.Models.Services.Product.Dtos;

namespace ProductManagementManager.Models.Services.Validators
{
    public class UpdateProductRequestValidator : AbstractValidator<UpdateRequest>
    {
        public UpdateProductRequestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim alanı boş olamaz.");
            RuleFor(x => x.Price).GreaterThan(0).WithMessage("Fiyat 0'dan büyük olmalıdır.");
            RuleFor(x => x.Stock).GreaterThan(0).WithMessage("Stok 0'dan büyük olmalıdır.");
            RuleFor(x => x.Explain).NotEmpty().WithMessage("Açıklama alanı boş olamaz.").MaximumLength(50).WithMessage("Açıklama en fazla 50 karakter olabilir.");
        }
    }
}
