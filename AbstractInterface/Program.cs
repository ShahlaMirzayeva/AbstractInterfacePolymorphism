using System;

namespace AbstractInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Eagle eagle = new Eagle();
            Shark shark = new Shark();
            //eagle.Sleep();
            //shark.Sleep();

            Animal[] animal = { eagle, shark };




            foreach (var item in animal)
            {
                Console.WriteLine(item.Sound());
            }

            Eagle eagle1 = eagle;

        }
    }
}
