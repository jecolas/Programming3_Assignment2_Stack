// Fig. 19.13: StackInheritanceLibrary.cs
// Implementing a stack by inheriting from class List.
using LinkedListLibrary;

namespace StackInheritanceLibrary
{
   // class StackInheritance inherits class List's capabilities
   public class StackInheritance<T> : List<T>
   {
      // pass name "stack" to List constructor
      public StackInheritance() : base("stack") { }

      // place dataValue at top of stack by inserting 
      // dataValue at front of linked list
      public void Push(T dataValue)
      {
            InsertAtFront(dataValue);
      }

      // remove item from top of stack by removing
      // item at front of linked list
      public T Pop()
      {
         return RemoveFromFront();
      }

        public void Peek()
        {
            System.Console.WriteLine(getFirst());
        } 
   }
}

