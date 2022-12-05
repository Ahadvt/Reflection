
using System.Reflection;

List<Instrument> instruments = new();

instruments.Add(new Piano{Brand="p Brand",Model="p model",Price=100 ,Pianoo="PIANOOOOs"});
instruments.Add(new Guitar{Brand="p Brand",Model="p model",Price=100,guitar="GUITAR" });

ShowInstrument(instruments);



static void ShowInstrument(List<Instrument> instruments)
{
    foreach (var item in instruments)
    {
        Console.WriteLine("class type");
        Console.WriteLine(item.GetType().Name);
        Console.WriteLine("  ");
        Console.WriteLine("properties");

       List<PropertyInfo> property= item.GetType().GetProperties().ToList();
        foreach (var item2 in property)
        {
            Console.WriteLine(item2.Name);

            Console.WriteLine(item2.GetValue(item));
        }
        Console.WriteLine("---------------------------------");
        Console.WriteLine("---------------------------------");
        Console.WriteLine("---------------------------------");
    }
}