using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InterfacePractice
{
    public interface IHuman
    {
        void eat();
        void sleep();
        void swim();
    }

    public interface IBird
    {
        void eat();
        void fly();
        void sleep();
    }

    
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.sleep();
        }
    }
}
