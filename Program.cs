var calc = new Calc();
bool isrunning = true;
string reply1 = "Your total after calculations are ";

while (isrunning == true)
{

    Console.WriteLine("What calculation method would you like to use? (+, - , * , / )");
    string i1 = Console.ReadLine();
    Console.WriteLine("Input your first number please");
    double tall1 = double.Parse(Console.ReadLine());
    Console.WriteLine("input your second number please");
    double tall2 = double.Parse(Console.ReadLine());
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

    if (i3 == "y" || i3 == "Y" || i3 == "yes" || i3 == "Yes")
    {
        isrunning = true;
    }
    else
    {
        isrunning = false;
        Console.WriteLine("I hope you found this useful");
    }

}


