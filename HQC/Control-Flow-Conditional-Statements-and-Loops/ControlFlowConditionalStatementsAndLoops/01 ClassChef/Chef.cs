namespace _01_ClassChef
{
    using System;

    public class Chef
    {
        public void Cook()
        {
            Potato potato = GetPotato();
            Peel(potato);
            Cut(potato);

            Carrot carrot = GetCarrot();
            Peel(carrot);
            Cut(carrot);

            Bowl bowl = GetBowl();   
            bowl.AddIngredient(potato);
            bowl.AddIngredient(carrot);
            bowl.Cook();
        }

        private Bowl GetBowl()
        {
            return new Bowl(); 
        }

        private Potato GetPotato()
        {
            return new Potato();
        }

        private Carrot GetCarrot()
        {
            return new Carrot();
        }

        private void Peel(Vegetable vegetable)
        {
            vegetable.Peel();
        }

        private void Cut(Vegetable vegetable)
        {
            vegetable.Cut();
        } 
    }
}
