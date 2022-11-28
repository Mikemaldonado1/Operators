

//Console.WriteLine("Hello, World!");

{
    int a = 17;
    int b = 4;
    int quotient = a / b;
    int remainder = a % b;

    Console.WriteLine(a + b);
    Console.WriteLine(a - b);
    Console.WriteLine(a * b);
    Console.WriteLine(a / b);
    Console.WriteLine(a % b);
    Console.WriteLine();
    Console.WriteLine();

    Console.WriteLine($"17/4 is {quotient} remainder {remainder}");

    Console.WriteLine();
    Console.WriteLine();


   
    Console.WriteLine("What is the radius of your circle? ");
    var radius = double.Parse(Console.ReadLine());

    Console.WriteLine();
    Console.WriteLine();


    
    Double Answer = OperatorsRepo.AreaOfCircle.Area (radius);

    Console.WriteLine($"The area of a circle with radius of {radius} is {Answer}");

   

}