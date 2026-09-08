using System.Text;

namespace C_Basics02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region (Q1)  Convert the title to uppercase and store it in a new variable

            //Console.WriteLine("Enter the Title : ");

            //string Title = Console.ReadLine();

            //string UpperTitle = Title.ToUpper();

            //Console.WriteLine($"Title : {Title}");
            //Console.WriteLine($"Upper Title : {UpperTitle}");


            #endregion


            #region (Q2)  Check if both strings reference have the same object in memory

            //string Name = "clean code";
            //string Name2 = "clean code";

            //// Compare object references
            //Console.WriteLine($"Did they Have the same address ? {object.ReferenceEquals(Name, Name2)}");

            #endregion


            #region (Q3) Modify the same StringBuilder object using multiple Append() calls

            //// StringBuilder is mutable, so the same object can be modified.
            //StringBuilder sb = new StringBuilder();

            //sb.Append("Book List");
            //Console.WriteLine($"Hash code after first append : {sb.GetHashCode()}");

            //sb.Append(" - Updated");
            //Console.WriteLine($"Hash code after second append : {sb.GetHashCode()}");


            //Console.WriteLine($"The final result is : {sb}");

            #endregion


            #region (Q4) Modify the existing StringBuilder by replacing specific text

            //StringBuilder sb = new StringBuilder();

            //sb.Append("Book List");
            //sb.Append(" - Updated");

            //Console.WriteLine($"The result before replacing is : {sb}");

            //sb.Replace("Book List", "Library");

            //Console.WriteLine($"The Updated result after replacing is : {sb}");


            #endregion


            #region (Q5) Building the book sentence using the + operator

            //Console.WriteLine("Enter Title : ");
            //string Title = Console.ReadLine();
            //int Pages = 0;
            //bool result = false;

            //// Making the user enter Validate Page input
            //do
            //{
            //    Console.WriteLine("Enter Number of Pages : ");
            //    result = int.TryParse(Console.ReadLine(), out Pages);

            //} while (!result);

            //string Message = "Book: " + Title + "," + " Pages: " + Pages;
            //Console.WriteLine(Message);

            #endregion


            #region (Q6) Building the book sentence using Interpolation

            //string Message2 = $"Book: {Title},Pages: {Pages}";
            //Console.WriteLine(Message2);

            #endregion


            #region (Q7) Building the book sentence using string.Format

            //string Message3 = string.Format("Book: {0}, Pages: {1}", Title, Pages);
            //Console.WriteLine(Message3);

            #endregion


            #region (Q8) Use if/else to classify the book based on the number of pages

            //int Pages = 0;
            //bool Result = false;

            //// Making the user enter Validate Page input
            //do
            //{
            //    Console.WriteLine("Enter number of Pages: ");
            //    Result = int.TryParse(Console.ReadLine(), out Pages);

            //} while (!Result);

            //// Condition to classify the book
            //if (Pages > 300)
            //{
            //    Console.WriteLine("Long Book");
            //}
            //else
            //{
            //    Console.WriteLine("Short Book");
            //}

            #endregion


            #region (Q9) Check if the book has more than 300 pages and is available

            //int Pages = 0;
            //bool Result = false;
            //bool isAvailable = true;

            //// Making the user enter Validate Page input
            //do
            //{
            //    Console.WriteLine("Enter number of Pages: ");
            //    Result = int.TryParse(Console.ReadLine(), out Pages);

            //} while (!Result);

            //// Check if the book has more than 300 pages and is available
            //if (Pages > 300 && isAvailable)
            //{
            //    Console.WriteLine("You can borrow this book");
            //}
            //else
            //{
            //    Console.WriteLine("The book is not found");
            //}


            #endregion


            #region (Q10) Use switch to handle different book titles

            Console.WriteLine("Enter the title : ");
            string Title = Console.ReadLine();

            switch (Title)
            {
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;
                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;
                default:
                    Console.WriteLine("Never heard of it");
                    break;

            }

            #endregion











        }


    }
}
