using System;
using System.Collections;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Xml.Linq;
using DotnetApp;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace dotnetapp;
class Program
{
    public static void Main(string[] args)
    {
        //FatherProperties f = new FatherProperties();
        //f.gadgets();
        //f.asserts();

        //Son s = new Son();

        //s.gadgets();
        //s.asserts();

        //RetailStock r = new RetailStock("AAPL", "Apple Inc", 23, 1.8, "Retails");
        //TechStock s = new TechStock("MSFT", "MSFT", 15.9, 0.5, "Technology");

        //Console.WriteLine(r.displayInfo());
        //Console.WriteLine(s.displayInfo());

        //r.sell();
        //r.sell(4);

        //r.buy();
        //r.buy(3);

        //Console.WriteLine(StockHelper.TotalStockValue(r.TickerPrice, 8));


        /* Write a program that accepts 10 integers from the user, stores them in a one-dimensional array, and then calculates and
                  displays the sum and average of the numbers.
        int num = 0;
        int sum= 0;
        Console.WriteLine("Enter the numbers");
        for(int i = 0; i<10;i++)
        {
            num = Convert.ToInt32(Console.ReadLine());
            sum = sum + num;

        }
        double avg = sum / 10;
        Console.WriteLine(sum);
        Console.WriteLine(avg);

        */


        /* Find Maximum and Minimum. Create a program that finds the maximum and minimum value in a one-dimensional array of integers.

        int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };
        int max = arr[0];
        int min = arr[1];
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
            if (arr[i] < min)
            {
                min = arr[i];
            }

        }
        Console.WriteLine("Max: "+max);
        Console.WriteLine("Min: " + min);

        */

        /*Reverse an Array - Write a method that reverses a one - dimensional array in place and prints the reversed array.

        int[] arr = { 1, 23, 45, 2 };
        for (int i = arr.Length - 1; i >= 0; i--)
        {
        Console.WriteLine(arr[i]);
        
        }
        */

        /* Frequency Count Given an array of integers, count how many times each number appears and display the result.

        int[] arr = { 1, 2, 3, 4, 2, 3, 4, 5, 2, 2 };
     
        for (int i = 0; i < arr.Length; i++)
        {
            int count = 1;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j])
                {
                    count++;
                    
                }
            }

            Console.WriteLine($"{arr[i]} = {count} ");
        }
        
        */

        /* Matrix Addition Write a program to add two 3x3 matrices and display the resulting matrix.
    
         
        int [,] a = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int[,] b = { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };
        int[,] sum = new int[3,3];
        for(int i = 0; i < 3; i++)
        {
            for(int j = 0;j<3;j++)
            {
              sum[i, j] = a[i, j] + b[i, j];
            }
        }
        for(int i = 0;i<3;i++)
        {
            for(int j = 0;j <3;j++)
            {
                Console.Write(sum[i, j]+" ");
            }

            Console.WriteLine();
        }
        
        */

        /* Matrix Multiplication - Create a program that multiplies two matrices(e.g., 3x2 and 2x4) and displays the result.

        int[,] A = {{1, 2},{3, 4},{5, 6}};

        int[,] B = {{7, 8, 9, 10},{11, 12, 13, 14}};

        int[,] result = new int[3, 4];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                result[i, j] = 0;

                for (int k = 0; k < 2; k++)
                {
                    result[i, j] += A[i, k] * B[k, j];
                }
                Console.Write(result[i, j] + "\t");
            }
            Console.WriteLine();
        }
        */


        /* Transpose of a Matrix - Write a program to compute and print the transpose of a 3x3 matrix.
        int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        
        Console.WriteLine("Original Matrix:");

        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Traspose Matrix");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matrix[j,i] + "\t");
            }
            Console.WriteLine();
        }

        */


        /*Diagonal Sum Given a 3x3 matrix, calculate the sum of the main diagonal and the secondary diagonal elements.

        int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

        int mainDiagonal = 0;
        int secDiagonal = 0;

        for(int i =0; i< 3; i++)
        {
            mainDiagonal += matrix[i,i];
            secDiagonal += matrix[i, 2 - i];
        }

        Console.WriteLine("Main Diagonal Sum: " + mainDiagonal);
        Console.WriteLine(("Secondary Diagonal Sum: " + secDiagonal));

        */

        /*
        string name = "anna";
        if(name == new string(name.Reverse().ToArray()))
        {
            Console.WriteLine("Polindrome");
        }
        else
        {
            Console.WriteLine("Not Polindrome");
        }
        */

        /* To get the current date

        DateTime d = DateTime.Now;
        Console.WriteLine(d);

        */

        /* Calculate and display the date after adding 100 days to the user's birthdate.

        
        DateTime  db = DateTime.Parse(Console.ReadLine());
        DateTime dateAfter100days=db.AddDays(100);
        Console.WriteLine(dateAfter100days);

        */

        /*Determine and display the day of the week on which the user was born.

        DateTime dateofbirth = DateTime.Parse(Console.ReadLine());
        string day=dateofbirth.DayOfWeek.ToString();
        Console.WriteLine(day);

        */

        /*Implement error handling to handle invalid date inputs.

       DateTime date = DateTime.Now;

       try
       {
           Console.Write("Enter a date: ");
           string input = Console.ReadLine();

           DateTime d = Convert.ToDateTime(input);

           if (date.Date == d.Date)
           {
               Console.WriteLine("Date input matched");
           }
           else
           {
               Console.WriteLine("Date does not match today's date");
           }
       }
       catch (FormatException)
       {
           Console.WriteLine("Invalid date format. Please enter date  in correct format.");
       }
       catch (Exception ex)
       {
           Console.WriteLine("Something went wrong: " + ex.Message);
       }
       */

        /**************************************************** List *****************************************************/

        /*
        Create a program that uses a SortedList to store the names and ages of five people.
        SortedList<string, int> sl=new SortedList<string, int>();
        sl.Add("Rahul", 28);
        sl.Add("Venkat", 29);
        sl.Add("Kiran", 34);
        sl.Add("Jani", 38);
        sl.Add("Ram", 45);
        Console.WriteLine(sl.Count);

        for( int i =0; i<= sl.Count;i++)
        {
            Console.WriteLine(sl.Keys[i] + " " + sl.Values[i]);
        }
        */

        /* Allow the user to input names and ages for each person.

        SortedList<string, int> people= new SortedList<string, int>();
        Console.WriteLine("Enter how many you want to add:");
        int countOfPeople=Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i <= countOfPeople; i++)
        {
            Console.WriteLine("Enter the username:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the userage");
            int age = Convert.ToInt32(Console.ReadLine());
            people.Add(name, age);

        }
        foreach(KeyValuePair<string, int> kvp in people)
        {
            Console.WriteLine(kvp.Key + " " + kvp.Value);
        }

        */

        /*Display the names and ages in ascending order based on age.

        SortedList<string, int> people = new SortedList<string, int>();
        Console.WriteLine("Enter how many you want to add:");
        int countOfPeople = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i <= countOfPeople; i++)
        {
            Console.WriteLine("Enter the username:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the userage");
            int age = Convert.ToInt32(Console.ReadLine());
            people.Add(name, age);

        }
        var sortByAge = people.OrderBy(x => x.Value);
        foreach(var p in sortByAge)
        {
            Console.WriteLine(p.Key + " " + p.Value);
        }
        */

        /* Allow the user to search for a person by name and display their age.

        SortedList<string, int> people = new SortedList<string, int>();
        Console.WriteLine("Enter how many you want to add:");
        int countOfPeople = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i <= countOfPeople; i++)
        {
            Console.WriteLine("Enter the username:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the userage");
            int age = Convert.ToInt32(Console.ReadLine());
            people.Add(name, age);

        }
        Console.WriteLine("enter the name you are searching for:");
        string searchName=Console.ReadLine();
        if (people.ContainsKey(searchName))
        {
            Console.WriteLine($"{searchName} age is {people[searchName]}");

        }
        else
        {
            Console.WriteLine("Person not found");
        }

        */

        /********************************************************** Queue ********************************************************/

        /* Create a program that uses a Queue to simulate a waiting line for a service.

        Queue q = new Queue();
        q.Enqueue("Venkat");
        q.Enqueue("Vishnu");
        q.Enqueue("John");

        Console.WriteLine("See who is waiting in the queue");

        foreach(string person in q)
        {
            Console.WriteLine(person);
        }

        while(q.Count>0)
        {
            Console.WriteLine(q.Dequeue() + "  is served");
        }
        */

        //Allow the user to enqueue (join the line) and dequeue (get service) people.

        Queue<string> queue = new Queue<string> ();
        bool running = true;
        while (running)
        {
            Console.WriteLine("Choose an option");
            Console.WriteLine(" 1. Join the line");
            Console.WriteLine(" 2. Get Service");
            Console.WriteLine(" 3. View object in queue");
            Console.WriteLine(" 4. Exit");
        }

        Console.WriteLine("Choose an option:");
        int option = Convert.ToInt32(Console.ReadLine ());

        switch (option)
        {
            case 1:
                Console.WriteLine("Enter the name:");
                string name = Console.ReadLine();
                queue.Enqueue(name);
                break;

            case 2:
                if (queue.Count > 0)
                {
                    string served = queue.Dequeue();
                    Console.WriteLine($"{served} + has served and removed from the queue");


                }
                else
                {
                    Console.WriteLine("Queue is empty! no one is  served");
                }
                break;
            case 3:

                if (queue.Count > 0)
                {
                    Console.WriteLine("People in queue:");
                    foreach (var person in queue)
                    {
                        Console.WriteLine(person);
                    }
                }
                else
                {
                    Console.WriteLine("Queue is empty.");
                }
                break;

            case 4:
                running = false;
                Console.WriteLine("Exiting program.");
                break;

            default:
                Console.WriteLine("Invalid choice. Try again.");
                break;
        }

        }

        

