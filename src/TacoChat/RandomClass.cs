using System;
using System.Collections.Generic;
using System.Text;

namespace TacoChat
{
    /// <summary>
    /// Random Class for to gather test coverage metrics
    /// </summary>
    public class RandomClass
    {
        private string _randomField;

        public RandomClass()
        {
            _randomField = nameof(RandomClass) + " now we're doing stuff " + DateTime.Now.Second;
        }

        public void DoSomeStuffToGatherCodeCoverage()
        {
            var number = new Random().Next(0, 100);

            Console.WriteLine("I generated a random number: " + number);

            if (DateTime.Now.Hour > 30)
            {
                Console.WriteLine("This will never happen" + _randomField);
            }
            else
            {
                Console.WriteLine("This will always happen");
            }
        }
    }
}
