int i2 = 0;

while (i2 == 0)
{
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
        i2 = 1;
    }

    else if (i1 == "-")
    {
        Console.WriteLine("The substracted value is " + (tall1 - tall2));
        i2 = 1;
    }
    else if (i1 == "*")
    {
        Console.WriteLine("The multiplied value is " + (tall1 * tall2));
        i2 = 1;
    }

    else if (i1 == "/")
    {
        Console.WriteLine("The diveded value is " + (tall1 / tall2));
        i2 = 1;
    }
    else
    {
        Console.WriteLine("Please choose your choice of sum, substraction, multiply or divination");
    }

    Console.WriteLine("Would you like to calculate more?");
    String i3 = Console.ReadLine();
    if (i3 == "Y" || i3 == "y" || i3 == "yes")
        i2 = 0;
    else
    {
        i2 = 1;
    }
    ;
}