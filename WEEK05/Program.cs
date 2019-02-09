using System;

namespace WEEK05
{
    class Program
    
    {
        static void Main(string[] args)
        {
            Elevator e = new Elevator();
            e.setup();
            e.traverselist();
            

        }
    }
    class Node
    {
        public Node() { }
       public Node floor;
       public Node elevatorUp;
       public string FloorNumber;
       
    }
    class Department
    {
        public Department aDepartment; 
    }
    class Elevator
    {
        Node FirstFloor;
        Node SecondFloor;
        Node ThirdFloor;
        Node FourthFloor;
        Node Head;

        public void setup()
        {
            FirstFloor = new Node();//memory allocation
            SecondFloor = new Node();
            ThirdFloor = new Node();
            FourthFloor = new Node();
            Head = FirstFloor;
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
        public void traverselist()
        {
            Node temp;
            temp = Head;

          
            while (temp!=null)
           {
                
                Console.WriteLine(temp.FloorNumber);
                temp = temp.elevatorUp;

           }
        }
    }
}
