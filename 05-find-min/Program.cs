System.Console.WriteLine("Enter array elements separated by comma ( , ): ");
int min = int.MaxValue;
// read input and check for null, split by comma, convert them to int, store in array
string? input = Console.ReadLine();

if (!string.IsNullOrEmpty(input))
{
    int[] numbers = input.Split(',')
                    .Select(int.Parse)
                    .ToArray();

    // finding the min element then print it
    foreach (int num in numbers)
    {
        if (num < min)
            min = num;
    }
    System.Console.WriteLine($"The minimum element is {min}");

}
else
{
    // array is empty 
    System.Console.WriteLine("The array is empty");
}