string firstNumStr, secondNumStr, operatorStr;
float firstNum, secondNum;
char[] operators = { '+', '-', '/', '*' };
char operator_;
string exitChar = "x";

System.Console.WriteLine("To exit write x in first num");

while(true){
// reading 1st number and checking on it
do
{
    System.Console.Write("Enter first number: ");
    firstNumStr = Console.ReadLine() ?? "";
    if (firstNumStr.ToLower() == exitChar)
        return;
} while (!float.TryParse(firstNumStr, out firstNum));

// reading the operator and checking on it
do
{
    System.Console.Write("Enter the operator: ");
    operatorStr = Console.ReadLine() ?? "";
    char.TryParse(operatorStr, out operator_);
} while (!operators.Contains(operator_));

// reading 2nd number and checking on it
do
{
    System.Console.Write("Enter second number: ");
    secondNumStr = Console.ReadLine() ?? "";
} while (!float.TryParse(secondNumStr, out secondNum));

// printing the result
float result = operator_ switch
{
    '+' => firstNum + secondNum,
    '-' => firstNum - secondNum,
    '*' => firstNum * secondNum,
    '/' => secondNum != 0 ? firstNum / secondNum : throw new DivideByZeroException(),
    _ => throw new Exception("invalid operator")

};

System.Console.WriteLine($"{firstNum} {operator_} {secondNum} = {result}");

}
