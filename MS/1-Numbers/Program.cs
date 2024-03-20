Console.WriteLine("Hello, World!");
// WorkWithIntegers();
// OrderPrecedence();
// TestLimit();
// WorkWithDoubles();
// Decimal();

static void TestLimit()
{
    int max = int.MaxValue;
    int min = int.MinValue;
    Console.WriteLine($"The range of integers is {min} to {max}");
    int what = max + 3;
    Console.WriteLine($"An example of overflow: {what}");
    // Console.WriteLine($"An example of overflow: {max + 1}");
}

void WorkWithIntegers()
{
    int a = 18;
    int b = 6;
    int c;
    Console.WriteLine($"a+b={a + b}");

    Console.WriteLine($"a = {a}");
    Console.WriteLine($"b = {b}");
    // subtraction
    c = a - b;
    Console.WriteLine($"subtraction a-b={c}");

    // multiplication
    c = a * b;
    Console.WriteLine($"multiplication a*b={c}");

    // division
    c = a / b;
    Console.WriteLine($"division a/b={c}");
}

static void OrderPrecedence()
{
    int a = 5;
    int b = 4;
    int c = 2;
    int d = a + b * c;
    Console.WriteLine(d);

    d = (a + b) * c;
    Console.WriteLine(d);

    d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
    Console.WriteLine(d);

    int e = 7;
    int f = 4;
    int g = 3;
    int h = (e + f) / g;
    Console.WriteLine(h);
    Console.WriteLine((a + b) % c); // остаток от деления
}

static void WorkWithDoubles()
{
    // Числовой тип double представляет число с плавающей запятой двойной точности
    double a = 5;
    double b = 4;
    double c = 2;
    double d = (a + b) / c;
    Console.WriteLine(d);

    double e = 19;
    double f = 23;
    double g = 8;
    double h = (e + f) / g;
    Console.WriteLine(h);

    double max = double.MaxValue;
    double min = double.MinValue;
    Console.WriteLine($"The range of double is {min} to {max}");
    double third = 1.0 / 3.0;
    Console.WriteLine(third);
}
static void Decimal() {
// Тип decimal имеет меньший диапазон, но большую точность, чем double
decimal min = decimal.MinValue;
decimal max = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {min} to {max}");

double a = 1.0;
double b = 3.0;
Console.WriteLine(a / b);

decimal c = 1.0M;
decimal d = 3.0M;
Console.WriteLine(c / d);
}

// напишите код, который позволяет вычислить площадь круга с радиусом 2,50 см.
double r = 2.5; 
Console.WriteLine(Math.PI);
double square = r * r * Math.PI;
Console.WriteLine($"square = {square}");
