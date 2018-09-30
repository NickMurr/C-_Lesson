using System;

namespace Test_1 {
    class Program {
        static void Main (string[] args) {
            string characterName = "Mike";
            int characterAge = 18;
            Console.WriteLine ("There once was a man named " + characterName);
            Console.WriteLine ("And he was " + (characterAge + 8) + " years old");

            characterName = "John";
            Console.WriteLine (" ");
            Console.WriteLine ("He really like the name " + characterName);
            Console.WriteLine ("But didn't like been " + characterAge);
        }
    }
}