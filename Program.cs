namespace ListTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the List Task by Ahmed Naeim");
            Console.WriteLine("Only valid inputs are P, A, M, S, L, Q");

            bool myLoop = true;
            List<int> ints = new List<int>(); 
            int largestNum = 0;
            int smallestNum = 0;
            int sum = 0;
            int mean = 0;
            int tempInput = 0;
            int searchNum = 0;
            bool searchIsFound = false;

            while (myLoop)
            {
                Console.WriteLine("======================================================");
                Console.WriteLine("P => Print all numbers");
                Console.WriteLine("A => Add a new number");
                Console.WriteLine("M => Display mean of the numbers");
                Console.WriteLine("S => Display the smallest number");
                Console.WriteLine("L => Display the largest number");
                Console.WriteLine("Q => Quit");
                Console.WriteLine(" ");
                Console.WriteLine("F => search for a number and return index");
                Console.WriteLine("C => Clear the list");
                Console.WriteLine("======================================================");
                Console.WriteLine(" ");
                Console.Write("Please enter a valid character: ");
                char myInput = char.Parse(Console.ReadLine().ToUpper());

                switch (myInput)
                {
                    case 'P':
                        if (ints.Count == 0)
                        {
                            Console.WriteLine("[ ] - the list is empty");
                        }
                        else
                        {
                            Console.Write("your list => [ ");
                            for (int i = 0; i < ints.Count; i++)
                            {
                                Console.Write($"{ints[i]} ");
                            }
                            Console.Write("]");
                        }
                        Console.WriteLine(" ");
                        Console.WriteLine("=============================");
                        Console.WriteLine(" ");
                        break;
                    
                    case 'A':
                        Console.Write("Enter a valid integer number: ");
                        tempInput = int.Parse(Console.ReadLine());
                        ints.Add(tempInput);
                        Console.WriteLine($"you added {tempInput} to the list");
                        
                        //instead of complex largest and smallest algorithms
                        if(tempInput > largestNum || ints.Count == 1)
                        {
                            largestNum = tempInput;
                        }
                        if(tempInput < smallestNum || ints.Count == 1)
                        {
                            smallestNum = tempInput;
                        }
                        Console.WriteLine(" ");
                        Console.WriteLine("=============================");
                        Console.WriteLine(" ");
                        break;
                    
                    case 'M':
                        for (int i = 0; i < ints.Count; i++)
                        {
                            sum += ints[i];
                        }

                        mean = sum / ints.Count;
                        Console.WriteLine($"The mean/Average equals => {mean}");
                        
                        Console.WriteLine(" ");
                        Console.WriteLine("=============================");
                        Console.WriteLine(" ");
                        break;

                    case 'S':
                        Console.WriteLine($"The smallest number in the list is {smallestNum}");

                        Console.WriteLine(" ");
                        Console.WriteLine("=============================");
                        Console.WriteLine(" ");
                        break;

                    case 'L':
                        Console.WriteLine($"The largest number is the list is {largestNum}");

                        Console.WriteLine(" ");
                        Console.WriteLine("=============================");
                        Console.WriteLine(" ");
                        break;

                    case 'F':
                        Console.Write("Please enter the number you want to search for: ");
                        searchNum = int.Parse(Console.ReadLine());
                        for (int i = 0; i < ints.Count; i++)
                        {
                            if (searchNum == ints[i])
                            {
                                Console.WriteLine($"The number {searchNum} is at index {i} in the list");
                                searchIsFound = true;
                                break;
                            }
                        }
                        if (searchIsFound == false)
                        {
                            Console.WriteLine($"the number {searchNum} is not found in the list");
                        }
                        Console.WriteLine(" ");
                        Console.WriteLine("=============================");
                        Console.WriteLine(" ");
                        break;

                    case 'C':
                        ints.Clear();
                        smallestNum = 0;
                        largestNum = 0;
                        Console.WriteLine("the list is empty now");
                        Console.WriteLine(" ");
                        Console.WriteLine("=============================");
                        Console.WriteLine(" ");
                        break;

                    case 'Q':
                        myLoop = false;
                        Console.WriteLine("The program is closed");
                        break;

                }

            }
        }
    }
}
