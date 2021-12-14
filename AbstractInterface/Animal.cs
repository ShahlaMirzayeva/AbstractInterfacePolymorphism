using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractInterface
{
     public abstract class Animal
    {
        public string Foot { get; set; }

        public abstract void Sleep();

        public virtual string Sound()
        {
            return $"Animal Info";
        }

        public void Run()
        {
            Console.WriteLine("Animal run");
        }
    }
}
