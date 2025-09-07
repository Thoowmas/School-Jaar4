using FacadePattern.Facades;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Which movie would you like to watch?");
var movie = Console.ReadLine();
HomeTheaterFacade homeTheaterFacade = new();
bool movieStarted = homeTheaterFacade.StartMovie(movie ?? "");

if (!movieStarted)
{
    Console.WriteLine("Sorry, that movie is not available.");
}
