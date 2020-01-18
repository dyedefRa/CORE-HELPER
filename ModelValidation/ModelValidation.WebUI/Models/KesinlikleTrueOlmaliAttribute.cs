using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelValidation.WebUI.Models
{
    public class KesinlikleTrueOlmaliAttribute : Attribute, IModelValidator
    {
        public bool Gerekli => true;
        public string ErrorMesaji { get; set; } = "Kullanım koşullarını kabul etmelisiniz.!";
        public IEnumerable<ModelValidationResult> Validate(ModelValidationContext context)
        {//Kime attribu olarak bu sınıfı verirsek . context.Model ile ona ulaşırız.
            var value = context.Model as bool?;
            if (!value.HasValue || value==false)
            {
                return new List<ModelValidationResult>
                {
                    new ModelValidationResult("",ErrorMesaji)
                };
            }
            else
            {
                return Enumerable.Empty<ModelValidationResult>();
            }
        }
        //Bu sınıfı Register2 için kullanalım.
    }
}
