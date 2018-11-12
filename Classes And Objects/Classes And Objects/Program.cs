using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_And_Objects
{

    #region HOW CLASSES WORK

    /*TODO:
Think about classes, instances, and instantiation like baking a cake. 
A class is like a recipe for chocolate cake. The recipe itself is not a cake. 
You can't eat the recipe (or at least wouldn't want to). 
If you correctly do what the recipe tells you to do (instantiate it) then you have an edible cake. 
That edible cake is an instance of the chocolate cake class.
You can bake as many cakes as you would like using the same chocolate cake recipe. 
Likewise, you can instantiate as many instances of a class as you would like. 
Pretend you are baking three cakes for three friends who all have the same birthday but are different ages. 
You will need some way to keep track of which cake is for which friend so you can put on the correct number of candles. 
A simple solution is to write each friend's name on the cake. Reference variables work in a similar fashion. 
A reference variable provides a unique name for each instance of a
     
    */
    #endregion

    #region class Person

    
    class Person
    {
        int age;
        string name;
        public void SayHi()
        {
            Console.WriteLine("Hi");
        }
    }
    #endregion

    #region class Dog
    class Dog
    {
        public string name;
        public int age;

    }
    #endregion

    #region class BankAccount (ENCAPSULATION)
    class BankAAccount
    {
        private double balance = 0;
        public void Deposit(double n)
        {
            balance += n;
        }
        public void Withdraw(double n)
        {
            balance -= n;
        }
        public double GetBalance()
        {
            return balance;
        }
    }
    #endregion

    #region Constructors
    class Person0
    {
        private int age;
        public Person0()
        {
            Console.WriteLine("Hi I am Person0");
        }
    }

    class Person1
    {
        private int age;
        private string name;
        public Person1(string nm)
        {
            name = nm;
        }
        public string getName()
        {
            return name;
        }
            
    }

 

    #endregion

    #region Properties
    class Person2
    {
        private string name; //field

        public string Name //property
        {
            get { return name; }
            set { name = value;}
        }
    }

    class Person3
    {
        private int age = 0;
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                    age = value;
            }
        }
    }

    class Person4
    {
        public string Name { get; set; }
    }

    #endregion

    #region Destructor and Constructor example
    class Example
    {
        public Example()
        {
            Console.WriteLine("Constructor");
        }
        ~Example()
        {
            Console.WriteLine("Destructor");
        }
    }
    #endregion


    class Program
    {
        static void Main(string[] args)
        {
            #region class Person
            Person p1 = new Person();
            p1.SayHi();
           
            #endregion

            #region class Dog
            Dog bob = new Dog();
            bob.name = "Reksio";
            bob.age = 3;
            Console.WriteLine($"{bob.age} {bob.name}");
            #endregion

            #region BankAccount (ENCAPSULATION)

            
            BankAAccount kontoRoberta = new BankAAccount();
            kontoRoberta.Deposit(20000);
            kontoRoberta.Withdraw(20);
            Console.WriteLine(kontoRoberta.GetBalance());
            #endregion

            #region Constructors
            Person0 Robert = new Person0();

            Person1 Robert0 = new Person1("Robert");
            Console.WriteLine(Robert0.getName());
            #endregion

            #region Properties
            Person2 Me = new Person2();
            Me.Name = "Robert";
            Console.WriteLine(Me.Name);

            Person2 p = new Person2();
            p.Name = "Name";
            Console.WriteLine(p.Name);
            #endregion

            #region Destructor and Constructor example
            Example e = new Example();

            #endregion

            
        }
        

    }
}
