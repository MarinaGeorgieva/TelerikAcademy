namespace _01_ClassChef
{
    using System;
    using System.Collections.Generic;

    public class Bowl
    {
        public Bowl()
        {
            this.Ingredients = new List<Vegetable>();
        }

        public ICollection<Vegetable> Ingredients { get; set; }

        public void AddIngredient(Vegetable vegetable)
        {
            this.Ingredients.Add(vegetable);
        }

        public void Cook()
        {
            foreach (var ingredient in this.Ingredients)
            {
                ingredient.Cook();
            }
        }
    }
}
