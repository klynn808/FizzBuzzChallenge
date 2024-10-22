using System;

namespace FizzBuzzChallenge
{
    class Program
    {
        public string FizzWord(int number)
        {
            bool divisibleBy3 = number % 3 == 0;
            bool divisibleBy5 = number % 5 == 0;

            return (divisibleBy3 && divisibleBy5) ? "fizzbuzz" :
                (divisibleBy3) ? "fizz" :
                (divisibleBy5) ? "buzz" : number.ToString();
        }
    }
}
