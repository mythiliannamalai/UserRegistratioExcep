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
    }
}