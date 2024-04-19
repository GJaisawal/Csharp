using System;
using System.Collections;
using System.Collections.Generic;

public class stackfromArray
{
    public static void Main()
    {
        int[] arr = new int[5];

        for(int i = 0; i < 5; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Stack<int> myStack = new Stack<int>(arr);

        foreach(var item in myStack)
        {
            Console.Write(item+",");
        }
        Console.WriteLine();

        Console.WriteLine("Total Element count : "+myStack.Count);          //Count Property

        //Peek
        if(myStack.Count > 0)
        {
            Console.WriteLine("peeked element : "+myStack.Peek());                              //Peek Method (Stack)
        } 
        Console.WriteLine();

        if(myStack.Contains(5))
        {
            Console.WriteLine("true");
        }

        Console.WriteLine();
        //Count After Peek Operation
        Console.WriteLine("Total Element count : "+myStack.Count);

        //Pop
        while(myStack.Count > 0)
        {
            Console.Write(myStack.Pop() +",");                              //Pop Method (Stack)
        }   
        Console.WriteLine();
        //Count After Pop Operation
        Console.WriteLine("Total Element count : "+myStack.Count);

    }
}