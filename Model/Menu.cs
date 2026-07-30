using System.Collections;

namespace MenuAPI.Model
{
    public class Menu
    {
        public string Name { get; set; }

        public IList<Day> Days { get; set; }
    }
}
