double CalculateFormula(double a, double b, double c, double d)
{
    double numenator = a * b;
    double denomenator = c + d;
    double result = numenator / denomenator;
    return result;
}

double result = CalculateFormula(1.0, 2.0, 3.0, 4.0);
System.Console.WriteLine(result);


