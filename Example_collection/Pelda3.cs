// C# Példa 3 - Többalakúság
class Allat{}
class Gerinces:Allat{}
class Macska:Gerinces{}
class HaziMacska:Macska{}

HaziMacska h1 = new HaziMacska(); // Helyes egyszerű példa.

Macska m1 = new HaziMacska(); // Helyes példa az öröklődési lánc szerint.
HaziMacska h2 = new Macska(); // Ez nem helyes, mivel az öröklődési sorrend szerint a Macskának NINCS Házimacska típusa!

/* Java-ban:

class Allat extends Object{} // Nem kell kiírni, mert automatikus!
class Gerinces extends Allat{}
class Macska extends Gerinces{}
class HaziMacska extends Macska{}

HaziMacska h1 = new HaziMacska();

*/