        /* Display the current queue after each enqueue or dequeue operation.

        Queue<string> queue = new Queue<string>();
        Console.WriteLine("Enter the name:");
        queue.Enqueue("Venkat");
        queue.Enqueue("Ram");
        Console.WriteLine("Dispaly the objects in queue:");
        foreach(var qitems in queue)
        {
            Console.WriteLine(qitems);
        }
        queue.Dequeue();
        if(queue.Count == 0)
        {
            Console.WriteLine("Queue is empty");
        }
        else
        {
           foreach(var items in queue)
            {
                Console.WriteLine("Remaining objects presents in queue: "+items);
            }
        }

    */


        /* Implement error handling to handle dequeue from an empty queue.

        Queue<string> queue = new Queue<string>();
        queue.Enqueue("Venkat");
        queue.Enqueue("Swathi");

        Console.WriteLine("Display the people who are queue");
        foreach ( var people in queue)
        {
            Console.WriteLine(people);
        }
        try
        {
            
            Console.WriteLine(queue.Dequeue()+ " First person removed from queue");
            Console.WriteLine(queue.Dequeue() +" Second person removed from queue");
            Console.WriteLine(queue.Dequeue() +" Third person removed from queue");

        }
        catch(InvalidOperationException e)
        {
            Console.WriteLine("No more people in the queue to remove.....!");
        }
        catch ( Exception ex)
        {
            Console.WriteLine(ex);
        }

        */

