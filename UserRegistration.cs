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
        public void Emails(string Email)
        {
            Regex EmailReg = new Regex(@"^[a-z](.[a-z])+@[a-z]+.[a-z]{3}(.[a-z]{2})$");
            try
            {
                if (EmailReg.IsMatch(Email))
                    Console.WriteLine(" Valid Email..");
            }
            catch (UserRegistractionException ex)
            {
                throw new UserRegistractionException(UserRegistractionException.ExceptionType.Invalid, "invalid Email...");
                Console.WriteLine(ex.Message);
            }
        }
        public void PhoneNumbers(string PhoneNumber)
        {
            Regex PhoneNumberReg = new Regex(@"^[0-9]{2}\s[0-9]{10}$");
            try
            {
                if (PhoneNumberReg.IsMatch(PhoneNumber))
                    Console.WriteLine(" Valid Phone number..");
            }
            catch (UserRegistractionException ex)
            {
                throw new UserRegistractionException(UserRegistractionException.ExceptionType.Invalid, "invalid PhoneNummber...");
                Console.WriteLine(ex.Message);
            }
        }
        public void PassWords(string PassWord)
        {
            Regex PassWordReg = new Regex(@"^[A-Z]@[0-9][A-Za-z]{8,}$");
            try
            {
                if (PassWordReg.IsMatch(PassWord))
                    Console.WriteLine(" Valid Password..");
            }
            catch (UserRegistractionException ex)
            {
                throw new UserRegistractionException(UserRegistractionException.ExceptionType.Invalid, "invalid Password...");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
