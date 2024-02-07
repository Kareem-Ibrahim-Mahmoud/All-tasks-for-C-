using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Point3D
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

   
    public Point3D()
    {
        X = 0;
        Y = 0;
        Z = 0;
    }

    
    public Point3D(int x, int y, int z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    
    public Point3D(Point3D other) : this(other.X, other.Y, other.Z)
    {
    }

    
    public static bool operator ==(Point3D p1, Point3D p2)
    {
        if (ReferenceEquals(p1, p2))
        {
            return true;
        }

        if (p1 is null || p2 is null)
        {
            return false;
        }

        return p1.X == p2.X && p1.Y == p2.Y && p1.Z == p2.Z;
    }

    
    public static bool operator !=(Point3D p1, Point3D p2)
    {
        return !(p1 == p2);
    }

   
    public void Display()
    {
        Console.WriteLine($"Coordinates: ({X}, {Y}, {Z})");
    }

    
    public void ChangeCoordinates(int newX, int newY, int newZ)
    {
        X = newX;
        Y = newY;
        Z = newZ;
    }
}


class Program
{
    static void Main(string[] args)
    {
        Point3D P1 = new Point3D(1, 2, 3);
        Point3D P2 = new Point3D(P1);

        if (P1 == P2)
        {
            Console.WriteLine("P1 and P2 are equal.");
        }
        else
        {
            Console.WriteLine("P1 and P2 are not equal.");
        }

        P1.Display();
        P2.Display();

        P1.ChangeCoordinates(4, 5, 6);

        P1.Display();
        P2.Display();
    }
}