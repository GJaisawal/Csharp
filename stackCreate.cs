using System;
using System.Collections;
using System.Collections.Generic;

public class stackCreate
{
    public static void Main()
    {
        Stack<int> myStack = new Stack<int>();

        myStack.Push(1);
        myStack.Push(2);
        myStack.Push(3);
        myStack.Push(4);

        foreach(var item in  myStack)
        {
            Console.Write(item +",");
        }
    }
}