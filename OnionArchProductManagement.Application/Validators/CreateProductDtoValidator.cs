using FluentValidation;
using OnionArchProductManagement.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchProductManagement.Application.Validators
{
    public class CreateProductDtoValidator : AbstractValidator<CreateProductDto>
    {
        public CreateProductDtoValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("Ürün adı boş olamaz.")
                .MaximumLength(100).WithMessage("Ürün adı 100 karakterden uzun olamaz.");

            RuleFor(p => p.Price)
                .GreaterThan(0).WithMessage("Ürün fiyatı 0'dan büyük olmalıdır.");

            RuleFor(p => p.Stock)
                .GreaterThanOrEqualTo(0).WithMessage("Stok adedi eksi olamaz.");
        }
    }
}
