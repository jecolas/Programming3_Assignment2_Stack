// Fig. 19.14: StackInheritanceTest.cs
// Testing class StackInheritance.
using System;
using StackInheritanceLibrary;
using LinkedListLibrary;

// demonstrate functionality of class StackInheritance
class StackInheritanceTest
{
   static void Main()
   {
      StackInheritance<double> stack = new StackInheritance<double>();

      // use method Push to add items to stack
      Console.WriteLine("==============push==============");
      stack.Push(10.5);
      stack.Display();
      stack.Push(13.25);
      stack.Display();
      stack.Push(50.87);
      stack.Display();
      stack.Push(89.21);
      stack.Display();

        Console.WriteLine("==============execute peek method==============");
        stack.Peek();

        Console.WriteLine("==============pop==============");
        stack.Pop();
        stack.Display();
        stack.Pop();
        stack.Display();

      // remove items from stack
      try
      {
         while (true)
         {
            object removedObject = stack.Pop();
            Console.WriteLine($"{removedObject} popped");
            stack.Display();
         }
      }
      catch (EmptyListException emptyListException)
      {
         // if exception occurs, write stack trace
         Console.Error.WriteLine(emptyListException.StackTrace);
      }
   }
}

