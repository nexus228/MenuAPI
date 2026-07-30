using System.Collections;

namespace MenuAPI.Model
{
    public class Menu
    {
        public int ID { get; set; }

        public string? Name { get; set; }

        public DateTime StartDate { get; set; }

        public IList<Day>? Days { get; set; }
    }
}
