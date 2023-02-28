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

        public Room(double l, double w, double h, int cW)
        {
            try
            {
                if (l <= 0)
                {
                    throw new Exception("The length cannot be negative or zero");
                }
                else
                {
                    lenght = l;
                    if (w <= 0)
                    {
                        throw new Exception("The width cannot be negative or zero");
                    }
                    else
                    {
                        width = w;
                        if(h <= 0)
                        {
                            throw new Exception("The height cannot be negative or zero");
                        }
                        else
                        {
                            height = h;
                            if(cW < 0)
                            {
                                throw new Exception("The number of windows cannot be less than zero");
                            }
                            else
                            {
                                countWindow = cW;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error! " + e.Message + "\nPress Enter to exit...");
                Environment.Exit(0);
            }
        }
        public Room()
        {
            try
            {
                Console.WriteLine("Enter the lenght of the room: ");
                lenght = Convert.ToDouble(Console.ReadLine());
                if (lenght <= 0)
                {
                    throw new Exception("The length cannot be negative or zero");
                }
                Console.WriteLine("Enter the width of the room: ");
                width = Convert.ToDouble(Console.ReadLine());
                if (width <= 0)
                {
                    throw new Exception("The width cannot be negative or zero");
                }
                Console.WriteLine("Enter the height of the room: ");
                height = Convert.ToDouble(Console.ReadLine());
                if (height <= 0)
                {
                    throw new Exception("The height cannot be negative or zero");
                }
                Console.WriteLine("Enter the count window of the room: ");
                countWindow = Convert.ToInt32(Console.ReadLine());
                if(countWindow < 0)
                {
                    throw new Exception("The number of windows cannot be less than zero");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error! Format Exception! \nPress Enter to exit...");
                Environment.Exit(0);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error! " + e.Message + "\nPress Enter to exit...");
                Environment.Exit(0);
            }
        }
        public double getArea() { return lenght * width; }
        public double getVolume() { return lenght * width * height; }
        public double Lenght
        {
            get { return lenght; }
            set
            {
                try
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
                catch (Exception e)
                {
                    Console.WriteLine("Error! " + e.Message + "\nPress Enter to exit...");
                    Environment.Exit(0);
                }
            }
        }
        public double Height
        {
            get { return height; }
            set
            {
                try
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
                catch (Exception e)
                {
                    Console.WriteLine("Error! " + e.Message + "\nPress Enter to exit...");
                    Environment.Exit(0);
                }
            }
        }
        public double Width
        {
            get { return width; }
            set
            {
                try
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
                catch (Exception e)
                {
                    Console.WriteLine("Error! " + e.Message + "\nPress Enter to exit...");
                    Environment.Exit(0);
                }
            }
        }
        public int CountWindow
        {
            get { return countWindow; }
            set
            {
                try
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
                catch (Exception e)
                {
                    Console.WriteLine("Error! " + e.Message + "\nPress Enter to exit...");
                    Environment.Exit(0);
                }
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Room r1 = new Room();
            Console.WriteLine("lenght: " + r1.Lenght);
            Console.WriteLine("Area: " + r1.getArea());
            Console.WriteLine("Volume: " + r1.getVolume());
            r1.Lenght = -1;
        }
    }
}

   