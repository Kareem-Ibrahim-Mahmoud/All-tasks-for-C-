

using System;
using System.Collections.Generic;

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
        PhoneBook pho=dic[1];
        /*
        pho[0] = "Ali";
        pho[2] = "sameh";
        pho[3] = "Mohamed";
        pho[4] = "789";
        
        Console.WriteLine( pho[0]);
        Console.WriteLine( pho[2]);
        Console.WriteLine( pho[3]);
        Console.WriteLine( pho[4]);
        */
        Dictionary<int,PhoneBook> dic=new Dictionary<int,PhoneBook>;
        Dictionary<int,PhoneBook> dic1=new Dictionary<int,PhoneBook>;
        dic.Add(1,new PhoneBook {index =1 ,names="kareem" });
        dic1.Add(2,new PhoneBook {index =2 ,names="khaled" });
        
        Console.WriteLine(pho.dic[1]);
        Console.WriteLine(pho.dic[2]);

    }
}