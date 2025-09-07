
namespace FacadePattern.Subsystems;

public class DVDPlayer
{
    public void TurnOn(string movieName)
    {
        Console.WriteLine($"DVD Player is now playing: {movieName}");
    }

    public void TurnOff()
    {
        Console.WriteLine("DVD Player turned off");
    }
}