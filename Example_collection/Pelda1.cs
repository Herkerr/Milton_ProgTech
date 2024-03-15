//C# Példa 1 – Dinamikus vs Statikus forráskód vetület
class Utlevel {
    bool ervenyes;
    public void SetErvenyesseg(bool ervenyes){
        this.ervenyes=ervenyes;
    }
    public string Valid(){
        if (ervenyes) return "Az útlevél érvényes";
        else return "Az útlevél érvényessége lejárt"
    }
}