using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractInterface
{
    public abstract class Bird : Animal
    {

    }

    public class Eagle : Bird
    {
        public override void Sleep()
        {
            Console.WriteLine("Sleep Eagle");
        }

        public override string Sound()
        {
            return $"Eagle sound";
        }


    }

    public abstract class Fish:Animal
    {


    }

    public class Shark : Fish
    {
        public override void Sleep()
        {
            Console.WriteLine("Sleep Shark");
        }

        public override  string Sound()
        {
            return $"Shark sound";
        }


    }

    public class Test : Animal,IRun
    {
        public void Run()
        {
            throw new NotImplementedException();
        }

        public override void Sleep()
        {
            throw new NotImplementedException();
        }
    }

}
