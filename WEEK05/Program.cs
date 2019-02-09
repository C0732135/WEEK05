using System;

namespace WEEK05
{
    class Program
    
    {
        static void Main(string[] args)
        {
            Elevator e = new Elevator();
            e.run();
            

        }
    }
    class Node
    {
        public Node() { }
       public Node floor;
       public Node elevatorUp;
       public string FloorNumber;

    }
    class Elevator
    {
        Node FirstFloor;
        Node SecondFloor;
        Node ThirdFloor;
        Node FourthFloor;

        public void run()
        {
            FirstFloor = new Node();//memory allocation
            SecondFloor = new Node();
            ThirdFloor = new Node();
            FourthFloor = new Node();
            FirstFloor.FloorNumber = "First Floor";
            Console.WriteLine("Floor number is{0}", FirstFloor.FloorNumber);
          
            FirstFloor.elevatorUp = SecondFloor;
            SecondFloor.FloorNumber = "Second Floor";
            Console.WriteLine("Floor number is{0}", SecondFloor.FloorNumber);

            SecondFloor.elevatorUp = ThirdFloor;
            ThirdFloor.FloorNumber = "ThirdFloor";
            Console.WriteLine("Floor number is{0}", ThirdFloor.FloorNumber);

            ThirdFloor.elevatorUp = FourthFloor;
            FourthFloor.FloorNumber = "Fourth floor";
            Console.WriteLine("Floor number is{0}", FourthFloor.FloorNumber);

            FourthFloor.elevatorUp = null;
           
        }
    }
}
