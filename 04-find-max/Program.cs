System.Console.WriteLine("Enter array elements separated by comma ( , ): ");
int max = int.MinValue;
// read input and check for null, split by comma, convert them to int, store in array
string? input = Console.ReadLine();

if (!string.IsNullOrEmpty(input))
{
    int[] numbers = input.Split(',')
                    .Select(int.Parse)
                    .ToArray();

    // finding the max element then print it
    foreach (int num in numbers)
    {
        if (num > max)
            max=num;
    }
    System.Console.WriteLine($"The max element is {max}");
   
}
else
{
    // array is empty 
    System.Console.WriteLine("The array is empty");
}