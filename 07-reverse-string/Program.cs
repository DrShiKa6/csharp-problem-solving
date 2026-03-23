string input, reversedString = "";


// take the string as input
System.Console.Write("Enter String to reverse: ");
input = Console.ReadLine() ?? "";
//System.Console.WriteLine(input.Length);

if (input.Length > 0)
{
    int inputLength = input.Length;
    for (int i = inputLength - 1; i >= 0; i--)
    {
        reversedString += input[i];
    }
    System.Console.WriteLine(reversedString);
}
