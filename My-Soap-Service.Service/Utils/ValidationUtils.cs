using System.Text.RegularExpressions;

namespace My_Soap_Service.Service.Utils
{
    namespace CpfCnpj
    {
        public static class ValidationUtils
        {
            private const int CpfLength = 11;
            private const int CnpjLength = 14;
            private const string EmailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            public static bool IsValidEmail(string email)
            {
                return Regex.IsMatch(email, EmailPattern);
            }

            public static bool IsValidCpf(string cpf)
            {
                var fMultiplier = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                var sMultiplier = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

                var unformattedCpf = StringUtils.Unformat(cpf);

                if (unformattedCpf.Length != CpfLength)
                {
                    return false;
                }

                for (int i = 0; i < 10; i++)
                {
                    var numStr = i.ToString();
                    var falsePositive = numStr.PadLeft(CpfLength, char.Parse(numStr));

                    if (unformattedCpf == falsePositive)
                    {
                        return false;
                    }
                }

                var tempCpf = unformattedCpf.Substring(0, 9);
                
                var sum = 0;

                for (int i = 0; i < fMultiplier.Length; i++)
                {
                    var currentDigit = tempCpf[i].ToString();
                    sum += int.Parse(currentDigit) * fMultiplier[i];
                }

                var rest = sum % 11;

                rest = rest < 2
                    ? 0
                    : 11 - rest;

                var finalDigits = rest.ToString();

                tempCpf += finalDigits;

                sum = 0;

                for (int i = 0; i < sMultiplier.Length; i++)
                {
                    var currentDigit = tempCpf[i].ToString();
                    sum += int.Parse(currentDigit) * sMultiplier[i];
                }

                rest = sum % 11;

                rest = rest < 2
                    ? 0
                    : 11 - rest;

                finalDigits += rest.ToString();

                return unformattedCpf.EndsWith(finalDigits);
            }

            public static bool IsValidCnpj(string cnpj)
            {
                var fMultiplier = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                var sMultiplier = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

                var unformattedCnpj = StringUtils.Unformat(cnpj);

                if (unformattedCnpj.Length != CnpjLength)
                {
                    return false;
                }

                var tempCnpj = unformattedCnpj.Substring(0, 12);
                
                var sum = 0;

                for (int i = 0; i < fMultiplier.Length; i++)
                {
                    var currentDigit = tempCnpj[i].ToString();
                    sum += int.Parse(currentDigit) * fMultiplier[i];
                }

                var rest = sum % 11;

                rest = rest < 2
                    ? 0
                    : 11 - rest;

                var finalDigits = rest.ToString();

                tempCnpj += finalDigits;

                sum = 0;
                
                for (int i = 0; i < sMultiplier.Length; i++)
                {
                    var currentDigit = tempCnpj[i].ToString();
                    sum += int.Parse(currentDigit) * sMultiplier[i];
                }

                rest = sum % 11;

                rest = rest < 2 
                    ? 0 
                    : 11 - rest;

                finalDigits += rest.ToString();

                return unformattedCnpj.EndsWith(finalDigits);
            }
        }
    }
}
