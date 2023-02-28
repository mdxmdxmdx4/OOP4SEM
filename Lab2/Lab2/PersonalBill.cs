using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lab2
{
    [Serializable]
    public class PersonalBill
    {
        public Owner owner = new Lab2.Owner();
        public DateTime sendDate;
        public string services = "";
        public int startBalance = 0;
        public string town;
        Random r = new Random();
        public override string ToString()
        {
            return $"Счёт #{r.Next(10000, 10000000)}, валюта - {this.owner.wallet}\n" +
                $"Владелец: {this.owner.FIO}\n" +
                $"Дата рождения {this.owner.birthDate.Date}\n" +
                $"Контакты: +{this.owner.phoneNumber}\n" +
                $"Начальный баланс = {this.startBalance}";
        }
    }
}
