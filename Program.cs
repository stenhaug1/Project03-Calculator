Console.WriteLine("Input first if you want (+,-,*,/) and then2 numbers and we will give you the result");

string i1 = Console.ReadLine();
Console.WriteLine(" you Have chosen " + i1);
Console.WriteLine("Input your first number please :)");
double tall1 = double.Parse(Console.ReadLine());
Console.WriteLine("Input your seccond number please :)");
double tall2 = double.Parse(Console.ReadLine());



if (i1 == "+")
{
    Console.WriteLine("The sum of the numbers are " + (tall1 + tall2));
}

else if (i1 == "-")
    Console.WriteLine("The substracted value is " + (tall1 - tall2));

else if (i1 == "*")
{
    Console.WriteLine("The multiplied value is " + (tall1 * tall2));
}

else if (i1 == "/")
{
    Console.WriteLine("The diveded value is " + (tall1 / tall2));
}
else
{
    Console.WriteLine("Please choose your choice of sum, substraction, multiply or divination");
}