Console.WriteLine("Hello!");
Console.WriteLine("Input the first number: ");


var firstAsText = Console.ReadLine();
var number1 = int.Parse(firstAsText);

Console.WriteLine("Input the second number:");

var secondAsText = Console.ReadLine();
var number2 = int.Parse(secondAsText);

Console.WriteLine("What do you want to do?");
Console.WriteLine("[A]dd numbers");
Console.WriteLine("[S]ubstract numbers");
Console.WriteLine("[M]ultiply numbers");

var choice = Console.ReadLine();

if(choice=="A" || choice=="a")
{
    var sum = number1 + number2;
    Console.WriteLine(number1 + "+" + number2 + "=" + sum);

}
else if (choice == "S" || choice == "s")
{
    var subst = number1 - number2;
    Console.WriteLine(number1 + "-" + number2 + "=" + subst);
}
else if (choice == "M" || choice == "M")
{
    var multi = number1 * number2;
    Console.WriteLine(number1 + "*" + number2 + "=" + multi);
}
