


Sword a = new Sword(GemStone.Amber,Material.Bronze,30,10);
Sword b = new Sword(GemStone.Empty, Material.Iron, 33, 15);
Sword c = new Sword(GemStone.Amber, Material.Bronze, 30, 10);

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);



public record Sword(GemStone gem,Material material,int length,int xGuardWidth);
public enum Material { Wood, Bronze, Iron, Steel, Binarium }
public enum GemStone { Empty, Emerald, Amber, Sapphire, Diamond, Bitstone, }