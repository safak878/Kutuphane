using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentValidation;
using Kutuphane.DataAccess.Arayuzler;

namespace Kutuphane.Business.Araclar
{
    public class DogrulamaAraci
    {
        public bool Dogrula(IValidator validator, IEntity entity)
        {
            bool sonuc = true;
            var dogrulamaKontrol = validator.Validate(entity);
            if (!dogrulamaKontrol.IsValid)
            {
                string mesaj = null;
                foreach (var error in dogrulamaKontrol.Errors)
                {
                    mesaj += error.ErrorMessage + "\n";
                }

                MessageBox.Show(mesaj);
                sonuc = false;
            }
            return sonuc;
        }
    }
}
