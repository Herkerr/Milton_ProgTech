// Java Példa 8 - GOF1 ismétlés és GOF2

// A) Öröklődéssel
class Gerinces { public String fut() { return "fut"; }}
class Kutya extends Gerinces {
    public String gyorsanFut() {
        return "gyorsan" + fut();   // Egyszerűen használjuk a fut metódust, mert megörökölte
    }
}
main () {
    Kutya k1 = new Kutya();
    String s = k1.gyorsanFut();     // s = "gyorsanfut 1"
}

// B) Objektum összetétellel
class Gerinces { public String fut() { return "fut"; }}
class Kutya {
    Gerinces g = new Gerinces();
    public String gyorsanFut() {
        return "gyorsan" + g.fut();   // Referencián keresztül használjuk a fut metódust, mert meghívhatom
    }
}
main () {
    Kutya k1 = new Kutya();
    String s = k1.gyorsanFut();     // s = "gyorsanfut 1" ugyanaz a kimenet
}