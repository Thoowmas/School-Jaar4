
using FacadePattern.Subsystems;

namespace FacadePattern.Facades;

public class HomeTheaterFacade
{
    private TV tv;
    private SoundSystem soundSystem;
    private DVDPlayer dvdPlayer;
    private MovieBox movieBox;

    public HomeTheaterFacade()
    {
        tv = new TV();
        soundSystem = new SoundSystem();
        dvdPlayer = new DVDPlayer();
        movieBox = new MovieBox();
    }

    public bool StartMovie(string movieName)
    {
        if (!movieBox.HasMovie(movieName)) return false;

        dvdPlayer.TurnOn(movieName);
        soundSystem.TurnOn();
        tv.TurnOn();
        return true;
    }

    public void StopMovie()
    {
        dvdPlayer.TurnOff();
        soundSystem.TurnOff();
        tv.TurnOff();
    }
}