
internal abstract class Instrument
{
    public string Model { get; set; }
    public string Brand { get; set; }
    public int Price { get; set; }

    public abstract void Sound();
}
