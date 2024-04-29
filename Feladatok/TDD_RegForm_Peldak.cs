// Bemeneti érték: "szoveg"
public bool ValidateSzoveg(string szoveg)
{
    // Ellenőrzi, hogy nem üres és ellenőrzi, hogy csak kis- és nagybetűket tartalmaz.
    // True/False eredményt ad.
    // && -el tudunk több különböző kritériumot láncbafűzni.
    return !string.IsNullOrEmpty(szoveg) && szoveg.All(char.IsLetter);
}

// Csak alfanumerikus karaktereket fogad el.
szoveg.All(char.IsLetterOrDigit);

// Ellenőrzi a megadott (példában "#") karakter meglétét
szoveg.Contains("#");

// Definiáljuk a Date-et
// Majd megfeleltetjük a kritériumnak a formátumát.
DateTime date;
return DateTime.TryParseExact(szoveg, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out date);



// Bemeneti érték: True/False
public bool ValidateCheckbox(bool isAccepted)
{
    // Elfogadott checkbox értéket ad (A teszt ezt várja el).
    return isAccepted;
}