//class Program
//{
//    delegate void MyDelegate(string message);
//    static void methodA(string message)
//    {
//        Console.WriteLine("method A " + message);
//    }
//    static void methodB(string message)
//    {
//        Console.WriteLine("method B " + message);
//    }

//    static void Main()
//    {
//        MyDelegate myDelegateA = new MyDelegate(methodA);
//        MyDelegate myDelegateB = new MyDelegate(methodB);

//        myDelegateA("shhs");
//        myDelegateB("askasdak");
//    }
//}


//class Program
//{
//    delegate void MyDelegate(int number);
//    static void Cubed(int number)
//    {
//        Console.WriteLine(number * number * number);
//    }

//    static void Main()
//    {
//        MyDelegate myDelegate = new MyDelegate(Cubed);


//        myDelegate(5);
//    }
//}


class Program
{
    delegate void CalculationDelegate(int number1, int number2);
    static void Add(int number1, int number2)
    {
        Console.WriteLine(number1 + number2);
    }
    static void Subtract(int number1, int number2)
    {
        Console.WriteLine(number1 - number2);
    }

    static void Main()
    {
        CalculationDelegate CalculatedAdd = new CalculationDelegate(Add);
        CalculationDelegate CalculatedSub = new CalculationDelegate(Subtract);

        Console.WriteLine("Enter number 1:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter number 2:");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("+ or -");
        string symbol = Console.ReadLine();

        if (symbol == "+")
        {
            CalculatedAdd(num1, num2);
        }

        if (symbol == "-")
        {
            CalculatedSub(num1, num2);
        }
    }
}