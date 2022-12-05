
internal class Guitar : Instrument
{
    public string guitar { get; set; }
    public override void Sound()
    {
       
        Console.WriteLine("guitar sound");
    }
}
