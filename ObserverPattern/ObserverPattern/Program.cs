using ObserverPattern.ConcreteObserver;
using ObserverPattern.ConcreteSubject;
using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var sukhpinder = new Sukhpinder();

            var firstFan = new Follower();
            var secondFan = new Follower();

            sukhpinder.AddFollower(firstFan);
            sukhpinder.AddFollower(secondFan);

            sukhpinder.Post = "I love design patterns.";

            Console.Read();
        }
    }
}
