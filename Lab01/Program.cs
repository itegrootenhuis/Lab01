using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Program
    {
        public static string roomLength;
        public static string roomWidth;

        static void Main(string[] args)
        {
            GetUserInputs();
        }

        private static void GetUserInputs()
        {
            Console.WriteLine("Please enter in the length of your room: ");
            roomLength = Console.ReadLine();
            Console.WriteLine("Please enter in the width of your room: ");
            roomWidth = Console.ReadLine();

            ConvertStringsToDouble(roomLength, roomWidth);
        }

        private static void ConvertStringsToDouble(string roomLength, string roomWidth)
        {
            double doubleLength;
            double doubleWidth;
            bool lengthIsGood = double.TryParse(roomLength, out doubleLength);
            bool widthIsGood = double.TryParse(roomWidth, out doubleWidth);

            if (double.TryParse(roomLength, out doubleLength) && double.TryParse(roomWidth, out doubleWidth))
            {
                CalculateArea(doubleLength, doubleWidth);
                CalculateParimeter(doubleLength, doubleWidth);
                QuitConsoleApp();
            }
            else {
                InvalidInputs();
            }
        }

        private static void InvalidInputs()
        {
            Console.Clear();
            Console.WriteLine("One or both of your inputs were an invalid measurement. \n");
            GetUserInputs();
        }

        private static void CalculateArea(double doubleLength, double doubleWidth)
        {
            double roomArea = doubleLength * doubleWidth;
            Console.WriteLine(string.Format("The area of the room is {0}", roomArea));
        }

        private static void CalculateParimeter(double doubleLength, double doubleWidth)
        {
            double roomParimeter = (doubleLength * 2) + (doubleWidth * 2);
            Console.WriteLine(string.Format("The parimeter of the room is {0}", roomParimeter));
        }

        private static void QuitConsoleApp()
        {
            Console.WriteLine("\n\nPress R to repeat or any other key to exit the app.");
            ConsoleKeyInfo quitKey = Console.ReadKey();

            if (quitKey.Key.ToString().ToLower() == "r")
            {
                Console.Clear();
                GetUserInputs();
            }
        }
    }
}
