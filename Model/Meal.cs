namespace MenuAPI.Model
{
    public class Meal
    {
        public int Id { get; set; }

        public int DayId { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public MealIdentifier? Identifier { get; set; }
    }
}
