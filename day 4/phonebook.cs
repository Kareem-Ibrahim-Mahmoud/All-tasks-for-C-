

using System;

public class PhoneBook
{
    string[] names = new string [10];
    public string this [int index]
    {
        get {
            
            return names [index];
        }
        
        set{
            
            names [index] =value;
            
            
        }
        
    }
    
    public static void Main(string[] args)
    {
        PhoneBook pho=new PhoneBook();
        pho[0] = "Ali";
        pho[2] = "sameh";
        pho[3] = "Mohamed";
        pho[4] = "789";
        
        Console.WriteLine( pho[0]);
        Console.WriteLine( pho[2]);
        Console.WriteLine( pho[3]);
        Console.WriteLine( pho[4]);
        

    }
}