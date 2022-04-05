using NUnit.Framework;
using Patten;
using System.Collections.Generic;
using System;
namespace UserRegisTesting
{
    public class Tests
    {
        UserRegistration userRegistration;

        [SetUp]
        public void Setup()
        {
            userRegistration = new UserRegistration();
        }

        [Test]
        public void FirstNameTesting()
        {
            string Firstname = "Mythili";
            userRegistration.Firstnamein(Firstname);
            Assert.AreEqual("Mythili", Firstname);
        }
        [Test]
        public void LastenameTesting()
        {
            string Lastname = "Annamalai";
            userRegistration.Lastenamein(Lastname);
            Assert.AreEqual("Annamalai", Lastname);
        }
        [Test]
        public void EmailTesting()
        {
            string Email = "mythili.abc@gmail.com";
            userRegistration.Emails(Email);
            Assert.AreEqual("mythili.abc@gmail.com", Email);
        }
        [Test]
        public void PhoneNumberTesting()
        {
            string PhoneNumber = "97 9790486506";
            userRegistration.PhoneNumbers(PhoneNumber);
            Assert.AreEqual("97 9790486506", PhoneNumber);
        }
        [Test]
        public void PasswordTesting()
        {
            string PassWord = "Z@1mythiliannamalai";
            userRegistration.PassWords(PassWord);
            Assert.AreEqual("Z@1mythiliannamalai", PassWord);
        }
        [Test]
        public void AllEmailTesting()
        {
            string Email = "mythili.abc@gmail.com";
            userRegistration.AllEmails(Email);
            Assert.AreEqual("mythili.abc@gmail.com", Email);
        }
    }
}