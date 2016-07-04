namespace Problem4.MordorCrueltyPlan.Foods
{
    public abstract class Food
    {
        protected int points;

        public Food(int points)
        {
            this.points = points;
        }

        public int GetHappinessPoints()
        {
            return this.points;
        }
    }
}