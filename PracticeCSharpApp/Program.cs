using System;
using System.Collections.Generic;
using PracticeCSharp.StudyExtMethod;
using PracticeCSharp.StudyDelegate;

namespace PracticeCSharpApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            #region Test Extension Method


            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };

            List<int> result = numbers.Filter(x => x > 3);

            foreach (var i in result)
            {
                Console.WriteLine(i);
            }

            #endregion

            #region car is driven by different engine

            Car car = new Car();

            car.Run(() => new SolarEngine().Launch());
            car.Run(() => new AIEngine().Launch());

            car.RunByEngine(new SolarEngine());
            // doen't work, AIEngine is not derived from EngineBase
            //car.RunByEngine(new AIEngine());

            #endregion

        }
    }
}
