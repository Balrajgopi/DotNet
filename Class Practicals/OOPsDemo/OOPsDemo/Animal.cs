using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDemo
{
    internal abstract class Animal
    {
        public abstract void MakeSound();

        public void Eat()
        {
            Console.WriteLine(" Animal is Eating......");
        }
    }

    internal class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine(" Dogs Bolo Bhauuuu Bhauuuuuuu Bhuuuuuuuuuuuuuu");
        }
    }

    internal class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine(" Tho Cat Boli Meowwwww Meowwww Meowwwwwwwwwwww");
        }
    }

    internal class TestAnimal
    {
        static void Main (string[]args)
        {
            //Animal MyDog = new Animal(); We Cant Create Object Of Abstract Class 
            Animal MyDog = new Dog();
            MyDog.MakeSound();

            Animal MyCat = new Cat();
            MyCat.MakeSound();

        }
    }
}
