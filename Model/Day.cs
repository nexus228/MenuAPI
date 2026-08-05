namespace MenuAPI.Model
{
    public class Day
    {
        public required int Id { get; set; }

        public int MenuId { get; set; }

        public required string Name { get; set; }

        public required DateTime Date { get; set; }

        public IList<Meal>? Meal { get; set; }
    }
}
