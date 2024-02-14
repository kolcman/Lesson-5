double CalculateFormula(int a, int b, int c, int d)
{
    // return ((a + b) / (c + d));
    double numenator = a + b;
    int denumenator = c + d;
    double result = numenator / denumenator;
    return result;
}

// System.Console.WriteLine(CalculateFormula(76, 4, 7, 6));
System.Console.WriteLine(CalculateFormula(3, 5, 7, 4));
