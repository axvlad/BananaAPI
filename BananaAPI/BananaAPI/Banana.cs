using System;

namespace BananaAPI
{
    public class Banana
    {
        public string name { get; set; }

        public string weight { get; set; }

        public int amount { get; set; }

        public Banana()
        {
            name = "Yellow banana";
            weight = "3 kilogram";
            amount = 15;
        }

        public override string ToString()
        {
            return $"name {name} weight {weight} amount {amount}";
        }

    }
}
