using myName;

Console.WriteLine();
myName.Cat.SayHello();
Dog.SayHello();

namespace myName
{


    class Cat 
    {

        public static void SayHello()
        {
            Console.WriteLine("Hello, i am a cat");
        }

    }

}

class Dog
{

    public static void SayHello()
    {
        Console.WriteLine("Hello, i am a dog!");
    }

}



