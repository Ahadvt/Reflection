
internal class Piano : Instrument
{
    public string Pianoo { get; set; }
    public override void Sound()
    {
        Console.WriteLine("piano sound");
    }
}
