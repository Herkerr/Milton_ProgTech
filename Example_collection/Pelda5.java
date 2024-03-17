// Java Példa 5 - Implementációra programozás veszélye
class HaziAllat {
    double súly;
    String fajta;
    public HaziAllat(String fajta) {
        this.fajta = fajta;
        if (fajta == "Kutya") súly = 5.0;
        else if (fajta == "Macska") súly = 3.0;
        else súly = 1.0;
    }
}

// Java syntax helyes kód:
class HaziAllat {
    double súly;
    String fajta;
    public HaziAllat(String fajta) {
        this.fajta = fajta;
        if (fajta.equals("Kutya")) súly = 5.0;
        else if (fajta.equals("Macska")) súly = 3.0;
        else súly = 1.0;
    }
}

// Oltás osztály - HA felhaszbálom a fenti implementációt, akkor implementációs függőség alakul ki!
class Oltas {
    int alapPerKg = 3;
    public int getMiliLiter(HaziAllat x) {
        if (x.getFajta().equals("Kutya")) return alapPerKg * 5; // Csak addig jó a kód, amíg minden kutya 5.0 kg
        else (x.getFajta().equals("Macska")) return alapPerKg * 3;
        ...
    }
}