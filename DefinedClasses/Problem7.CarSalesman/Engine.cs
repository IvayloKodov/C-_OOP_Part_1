﻿namespace Problem7.CarSalesman
{
    public class Engine
    {
        public string model;
        public int power;
        public int displacement;
        public string efficiency;

        public Engine(string model, int power)
        {
            this.model = model;
            this.power = power;
        }
    }
}