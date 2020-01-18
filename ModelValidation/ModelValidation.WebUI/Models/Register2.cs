using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ModelValidation.WebUI.Models
{
    public class Register2
    {
        [Required]//Varsayılan required mesajı gelecek (Startupta tanıttık)
        [Display(Name = "Kullanıcı Adı")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Email alanı doldurmak zorunludur.")]//Default required mesajını ezebilirsin.
        [RegularExpression(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?",ErrorMessage ="Email Formatı yanlış")]
        public string Email { get; set; }
        [Required]
        [StringLength(8,ErrorMessage ="Parola Max 8, Min 6  Karakter Olmalıdır",MinimumLength =6)]
        public string Password { get; set; }
        [Required]
        [Compare(nameof(Password), ErrorMessage = "Parolalar uyuşmuyor")]
        public string RePassword { get; set; }
        [UIHint("Date")]//BirthDate in datesi lazım sadece
        public DateTime BirthDate { get; set; }//Bunlara required yazmaya gerek yok Nullable degıl

        //[Range(typeof(bool), "true", "true", ErrorMessage = "Kabul etmelisiniz")]
        [KesinlikleTrueOlmali()]
        public bool TermsAccepted { get; set; }
        //Kullanım koşullarını kabul etme
    }
}
