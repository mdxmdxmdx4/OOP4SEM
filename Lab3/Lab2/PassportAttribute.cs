using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab2
{
    public class PassportAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value is string passport)
            {
                if (passport.StartsWith("MP") || passport.StartsWith("AB") || passport.StartsWith("BM") || passport.StartsWith("HB")
                    || passport.StartsWith("KH") || passport.StartsWith("MC") || passport.StartsWith("KB")
                    || passport.StartsWith("PP") || passport.StartsWith("SP") || passport.StartsWith("DP"))
                {
                     Regex regex = new Regex(@"\w{2}[1-9]{7}");
                    if (regex.IsMatch(passport))
                    {
                        return true;
                    }
                }
            }
            ErrorMessage = "Некорректные паспортные данные";
            return false;

        }
    }
}
