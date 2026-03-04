var calc = new Calc();
bool isrunning = true;

while (isrunning == true)
{
    Console.WriteLine("Input first if you want (+,-,*,/) and then2 numbers and we will give you the result");

    string i1 = Console.ReadLine();
    Console.WriteLine("Input your first number please :)");
    double tall1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Input your seccond number please :)");
    double tall2 = double.Parse(Console.ReadLine());
    var reply1 = "Your total after calculation is ";
    double result = 0;

    switch (i1)
    {
        case "+":
            result = calc.Addi(tall1, tall2);
            break;

        case "-":
            result = calc.Minu(tall1, tall2);
            break;

        case "*":
            result = calc.Multi(tall1, tall2);
            break;

        case "/":
            if (tall2 == 0)
            {
                Console.WriteLine("We cant divide a number by 0");
                continue;
            }
            result = calc.Divi(tall1, tall2);
            break;
    }
    Console.WriteLine($"{reply1} {result}");
    Console.WriteLine("Would you like to calculate more? Y/N");
    string i3 = Console.ReadLine();
    
    if (i3 == "y" || i3 == "y" || i3 == "yes" || i3 == "Yes")
    {
        isrunning = true;
    }
    else
    {
        isrunning = false;
        Console.WriteLine("I hope you found this useful");
    }

}


