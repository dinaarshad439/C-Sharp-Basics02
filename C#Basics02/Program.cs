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

            string Name = "clean code";
            string Name2 = "clean code";

            // Compare object references
            Console.WriteLine($"Did they Have the same address ? {object.ReferenceEquals(Name, Name2)}");

            #endregion



        }


    }
}
