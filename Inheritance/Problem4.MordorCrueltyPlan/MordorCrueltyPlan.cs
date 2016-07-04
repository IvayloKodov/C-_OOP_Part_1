using System;
using System.Collections.Generic;
using Problem4.MordorCrueltyPlan.Foods;
using Problem4.MordorCrueltyPlan.Moods;

namespace Problem4.MordorCrueltyPlan
{
    public class MordorCrueltyPlan
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries);
            var allFoods = new List<Food>();
            for (int i = 0; i < input.Length; i++)
            {
            
                allFoods.Add(FoodFactory.ProduceFood(input[i]));
            }

            int points = 0;
            foreach (var food in allFoods)
            {
                points += food.GetHappinessPoints();
            }
            Console.WriteLine(points);

            Console.WriteLine(MoodFactory.CalculateMood(points));
        }
    }
}