using AvaloniaApplicationPracticeOne.Models;

namespace AvaloniaApplicationPracticeOne;

public class Service
{
    
    private static ShmatuhoContext? _db;

  
    public static ShmatuhoContext GetDbContext()
    {
        if (_db == null)
        {
            _db = new ShmatuhoContext();
        }
        return _db;
    }
}