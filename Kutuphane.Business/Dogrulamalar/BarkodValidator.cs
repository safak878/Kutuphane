using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Kutuphane.Entities;

namespace Kutuphane.Business.Dogrulamalar
{
    public class BarkodValidator : AbstractValidator<Barkod>
    {
        public BarkodValidator()
        {
            RuleFor(c => c.Barkodu).NotEmpty().WithMessage("Barkodu alanı boş geçilemez.");
        }
    }
}
