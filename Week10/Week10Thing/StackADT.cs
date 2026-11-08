using System;
using System.Diagnostics.Metrics;
using System.Net.Security;

namespace Week10Thing;

public class StackADT
{
    private object[] array;
    private int top = -1;

    public StackADT()
    {
        array = new object[5];
    }

    public StackADT(int size)
    {
        array = new object[size];
    }

    public void Push(object item)
    {
        top++;
        array[top] = item;
    }

    public int Pop()
    {
        return 1;    
    }

    public int Peek()
    {
        return 1;
    }

    




}
