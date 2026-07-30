namespace MenuAPI.Model
{
    public class Meal
    {
        public required string Name { get; set; }

        public required MealIdentifier Identifier { get; set; }
    }
}
