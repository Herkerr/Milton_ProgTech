/*
    A regisztrációs formunkban 7 mező fog szerepelni, ezeknek az értékeit kell majd validálnunk.

    A 7 mező és a követelményeik az alábbiak:
        - First name    | Csak kis- és nagybetűk - Erre megadtam példát.
        - Last name     | Csak kis- és nagybetűk
        - Username      | Csak alfanumerikus karakterek (kis/nagybetű és szám)
        - E-mail        | Alfanumerikus karakterek és tartalmazzon @-t, valamint pontot
        - TOS           | Checkbox, amit ellenőriznünk kell, hogy be van-e pipálva - Erre megadtam példát.
        - GDPR          | Checkbox, amit ellenőriznünk kell, hogy be van-e pipálva

    A jelen feladatban csak a TDD AAA részeit kell megírniuk.
    A teszt megvalósítás hiányában természetesen Piros lesz, de ez a TDD első lépése.
    Csak annyit írjanak a tesztbe, mellyel kiderül, hogy a mező jól van-e kitöltve, valid adatokkal.
    Egyelőre nem szükséges nem valid, rossz adatokra tesztet írni, csak a helyeset szimuláljuk, hogy később a kódunk elfogadja-e.
    A példákat NE módosítsák a beadott kódban.

    Tipp: Az ellenőrzés során boolean eredményeket fogunk alkalmazni a megvalósításban, tehát az Assert IsTrue-t alkalmazzon!
*/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using PT_Feladat3_4_5;
using Methods;

namespace PT_Feladat3_4_5
{
    class Program
    {
        static void Main()
        {

        }
    }


    [TestClass]
    public class RegistrationFormTests
    {
        [TestMethod]
        public void FirstNameValidation()
        {                        
            string firstname = "Péter";
            try
            {
                bool result = RegistrationForm.ValidateFirstName(firstname);
                Assert.IsTrue(result);
            }
            catch (AssertFailedException ex)
            {
                Debug.WriteLine($"RegistrationForm FirstNameValidation Unit Test FAIL: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"RegistrationForm FirstNameValidation Unit Test ERROR: {ex.Message}");
            }
        }
        [TestMethod]
        public void LastNameValidation()
        {            
            string lastname = "Kovács";
            try
            {
                bool result = RegistrationForm.ValidateLastName(lastname);
                Assert.IsTrue(result);
            }
            catch (AssertFailedException ex)
            {
                Debug.WriteLine($"RegistrationForm LastNameValidation Unit Test FAIL: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"RegistrationForm LastNameValidation Unit Test ERROR: {ex.Message}");
            }
        }
        [TestMethod]
        public void UserNameValidation()
        {            
            string username = "k_peter_19991231";
            try
            {
                bool result = RegistrationForm.ValidateUserName(username);
                Assert.IsTrue(result);
            }
            catch (AssertFailedException ex)
            {
                Debug.WriteLine($"RegistrationForm UserNameValidation Unit Test FAIL: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"RegistrationForm UserNameValidation Unit Test ERROR: {ex.Message}");
            }
        }
        [TestMethod]
        public void EmailValidation()
        {            
            string email = "k_peter@herkerr.hu";
            try
            {
                bool result = RegistrationForm.ValidateEmail(email);
                Assert.IsTrue(result);
            }
            catch (AssertFailedException ex)
            {
                Debug.WriteLine($"RegistrationForm EmailValidation Unit Test FAIL: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"RegistrationForm EmailValidation Unit Test ERROR: {ex.Message}");
            }
        }
        [TestMethod]
        public void BirthdayValidation()
        {            
            DateOnly birthday = new(1999, 12, 31);
            try
            {
                bool result = RegistrationForm.ValidateBirthday(birthday);
                Assert.IsTrue(result);
            }
            catch (AssertFailedException ex)
            {
                Debug.WriteLine($"RegistrationForm BirthdayValidation Unit Test FAIL: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"RegistrationForm BirthdayValidation Unit Test ERROR: {ex.Message}");
            }
        }

        [TestMethod]
        public void TOSValidation()
        {            
            bool TOS = true;
            try
            {
                bool result = RegistrationForm.ValidateTOS(TOS);
                Assert.IsTrue(result);
            }
            catch (AssertFailedException ex)
            {
                Debug.WriteLine($"RegistrationForm TOSValidation Unit Test FAIL: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"RegistrationForm TOSValidation Unit Test ERROR: {ex.Message}");
            }
        }
        [TestMethod]
        public void GDPRValidation()
        {            
            bool GDPR = true;
            try
            {
                bool result = RegistrationForm.ValidateGDPR(GDPR);
                Assert.IsTrue(result);
            }
            catch (AssertFailedException ex)
            {
                Debug.WriteLine($"RegistrationForm GDPRValidation Unit Test FAIL: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"RegistrationForm GDPRValidation Unit Test ERROR: {ex.Message}");
            }
        }
    }
}
namespace Methods
{ 
    public class RegistrationForm
    {
        /*********************************************************  
         **   Megfejtés, ha csak a kezdő karakter lehet nagy.   **
         *********************************************************
         
         
        public bool ValidateFirstName(string input)
        {
            
            bool result = true;
            if(!string.IsNullOrEmpty(input)) 
            {
                if (!char.IsUpper(input[0]))
                { result = false; }

                for (int i = 1; i < input.Length; i++)
                {
                    if (!char.IsLower(input[i]))
                    { result = false; break; }
                }
            }            
            return result;
        }
        */
        public static bool ValidateFirstName(string input)
        {
            return input.All(char.IsLetter) && !string.IsNullOrEmpty(input);
        }
        
        public static bool ValidateLastName(string input)
        {
            return ValidateFirstName(input);
        }
        public static bool ValidateUserName(string input)
        {
            return input.All(char.IsLetterOrDigit);
        }
        public static bool ValidateEmail(string input)
        {
            return input.Contains('@') && input.Contains('.') && input.All(char.IsLetterOrDigit);
        }
        public static bool ValidateBirthday(DateOnly input)
        {
            return input > DateOnly.MinValue && input < DateOnly.MaxValue;
        }
        public static bool ValidateTOS(bool input)
        {
            return input == true;
        }
        public static bool ValidateGDPR(bool input)
        {
            return input == true;
        }
    }
}
