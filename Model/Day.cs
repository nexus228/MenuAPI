namespace MenuAPI.Model
{
    public class Day
    {
        public required int Id { get; set; }

        public required string Name { get; set; }

        public Meal Meal { get; set; }
    }
}
