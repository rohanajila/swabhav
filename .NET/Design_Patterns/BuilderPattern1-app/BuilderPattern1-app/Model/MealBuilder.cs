using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern1_app.Model
{
    class MealBuilder
    {
        private Meal meal;
        public MealBuilder()
        {
            meal = new Meal();
        }

        public Meal PrepareVegMeal()
        {
            meal.EmptyItems();
            meal.AddItem(new VegBurger());
            meal.AddItem(new Coke());
            return meal;
           
        }
        public Meal PrepareNonVegMeal()
        {
            meal.EmptyItems();
            meal.AddItem(new ChickenBurger());
            meal.AddItem(new Coke());
            return meal;
            
        }
    }
}
