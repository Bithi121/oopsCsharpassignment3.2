using System;

namespace oopsCsharpassignment3._2
{

    class MyStack : ICloneable
    {
        readonly int[] a = new int[10];
        int top=-1;
        int n;

        public MyStack()
        {


        }
        public MyStack(int n)
        {
            this.n = n;
        }
    
    public object Clone()
    {
            MyStack m = new MyStack();

            m.n = this.n;
            return m;

    }

        bool IsEmpty()
        {
            return (top < 0);
        }
        
        internal bool Push(int data)
        {
            if (top >= n)
            {
                    throw new stackException("Stack Overflow");
            }
            else
            {
                a[++top] = data;
                return true;
            }
        }
        internal int Pop()
        {
            if (top < 0)
            {
               
                    throw new stackException("Stack underflow");
              
                return 0;
            }
            else
            {
                int value = a[top--];
                return value;
            }
        }
        internal void PrintStack()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
                Console.WriteLine("Items in the Stack are :");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(a[i]);
                }
            }
        }
    }
    public class stackException: ApplicationException
    {
        public stackException(string message) : base(message)
        {



        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyStack s = new MyStack(3);
            MyStack s1 = s.Clone() as MyStack;
           try
            {
                s1.Push(10);
                s1.Push(20);
                s1.Push(30);
                s1.Push(40);
                s.Push(10);
                s.Push(20);
                s.Push(30);
                s.Push(40);
                s.PrintStack();
                s1.PrintStack();
                Console.WriteLine("Item popped from Stack :" + s1.Pop());
                s1.PrintStack();
            }
           catch(stackException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
