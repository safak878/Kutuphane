using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Kutuphane.Entities;

namespace Kutuphane.Business.Dogrulamalar
{
   public class KitapValidator:AbstractValidator<Kitap>
    {
        public KitapValidator()
        {
            RuleFor(c => c.KitapKodu).NotEmpty().WithMessage("Kitap Kodu alanı boş geçilemez.");
            RuleFor(c => c.KitapAdi).NotEmpty().WithMessage("Kitap Adı alanı boş geçilemez.");
            RuleFor(c => c.YazarId).NotEmpty().WithMessage("Yazar Seçim alanı boş geçilemez.");
        }
    }
}
