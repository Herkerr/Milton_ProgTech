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

namespace PT_Feladat3_4_5
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Diagnostics;

    [TestClass]
    public class RegistrationFormTests
    {
        // First name teszt
        [TestMethod]
        public void FirstNameValidation()
        {
            // Arrange
            var registrationForm = new RegistrationForm();
            // Act
            var result = registrationForm.ValidateFirstName("Kovács");
            // Assert
            Assert.IsTrue(result);
        }
        // Last name teszt

        // Username teszt

        // E-mail teszt

        // Date of Birth teszt

        [TestMethod]
        public void TOSValidation()
        {
            var registrationForm = new RegistrationForm();
            var result = registrationForm.ValidateTOS(true);
            Assert.IsTrue(result);
        }
        // GDPR teszt
    }
}