System.Console.WriteLine("Enter array elements separated by comma ( , ): ");
int sum = 0;
float avg = 0;
// read input and check for null, split by comma, convert them to int, store in array
string? input = Console.ReadLine();

if (!string.IsNullOrEmpty(input))
{
    int[] numbers = input.Split(',')
                    .Select(int.Parse)
                    .ToArray();

    // print array elements and calculating the sum and avg
    Console.WriteLine("Array elements are:");
    foreach (int num in numbers)
    {
        Console.Write(num + " ");
        sum += num;
    }
    avg = (float)sum / numbers.Length;
}
else
{
    // if array is empty then sum = 0 and avg = 0
    sum = 0;
    avg = 0;
}

System.Console.WriteLine();
System.Console.WriteLine($"Sum of all elements = {sum}");
System.Console.WriteLine($"Average = {avg}");