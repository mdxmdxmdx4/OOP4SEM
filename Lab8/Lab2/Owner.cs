using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    [Serializable]
    public class Owner
    {
        [Required(ErrorMessage = "Введите ФИО")]
        [RegularExpression(@"([А-я]){3,15}\s([А-я]){3,15}\s([А-я]){3,15}", ErrorMessage = "Неверный формат ФИО")]
        public string FIO { get; set;}
        public DateTime birthDate { get; set; }
        [Required(ErrorMessage = "Заполните поле с номером телефона")]
        public string phoneNumber { get; set; }
        public string wallet;

        [Required(ErrorMessage = "Введите Пасспортные данные")]
        [Passport]
        [StringLength(9)]
        public string PassportInfo { get; set; }
    }
}
