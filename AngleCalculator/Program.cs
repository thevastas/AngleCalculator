AngleCalculator anglecalculator = new AngleCalculator();

Console.WriteLine("Enter the time in the following format: HH:mm (24H)");

string line = Console.ReadLine();
string[] words = line.Split(':');

try
{
    int angle = anglecalculator.CalculateAngle(Int16.Parse(words[0]), Int16.Parse(words[1]));
    Console.WriteLine($"The angle between the hour and the minute arrow:\t{angle,8:G} degrees");
}
catch (System.ArithmeticException)
{
    Console.WriteLine("The format of the time is invalid");
}
catch (System.FormatException)
{
    Console.WriteLine("The entered value is not a number");
}




