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

            StringBuilder sb = new StringBuilder();

            sb.Append("Book List");
            sb.Append(" - Updated");

            Console.WriteLine($"The result before replacing is : {sb}");

            sb.Replace("Book List", "Library");

            Console.WriteLine($"The Updated result after replacing is : {sb}");


            #endregion





        }


    }
}
