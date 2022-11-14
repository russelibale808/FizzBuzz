

    //Write a public method that accepts a number (DONE)

static string FizzBuzz(int number)
{
    //when the number is divisible by 3 return the word fizz (DONE)

    string answer = "";

    if (number % 3 == 0)
    {
        answer = "fizz";
    }

    //when the number is divisible by 5 return the word buzz (DONE)

    if (number % 5 == 0)
    {
        answer = "buzz";
    }

    //when the number is divisible by both, return the word fizzbuzz (DONE)

    if (number % 3 == 0 && number % 5 == 0)
    {
        answer = "fizz" + "buzz";
    }

    return answer;
}
Console.WriteLine($"{FizzBuzz(3)}");

Console.WriteLine($"{FizzBuzz(5)}");

Console.WriteLine($"{FizzBuzz(15)}");

