// See https://aka.ms/new-console-template for more information


Console.WriteLine("Hello, please provie a number.");

int x = int.Parse(Console.ReadLine());

Console.WriteLine("And one more number please.");

int y = int.Parse(Console.ReadLine());

static bool IsThesame(int x, int y)
{
    if(x == y)
    {
        return true;
    }
   
    return false;
}

IsThesame(x, y);


Console.WriteLine("Hello, please provie a number.");

double num1 = double.Parse(Console.ReadLine());

Console.WriteLine("And one more number please.");

double num2 = double.Parse(Console.ReadLine());

static double Subtract(double num1,double num2)
{
    double num3 = num1 - num2;
   
    return num3;
    
}

Subtract(num1,num2);



Console.WriteLine("Please input a number.");

int inputNumber = int.Parse(Console.ReadLine());


static string FindBuildingType(int inputNumber)
{
    string buildingString = "This is a";

    if (inputNumber < 3)
    {
        buildingString += " house!";

    }

    if (inputNumber >= 4 && inputNumber <= 10)
    {
        buildingString += "n office building";
    }
    if(inputNumber >10 && inputNumber < 50)
    {
        buildingString += " skyscraper!";
    }
    if(inputNumber >= 50)
    {
        buildingString += " SUPER skyscraper!";
    }

    
    return buildingString;

}

string outputString = FindBuildingType(inputNumber);

Console.WriteLine(outputString);