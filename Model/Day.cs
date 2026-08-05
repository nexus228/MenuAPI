namespace MenuAPI.Model
{
    public class Day
    {
        public int Id { get; set; }

        public int MenuId { get; set; }

        public string Name { get; set; }

        public DateTime Date { get; set; }

        public IList<Meal>? Meal { get; set; }
    }
}
