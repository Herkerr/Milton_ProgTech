// Java Példa 4 - Macska szolgáltatásai Java-ban
abstract class Macska {
    public abstract String dorombol();
    public abstract boolean eszikE();
}
class HaziMacska extends Macska {
    @Override
    public String dorombol() { return "Intense dorombolások"; }
    @Override
    public boolean eszikE() { return true; }
}

main() {
    HaziMacska h1 = new HaziMacska();
    Macska h2 = new HaziMacska();
}