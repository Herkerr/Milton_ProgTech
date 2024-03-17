// Java Példa 6 - GOF1 felületre programozás
abstract class AbsHaziAllat {
    public abstract double getSúly();
    public abstract String getFajta();
    // Nem kell konstruktor, azt majd megcsinálja a child
}
// Oltás osztály - Felületre programozva
class Oltas {
    int alapPerKg = 3;
    public int getMiliLiter(AbsHaziAllat x) {
        return alapPerKg * x.getSúly();
    }
}