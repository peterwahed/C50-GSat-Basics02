using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Dynamic;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Timers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace fitst
{
    class Book
    {
        public string Title;
        public int Pages;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            //Create a Book class with a Title(string) and Pages(int).
            //Create a Book object and store it in a variable of type object.Print it.
            //object book = new Book();
            //Console.WriteLine(book);
            #endregion

            #region Question02
            //Using the Book class above, print the result of calling ToString(),
            //Equals() (compare book with itself), GetHashCode(), and GetType() on book.
            //Console.WriteLine(book.ToString());
            //Console.WriteLine(book.Equals(book));
            //Console.WriteLine(book.GetHashCode());
            //Console.WriteLine(book.GetType());
            #endregion

            #region Question03
            //Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.
            //int pages = "464";
            //Compile - time error — you can't put text (string) into an int variable.
            //int pages = 464;
            //int pages = 464;
            //int pages = "464";
            //Console.WriteLine(pages);
            //compile-time error
            #endregion

            #region Question04
            //Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by zero", and then prints "Done" in a finally block.
            //try
            //{
            //    int x = 10;
            //    int y = 0;
            //    int result = x / y;
            //}
            //catch
            //{
            //    Console.WriteLine("Cannot divide by zero ");
            //}
            //finally 
            //{
            //    Console.WriteLine("Done");
            //}

            #endregion

            #region Question05
            //Declare an int pages = 300; then store it in a double variable without using a cast.
            //int pages = 300;
            //double pagesDouble = pages;
            //Console.WriteLine(pagesDouble);
            #endregion

            #region Question06 
            //Declare a double price = 49.99; then convert it into an int using a cast.
            //double price = 49.99;
            //int x = (int)price;
            //Console.WriteLine(x);
            #endregion

            #region Question07
            //Given string pagesText = "464";, convert it into an int using the Convert class.
            //string PagesText = "464";
            //int x = Convert.ToInt32(PagesText);
            //Console.WriteLine(x);
            #endregion

            #region Question08
            //Given string yearText = "2023";, convert it using int.Parse().Then given string badText = "abc";
            //, use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.
            //string yearText = "2023";
            //int year = int.Parse(yearText);
            //Console.WriteLine(year);
            //string badText = "abc";
            //if (int.TryParse(badText, out int result))
            //{
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid number");
            //}
            #endregion

            #region Question09
            //Given int pages = 464;, convert it into a string using ToString() and print its type using GetType() to prove it's now a string.
            //int pages = 464;
            //string x = pages.ToString();
            //Console.WriteLine(x);
            //Console.WriteLine(x.GetType());
            #endregion

            #region Question10
            //Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int variable, and print both.
            //int copies = 100;
            //object newCopies = copies;
            //int new2Copies = (int)newCopies;
            //Console.WriteLine(copies);
            //Console.WriteLine(new2Copies);
            #endregion

     