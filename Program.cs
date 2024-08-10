using System;

namespace Operators
{
    #region ProgramClassRegion
    class OperatorsProgram
    {
        /// <summary>
        /// main method description
        /// </summary>
        /// <param name="args">args descritpion</param>
        public static void Main(string[] args) 
        {
            Console.WriteLine("Hi! In this leesin we talk about operators!");
            Console.WriteLine("*****************************");

            int result;
            int x = 10;
            int y = 20;

            result = (x + y);
            Console.WriteLine("Addition Operator: x + y = " + result);
            
            result = (x - y);
            Console.WriteLine("Substraction Operator: x - y = " + result);

            result = (x *y);
            Console.WriteLine("Multiplication Operator: x * y = " + result);

            result = (x / y);
            Console.WriteLine("Division Operator: x / y = " + result);

            result = (x % y);
            Console.WriteLine("Modulo Operator: x % y = " + result);

            Console.WriteLine("*****************************");

            int value1 = 10;
            int value2 = 10;

            Console.WriteLine("Pre-increment result: ");
            Console.WriteLine(++value1); //zwieksza sie od razu

            Console.WriteLine("Post-incerement result: ");
            Console.WriteLine(value2++);// zwieksza sie pozniej
            Console.WriteLine(value2);// trzeba wyswietlic

            Console.WriteLine("*****************************");
            bool boolResult;
            x = 2;
            y = 10;

            boolResult = (x == y);
            Console.WriteLine("Equal to Operator: (x == y) = " + boolResult);

            boolResult = (x > y);
            Console.WriteLine("Greater than Operator: (x > y) = " + boolResult);

            boolResult = (x < y);
            Console.WriteLine("Less than Operator: (x < y) = " + boolResult);

            boolResult = (x <= y);
            Console.WriteLine("Lesser than or Equal to: (x <= y) = " + boolResult);

            boolResult = (x >= y);
            Console.WriteLine("Greater than or Equal to: (x >= y) = " + boolResult);

            boolResult = (x != y);
            Console.WriteLine("Not Equal to Operator: (x != y) = " + boolResult);

            Console.WriteLine("*****************************");

            bool a = true; //typ logiczny
            bool b = false;

            boolResult = a && b; // oba sa true
            Console.WriteLine("AND Operator: a && b = " + boolResult);

            boolResult = a || b; //tru jesli jeden spelniony
            Console.WriteLine("OR Operator: a || b= " + boolResult);

            boolResult = !a; 
            Console.WriteLine("NOT Operator: !a = " + boolResult);

            /*
            This is a
            multiline comment
             */

            

            Console.WriteLine("*****************************");
            x = 5;
            y = 10;

            int greaterNumber = x > y ? x : y;
            Console.WriteLine("Ternary conditional operator: x > y ? x : y = " 
                + greaterNumber);
        }
    }
    #endregion
}