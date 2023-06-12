using System;
using System.Linq.Expressions;

internal class Program
    {
        static void Main(string[] args)
        {
        //Expetions are when something goes wrong with your code.
        //We are making a programs that takes a number, and takes another number and then divides tht two.

        //Console.WriteLine("Pick a number:");
        //int numberOne = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Pick a second number:");
        //int numberTwo = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Dividing the two ...");
        //int numberThree = numberOne / numberTwo;
        //Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
        //Console.ReadLine();

                                        //When We do exception handling, we do that by using "try" "catch" block.

        try                                                         //In order to handle exceptions, the code is written inside the try and actually it says try this code.
        {
            Console.WriteLine("Pick a number:");                    //Asks the user for an int input.
            int numberOne = Convert.ToInt32(Console.ReadLine());    //Usually the user input is stored as string data type so this statement casts that to int32.
            Console.WriteLine("Pick a second number:");             //Asks te user for input for second time.
            int numberTwo = Convert.ToInt32(Console.ReadLine());    //Casts the string data type to int32.
            Console.WriteLine("Dividing the two ...");              //Prints to the console.
            int numberThree = numberOne / numberTwo;                //Do the math operaton based on user's input.
            Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);   //This statement concatenates.
            Console.ReadLine();                                                                     //Keeps the console open.
        }
        catch (FormatException ex)                      //Catches the exceptions.
        {
            Console.WriteLine(ex.Message);              //Writes the message to the console.
        }                                               //Note: Instead of this automatic generated message we can write our own message, as follows:
        //Console.WriteLine("Please write the number");
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);              //We can write as many catches and display message as we want.
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);              //The "Exception" is for any and general exceptions. We can also customize our exception handling as above.
        }
        finally         
        /*If the try executes perfectly, and there is not exception, the "finally" will still run. Also, if the try executes and there is some exceptions,
        the finally will stil. The purpose is when the program catch something everything stops working, */
        {
            Console.ReadLine();  
        }
        Console.ReadLine();                             //Keeps the console open.
        }
    }




