using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Patten
{
    public class UserRegistration
    {
        public UserRegistration()
        {

        }
        public string Name;
        public UserRegistration(string Name)
        {
            this.Name = Name;
        }
        public void Firstnamein(string Firstname)
        {
            Regex FirstNames = new Regex(@"^[A-Z][A-Za-z]{3,}$");
            try
            {
                if (FirstNames.IsMatch(Firstname))
                    Console.WriteLine(" Valid name..");
            }
            catch (UserRegistractionException ex)
            {
                throw new UserRegistractionException(UserRegistractionException.ExceptionType.Invalid, "invalid name...");
                Console.WriteLine(ex.Message);
            }
        }
        public void Lastenamein(string Lastname)
        {
            Regex LastNames = new Regex(@"^[A-z][A-Za-z]{3,}$");
            try
            {
                if (LastNames.IsMatch(Lastname))
                    Console.WriteLine(" Valid name..");
            }
            catch (UserRegistractionException ex)
            {
                throw new UserRegistractionException(UserRegistractionException.ExceptionType.Invalid, "invalid name...");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
