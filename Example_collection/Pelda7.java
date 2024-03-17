// Java Példa 7 - GOF1 példák, szolgáltatások
abstract class Macska {
	public abstract String dorombol();
	public abstract boolean eszikE();
}
class HaziMacska extends Macska {
	public boolean alszikE() { return true; }
	@Override
	public boolean eszikE() { return true; }
	public String dorombol() { return "Intense dorombolások"; }
}
main() {
	HaziMacska h1 = new HaziMacska();
	Macska h2 = new HaziMacska();
    h1 = new KoborMacska();
	h2 = new KoborMacska();
}
