using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1
{
    class Room
    {
        private double lenght;
        private double width;
        private double height;
        private int countWindow;

        public Room(double tLenght, double tWidth, double tHeight, int tCountWindow)
        {
            Lenght = tLenght;
            Width = tWidth;
            Height = tHeight;
            CountWindow = tCountWindow;
        }
        public Room()
        {

                Console.WriteLine("Enter the lenght of the room: ");
                Lenght = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the width of the room: ");
                Width = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the height of the room: ");
                Height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the count window of the room: ");
                CountWindow = Convert.ToInt32(Console.ReadLine());
            
        }
        public double Lenght
        {
            get => lenght; 
            set
            {
                    if (value <= 0)
                    {
                        throw new Exception("The lenght cannot be negative or zero");
                    }
                    else
                    {
                        lenght = value;
                    }
            }
        }
        public double Height
        {
            get => height; 
            set
            {
                    if (value <= 0)
                    {
                        throw new Exception("The height cannot be negative or zero");
                    }
                    else
                    {
                        height = value;
                    }
            }
        }
        public double Width
        {
            get => width; 
            set
            {
                    if (value <= 0)
                    {
                        throw new Exception("The width cannot be negative or zero");
                    }
                    else
                    {
                        width = value;
                    }
            }
        }
        public int CountWindow
        {
            get => countWindow; 
            set
            {
              
                if (value <= 0)
                    {
                  throw new Exception("The number of windows cannot be less than zero");
                    }
                else
                    {
                        countWindow = value;
                    }
            }
        }
        public double GetArea() => lenght * width; 
        public double GetVolume() => lenght * width * height; 

    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Room r1 = new Room();
                Console.WriteLine("lenght: " + r1.Lenght);
                Console.WriteLine("Area: " + r1.GetArea());
                Console.WriteLine("Volume: " + r1.GetVolume());
            }
            catch(FormatException)
            {
                Console.WriteLine("Error! Format Exception! \nPress Enter to exit...");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error! " + e.Message + "\nPress Enter to exit...");
                Console.ReadKey();
            }
        }
    }
}

   