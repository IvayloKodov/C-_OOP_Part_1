namespace Problem4.MordorCrueltyPlan.Foods
{
    public class FoodFactory
    {
        public static Food ProduceFood(string foodName)
        {
            switch (foodName.ToLower())
            {
                case "cram":
                    return new Cram();
                case "lembas":
                    return new Lembas();
                case "apple":
                    Food apple = new Apple();
                    return apple;
                case "melon":
                    return new Melon();
                case "honeycake":
                    return new HoneyCake();
                case "mushrooms":
                    return new Mushrooms();
                default:
                    return new Junk();
            }
        }
    }
}