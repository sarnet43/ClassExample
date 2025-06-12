using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClassExample
{
    class Program
    {
        class Parent
        {
            public static int counter = 0;
            public void CouterParent()
            {
                Parent.counter++;
            }
            public Parent() {  Console.WriteLine("Parent()"); }
            public Parent(int param) {  Console.WriteLine("Parent(int param)"); }
            public Parent(string param) {  Console.WriteLine("Parent(string param)"); }
           
        }

        class Child : Parent
        {
            public void CouterChild()
            {
                Child.counter++;
            }
            public Child() : base(10)
            {
                Console.WriteLine("Child() : base(10)");
            }
            public Child(string input) : base(input)
            {
                Console.WriteLine("Child(string input) : base(input)");
            }
        }
        static void Main(string[] args)
        {
            Child childA = new Child();
            Child childB = new Child("string");

            Parent parent = new Parent();
            Child child = new Child();

            parent.CouterParent();
            child.CouterParent();
            Console.WriteLine(Parent.counter);
            Console.WriteLine(Child.counter);
        }
    }
}
