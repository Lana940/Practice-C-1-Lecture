

// double Factorial (double n)
// {
//     if(n == 1) return 1; //почему 1, потому что 1! = 1  и 0! = 1
//     else return n * Factorial(n - 1);
// } 
// for (double i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }


// Фибоначчи
// f(1) = 1
// f(2) = 1
//f(n) - f(n-1) + f(n-2)

double Fibonacci(double n)
{
    if(n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

for (double i = 0; i < 50; i++)
{
    Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}