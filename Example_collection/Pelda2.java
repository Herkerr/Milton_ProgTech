// Java Példa 2 - Encapsulation sértés
class Kutya {
    ArrayList<String> nevek = new ArrayList<>();
    public ArrayList<String> getNevek() { return nevek; }
}

// Példa program
main() {
    Kutya k1 = new Kutya();
    k1.getNevek().add("Bobikutya");
}
// Ez így ebben a formában sérti az Encapsulation alapelvét




// Javított példa
class Kutya {
    private ArrayList<String> nevek = new ArrayList<>();
    public void addNev(String név) { nevek.add(név); }
}

// Javított példa program
main() {
    Kutya k1 = new Kutya();
        k1.addNev("Bobbikutya");
}




// Szolgáltatás példa
class Kutya {
    private ArrayList<String> nevek = new ArrayList<>();
    public ArrayList<String> getNevek() { return nevek; }
    public void addNev(String név) {
        if (!név.equals("Adolf")) nevek.add(név);
        // Vizsgálat: Nem lehet a kutya neve Adolf.
    }
}

// Szolgáltatás példa program
main() {
    Kutya k1 = new Kutya();
        k1.getNevek().add("Adolf"); // Megszegi az egységbezárást, így kikerülheti a vizsgálatot.
        k1.addNev("Adolf"); // Nem szegi meg, ezért működési logika szerint el lesz utasítva.
}