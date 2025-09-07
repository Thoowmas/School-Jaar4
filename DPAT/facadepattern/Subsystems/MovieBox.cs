namespace FacadePattern.Subsystems;

public class MovieBox
{
    private string[] _movies;

    public MovieBox()
    {
        _movies = ["Star Wars", "Hungergames", "Mazerunner", "Mandalorian", "Interstellar"];
    }

    public bool HasMovie(string movieName)
    {
        foreach (var movie in _movies)
        {
            if (movie.Equals(movieName, StringComparison.OrdinalIgnoreCase)) return true;
        }
        return false;
    }
}