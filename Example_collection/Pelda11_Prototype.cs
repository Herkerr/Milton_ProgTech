class Ember
{
    private String név; // Emberünk neve
    private Ember[] barátok; // Array a Barátok referenciáinak tárolására

    // Deep Copy példa
    public Ember DeepCopy()
    {
        Ember clone = new Ember(); // Új Ember Objektum
        clone.név = név; // Eredeti Objektumból név másolása
        clone.barátok = (Ember[])barátok.Clone(); // Új Array a Barátok referenciáinak tárolására és eredeti másolása
        return clone;
    }

    // Shallow Copy példa
    public Ember ShallowCopy()
    {
        Ember clone = new Ember(); // Új Ember Objektum
        clone.név = név; // Eredeti Objektumból név másolása
        clone.barátok = barátok; // Barátok Array referencia hozzáadása (NINCS MÁSOLÁS)
        return clone;
    }

    // MemberwiseClone metódus
    public Ember ShallowCopy2()
    {
        return (Ember)MemberwiseClone(); // Használhatjuk a MemberwiseClone-t is Shallow Copy-hoz
    }
}