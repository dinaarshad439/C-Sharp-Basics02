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

            //Console.WriteLine("Enter the title : ");
            //string Title = Console.ReadLine();

            //switch (Title)
            //{
            //    case "Clean Code":
            //        Console.WriteLine("Great choice!");
            //        break;
            //    case "Refactoring":
            //        Console.WriteLine("Nice pick!");
            //        break;
            //    default:
            //        Console.WriteLine("Never heard of it");
            //        break;

            //}

            #endregion


            #region (Q11) Use the ternary operator to determine the book size

            //int Pages = 0;
            //bool isParsed = false;

            //do
            //{
            //    Console.WriteLine("Enter number of Pages :");
            //    isParsed = int.TryParse(Console.ReadLine(), out Pages);

            //} while (!isParsed);

            //string SizeLabel = Pages > 300 ? "Long Book" : "Short Book";

            //Console.WriteLine($"It is a {SizeLabel}");

            #endregion


            #region (Q12) Create a book array, get titles from the user, and print them using for loop

            //int NumberOfBooks = 0;
            //bool isParsed = false;

            //do
            //{
            //    Console.WriteLine("Enter the number of books:");
            //    isParsed = int.TryParse(Console.ReadLine(), out NumberOfBooks);

            //} while (!isParsed);

            //string[] Books = new string[NumberOfBooks];

            //Console.WriteLine("Enter the titles of books:");

            //for (int i = 0; i < Books.Length; i++)
            //{
            //    Books[i] = Console.ReadLine();
            //}

            //for (int i = 0; i < Books.Length; i++)
            //{
            //    Console.WriteLine($"Book : {i + 1}.{Books[i]}");

            //}

            #endregion


            #region (Q13) Print each book title using a while loop 

            //int j = 0;
            //while (j < Books.Length)
            //{
            //    Console.WriteLine($"Book : {j + 1}.{Books[j]}");
            //    j++;
            //}

            #endregion


            #region (Q14) Print the message exactly 3 times using a do-while loop

            //int i = 0;
            //do
            //{
            //    Console.WriteLine("Checking book......");
            //    i++;

            //} while (i < 3);

            #endregion


            #region (Q15) Print every book title using a foreach loop 
            //foreach (string Book in Books)
            //{
            //    Console.WriteLine($"Book : {Book}");
            //}

            #endregion


            #region (Q16) Use break to exit the loop when "Refactoring" is found

            //string[] Books = { "Clean code", "Refactoring", "The Pragmatic Programmer" };
            //for (int i = 0; i < Books.Length; i++)
            //{
            //    if (Books[i] == "Refactoring")
            //        break;
            //    Console.WriteLine($"Book : {i + 1}.{Books[i]}");

            //}

            #endregion


            #region (Q17) Skip "The Pragmatic Programmer" without stopping the loop

            //string[] Books = { "Clean code", "Refactoring", "The Pragmatic Programmer", "Clean architecture" };
            //for (int i = 0; i < Books.Length; i++)
            //{
            //    if (Books[i] == "The Pragmatic Programmer")
            //        continue;
            //    Console.WriteLine($"Book : {i + 1}.{Books[i]}");

            //}

            #endregion


            #region (Q18) Print the first book and exit early if the array is empty


            int NumberOfBooks = 0;
            bool isParsed = false;

            do
            {
                Console.WriteLine("Enter the number of books:");
                isParsed = int.TryParse(Console.ReadLine(), out NumberOfBooks);

            } while (!isParsed);

            string[] Books = new string[NumberOfBooks];

            if(NumberOfBooks!=0) Console.WriteLine("Enter the titles of books:");

            for (int i = 0; i < Books.Length; i++)
            {
                Books[i] = Console.ReadLine();
            }
            PrintFirstBook(Books);

            #endregion



        }

        /// <summary>
        /// Prints the first book in the array.
        /// Exits early if the array is empty.
        /// </summary>
        /// <param name="Books">The array of book titles.</param>
        static void PrintFirstBook(string[] Books)
        {
            if (Books.Length == 0)
                return;

            Console.WriteLine($"First book : {Books[0]}");
        }



    }
}
