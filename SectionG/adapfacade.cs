using System;

//Adapter Pattern
class DVD
{
    public void OldConnect() => Console.WriteLine("DVD connected via old AV port");
}

interface IHDMI
{
    void Connect();
}
class DVDAdapter : IHDMI
{
    private DVD dvd;
    public DVDAdapter(DVD d) => dvd = d;

    public void Connect()
    {
        Console.WriteLine("Converting AV to HDMI");
        dvd.OldConnect();
        Console.WriteLine("DVD ready on HDMI TV");
    }
}
//facade Pattern
class TV { 
    public void On() => Console.WriteLine("TV ON"); 
}
class Sound { 
    public void On() => Console.WriteLine("Sound on"); 
}
class Light { 
    public void Dim() => Console.WriteLine("Lights dimmed"); 
}

class Theater
{
    private TV tv = new TV();
    private Sound sound = new Sound();
    private Light light = new Light();
    private IHDMI dvdAdapter;
    public Theater(IHDMI adapter) => dvdAdapter = adapter;
    public void Watch()
    {
        Console.WriteLine("Starting home theater");
        light.Dim();
        tv.On();
        sound.On();
        dvdAdapter.Connect();
        Console.WriteLine("Enjoy the movie");
    }
}

class Program
{
    static void Main()
    {
        DVD oldDVD = new DVD();
        IHDMI adapter = new DVDAdapter(oldDVD);
        Theater theater = new Theater(adapter);
        theater.Watch();
    }
}
