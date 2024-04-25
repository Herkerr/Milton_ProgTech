using System;

// Absztrakt alkatrész osztályok
public abstract class AbsztraktKijelzo {}
public abstract class AbsztraktAkkumulator {}
public abstract class AbsztraktPanel {}

// Absztrakt gyár osztály
public abstract class AbsztraktGyar
{
    public abstract AbsztraktKijelzo GyartKijelzo();
    public abstract AbsztraktAkkumulator GyartAkkumulator();
    public abstract AbsztraktPanel GyartPanel();
}

// Samsung kijelző osztály
public class SamsungKijelzo : AbsztraktKijelzo {}

// Samsung akkumulátor osztály
public class SamsungAkkumulator : AbsztraktAkkumulator {}

// Samsung panel osztály
public class SamsungPanel : AbsztraktPanel {}

// iPhone kijelző osztály
public class iPhoneKijelzo : AbsztraktKijelzo {}

// iPhone akkumulátor osztály
public class iPhoneAkkumulator : AbsztraktAkkumulator {}

// iPhone panel osztály
public class iPhonePanel : AbsztraktPanel {}

// Samsung gyár osztály
public class SamsungGyar : AbsztraktGyar
{
    public override AbsztraktKijelzo GyartKijelzo()
    {
        return new SamsungKijelzo();
    }

    public override AbsztraktAkkumulator GyartAkkumulator()
    {
        return new SamsungAkkumulator();
    }

    public override AbsztraktPanel GyartPanel()
    {
        return new SamsungPanel();
    }
}

// iPhone gyár osztály
public class iPhoneGyar : AbsztraktGyar
{
    public override AbsztraktKijelzo GyartKijelzo()
    {
        return new iPhoneKijelzo();
    }

    public override AbsztraktAkkumulator GyartAkkumulator()
    {
        return new iPhoneAkkumulator();
    }

    public override AbsztraktPanel GyartPanel()
    {
        return new iPhonePanel();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Samsung gyár létrehozása
        AbsztraktGyar samsungGyar = new SamsungGyar();

        // Samsung alkatrészek gyártása
        AbsztraktKijelzo samsungKijelzo = samsungGyar.GyartKijelzo();
        AbsztraktAkkumulator samsungAkkumulator = samsungGyar.GyartAkkumulator();
        AbsztraktPanel samsungPanel = samsungGyar.GyartPanel();

        // iPhone gyár létrehozása
        AbsztraktGyar iPhoneGyar = new iPhoneGyar();

        // iPhone alkatrészek gyártása
        AbsztraktKijelzo iPhoneKijelzo = iPhoneGyar.GyartKijelzo();
        AbsztraktAkkumulator iPhoneAkkumulator = iPhoneGyar.GyartAkkumulator();
        AbsztraktPanel iPhonePanel = iPhoneGyar.GyartPanel();
    }
}
