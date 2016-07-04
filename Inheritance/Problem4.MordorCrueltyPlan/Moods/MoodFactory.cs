namespace Problem4.MordorCrueltyPlan.Moods
{
    public class MoodFactory
    {
        public static Mood CalculateMood(int happyPoints)
        {
            if (happyPoints < -5)
            {
                return new Angry();
            }
            else if (happyPoints <= 0)
            {
                return new Sad();
            }
            else if (happyPoints <= 15)
            {
                return new Happy();
            }
            else
            {
                return new JavaScript();
            }
        }
    }
}