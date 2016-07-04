using System;
using System.Linq;

namespace Problem5.PizzaCalories
{
    public class PizzaCalories
    {
        public static void Main()
        {
            try
            {
                Pizza pizza = new Pizza();
                string input = Console.ReadLine();
                while (input != "END")
                {
                    string[] pizzaInfo = input.Split().ToArray();
                    switch (pizzaInfo[0])
                    {
                        case "Pizza":
                            pizza = CreateNewPizza(pizzaInfo, pizza);
                            break;
                        case "Dough":
                            pizza.Dough = CreateDough(pizzaInfo);
                            if (pizza.Name == null)
                            {
                                Console.WriteLine($"{pizza.Dough.CalculateCalories():F2}");
                            }
                            break;
                        case "Topping":
                            var topping = CreateTopping(pizzaInfo);
                            pizza.AddTopping(topping);
                            if (pizza.Name == null)
                            {
                                Console.WriteLine($"{topping.CalculateCalories():F2}");
                            }
                            break;
                    }
                    input = Console.ReadLine();
                }
                if (pizza.Name != null)
                {
                    Console.WriteLine(pizza);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static Pizza CreateNewPizza(string[] pizzaInfo, Pizza pizza)
        {
            string pizzaName = pizzaInfo[1];
            int pizzaToppings = int.Parse(pizzaInfo[2]);
            pizza = new Pizza(pizzaName, pizzaToppings);
            return pizza;
        }

        private static Topping CreateTopping(string[] pizzaInfo)
        {
            string toppingType = pizzaInfo[1];
            double toppingWeight = double.Parse(pizzaInfo[2]);
            Topping topping = new Topping(toppingType, toppingWeight);
            return topping;
        }

        private static Dough CreateDough(string[] pizzaInfo)
        {
            string doughType = pizzaInfo[1];
            string doughTechnique = pizzaInfo[2];
            double doughWeight = double.Parse(pizzaInfo[3]);
            Dough dough = new Dough(doughType, doughTechnique, doughWeight);
            return dough;
        }
    }
}