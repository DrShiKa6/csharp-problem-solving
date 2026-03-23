string? input;
int number;
do
{
    System.Console.Write("Enter postive integer: ");
    input = Console.ReadLine() ?? "";

} while (!(int.TryParse(input, out number) && number > 0));

for (int i = 1; i <= number; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
        System.Console.WriteLine("FizzBuzz");
    else if (i % 3 == 0)
        System.Console.WriteLine("Fizz");
    else if (i % 5 == 0)
        System.Console.WriteLine("Buzz");
    else
        System.Console.WriteLine(i);
}