        /******************************************************* Dictionary ************************************************/

        /* Create a program that uses a Dictionary to store contact information (name and phone number) for five people.

        Dictionary<string, long> map = new Dictionary<string, long>();
        map.Add("Venkat", 7989490529);
        map.Add("John", 9885073164);
        map.Add("David", 9849749946);

       foreach(KeyValuePair<string, long> m in map)
        {
            Console.WriteLine(m.Key+ " :  "+ m.Value);
        }
        */

        /* Create a program that uses a Dictionary to store contact information (name and phone number) for five people.
         * Allow the user to input names and phone numbers for each person.

        Dictionary<string, long> dict = new Dictionary<string, long>();
        Console.WriteLine("Enter the count for how many people you want to store");
        int count = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Enter the name:");
            string name=Console.ReadLine();
            Console.WriteLine("Enter the phone number:");
            long num=Convert.ToInt64(Console.ReadLine());
            dict.Add(name, num);
        }
        foreach(KeyValuePair<string,long> kk in dict)
        {
            Console.WriteLine(kk.Key+" "+kk.Value);
        }
        */

        /* Display the contact information for a person based on their name.

        Dictionary<string, long> dict = new Dictionary<string, long>();
        Console.WriteLine("Enter the count for how many people you want to store");
        int count = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Enter the name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the phone number:");
            long num = Convert.ToInt64(Console.ReadLine());
            dict.Add(name, num);
        }
        Console.WriteLine("Enther name you want to know information:");
        string searchName= Console.ReadLine();

        if (dict.ContainsKey(searchName))
        {
            Console.WriteLine($"{searchName} for his contact number is {dict[searchName]}");
        }
        else
        {
            Console.WriteLine("Contact information not found");
        }

        */

        /****************************************************** Stack ************************************************/

        /* Create a program that uses a Stack to simulate a stack of plates.

        Stack s = new Stack();
        s.Push("Plate - 1");
        s.Push("Plate - 2");
        s.Push("Plate - 3");

        Console.WriteLine("Displaying the plates : ");
        foreach(var p in s)
        {
            Console.WriteLine(p);
        }

        while (s .Count > 0)
        {
            Console.WriteLine(s.Pop() + " is removed");
        }

        */

        /*Allow the user to push (add) and pop (remove) plates.
         
        Stack s = new Stack();
        s.Push(1);
        s.Push(2);
        s.Push(3);
        s.Push(4);

        Console.WriteLine("After push the objects into stack");

       foreach(var x in s)
        {
            Console.WriteLine(x);
        }

        s.Pop();
        s.Pop();

        Console.WriteLine("After removing objects from the stack:");
        foreach(var x in s)
        {
            Console.WriteLine(x);
        }

        */

        /* Display the current stack after each push or pop operation.

        Stack s = new Stack();

        s.Push(1);

        Console.WriteLine("After one push");

        foreach(var oned in s)
        {
            Console.WriteLine(oned);
        }
        s.Pop();
        int count = s.Count;
        if(count == 0)
        {
            Console.WriteLine("Stack is empty");
        }
        else
        {
            foreach(var values in s)
            {
                Console.WriteLine(values);
            }
        }

        */

        /*
        Implement error handling to handle pop from an empty stack.

        Stack<int> s= new Stack<int>();
        s.Push(12);
        s.Push(13);

        try
        {
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());
            Console.WriteLine(s.Pop());

        }
        catch(Exception e)
        {
            Console.WriteLine(e);
        }

        */








    }
}
