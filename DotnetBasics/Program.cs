/* Variables
Datatypes
Operators */

/*using System.ComponentModel;

var a = 10;               //Var - Dynamic Datatype - Variables
int b = 20;              //Int Datatype
var c = a + b;          //Adding - ArthematicOperator
Console.WriteLine(c);

var d = a - b; 
Console.WriteLine(d);   // Subtracting

var e = a * b;
Console.WriteLine(e);   // Multiplication

var f = a / b;
Console.WriteLine(f);   //Modulation

var g = a % b;
Console.WriteLine(g);   // Division

string firstname = "Venkata"; //string datatype
string lastname = "Singatala";
var fullname=string.Concat(firstname, lastname); //Concating two strings
Console.WriteLine(fullname);

//If Loop
int age = 25;
if (age > 18)
{
    Console.WriteLine("You are eligible to vote");
}
else
{
    Console.WriteLine("You are not eligible to vote");
}

//If Else If Loop
int i = 2;
int j = 7;
int k = 4;

if (  i > j && i > k)
{
    Console.WriteLine("i is the largest number");
}
else if (j > i && j > k)
{
    Console.WriteLine("j is the largest number");
}
else
{
    Console.WriteLine("k is the largest number");
}

//Arrays with for loop
int[] arr = new int[] { 1, 2, 3, 4, 5 };
int sum = 0;
Console.WriteLine("Array elements are: ");
for (int m=0;m<arr.Length;m++)
{
    sum =sum+arr[m];
}
Console.WriteLine("Sum of array elements is: " + sum);

//Arrays with print statement
int[] arr1 = new int[5];
arr1[0] = 1;
arr1[1] = 4;
arr1[2] = 5;

Console.WriteLine("Array elements are: " + arr1[0]+" " + arr1[1]+ " " + arr1[2]);

//Switch Case Program   
int dayNum = 3;
switch (dayNum)
{
    case 0:
        Console.WriteLine("Sunday");
        break;
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    default:
        Console.WriteLine("Invalid day number");
        break;
}

//While Loop, printing from 10 to 1 
int n = 10;
while(n>1)
{
    Console.WriteLine("Number are from 10 to 1: " + n);
    n--;
}

//Do While Loop, printing from 1 to 10

int s = 1;
do
{
    Console.WriteLine("Number are from 1 to 10: " + s);
    s++;
} while (s <= 10);

//String Manipulation
string bird = "Parrot";
string upper_Case = bird.ToUpper();
Console.WriteLine("Printing bird name in upper case:"+ upper_Case); //Converting to Upper case


string toLower=bird.ToLower();
Console.WriteLine("Printing bird name in lower case:" + toLower); //Converting to Lower case

string replace = bird.Replace("Parrot", "Pigeon");
Console.WriteLine("Replacing Parrot with Pigeon:" + replace); //Replacing Parrot with Pigeon

string lenthBird = bird.Length.ToString();
Console.WriteLine("Length of the bird name is:" + lenthBird); //Length of the string

string subString = bird.Substring(2, 3);
Console.WriteLine("Substring of the bird name is:" + subString); //Substring of the string

string animal = " dog";
string trim = animal.Trim();
Console.WriteLine("Trimming the animal name:" + trim); //Trimming the string - removing spaces

string[] split = bird.Split('r');
Console.WriteLine("Splitting the bird name:" + split[0] + " " + split[1]); //Splitting the string 

//String Interpolation  
string name = "Venkata";
string city = "Hyderabad";
string country = "India";
Console.WriteLine($"My name is {name}, I am from {city}, {country}"); //String Interpolation

//Write a C# Sharp program to check whether a given number is positive or negative.

int num1 = Convert.ToInt32(Console.ReadLine()); 

if(num1<=0)
    {
    Console.WriteLine("The number is negative");
}
else
{
    Console.WriteLine("The number is positive");
}

//Write a C# code to accept two integers and check whether they are equal or not.

int val1=Convert.ToInt32(Console.ReadLine());
int val2 = Convert.ToInt32(Console.ReadLine());
if(val1 == val2)
{
    Console.WriteLine("The numbers are equal");
}
else
{
    Console.WriteLine("The numbers are not equal");
}

//Write a C# Sharp program to accept a person's height in centimeters and categorize them according to their height.

int height = Convert.ToInt32(Console.ReadLine());

if(height < 150)
{
    Console.WriteLine("Short");
}
else if (height >= 150 && height <= 180)
{
    Console.WriteLine("Average");
}
else
{
    Console.WriteLine("Tall");
}

//Write a C# Sharp program to find the largest of three numbers.
int v1=Convert.ToInt32(Console.ReadLine());
int v2=Convert.ToInt32(Console.ReadLine());
int v3 = Convert.ToInt32(Console.ReadLine());

if(v1>v2 && v1> v3)
{
    Console.WriteLine("V1 is greater");
}
else if(v2>v3 && v2>v1){
    Console.WriteLine("V2 is greater");
}
else
{
    Console.WriteLine("V3 is greater");
}

//Write a C# Sharp program to read roll no, name and marks of three subjects and calculate the total, percentage and division.
int rollNo = Convert.ToInt32(Console.ReadLine());
string name1 = Console.ReadLine();
int marks1 = Convert.ToInt32(Console.ReadLine());
int marks2 = Convert.ToInt32(Console.ReadLine());
int marks3 = Convert.ToInt32(Console.ReadLine());
int total = marks1 + marks2 + marks3;
float percentage = (total / 300.0f) * 100;

if(percentage> 80)
{
    Console.WriteLine("A Grade");
}else if(percentage>60 && percentage<80)
{
    Console.WriteLine("B grade");
}
else
{
    Console.WriteLine("C Grade");
}
Console.WriteLine("Roll No: " + rollNo);
Console.WriteLine("Name: " + name1);
Console.WriteLine("Total Marks: " + total);
Console.WriteLine("Percentage of marks: " + percentage);


*/

/*
//Write a C# Sharp program to read roll no, name and marks of three subjects and calculate the total, percentage and division.
int rollNo = Convert.ToInt32(Console.ReadLine());
string name1 = Console.ReadLine();
int marks1 = Convert.ToInt32(Console.ReadLine());
int marks2 = Convert.ToInt32(Console.ReadLine());
int marks3 = Convert.ToInt32(Console.ReadLine());
int total = marks1 + marks2 + marks3;
float percentage = (total / 300.0f) * 100;

if (percentage > 80)
{
    Console.WriteLine("A Grade");
}
else if (percentage > 60 && percentage < 80)
{
    Console.WriteLine("B grade");
}
else
{
    Console.WriteLine("C Grade");
}
Console.WriteLine("Roll No: " + rollNo);
Console.WriteLine("Name: " + name1);
Console.WriteLine("Total Marks: " + total);
Console.WriteLine("Percentage of marks: " + percentage);

*/

//6.Write a program that checks a customer's eligibility for a discount based on their membership level and purchase amount.
//membership levels(Gold 5%, Silver 10%, Platinum 20%) discount(if purchase amount < 100 no discount, more than 100 apply discount)

/* int  pamount=Convert.ToInt32(Console.ReadLine());
string mlevel = Console.ReadLine();

double discount = 0;

if(pamount < 100)
{
    Console.WriteLine("No Discount Applied");
}
else if(pamount > 100)
{
    Console.WriteLine("Eligible for discount, please check you discount");

    if(mlevel == "Gold")
    {
        discount = pamount * 0.05;
    }
    else if(mlevel == "Silver")
    {
        discount = pamount * 0.10;
    }
    else if(mlevel == "Platinum")
    {
        discount = pamount * 0.20;
    }
    else
    {
        Console.WriteLine("Invalid membership");
    }
    Console.WriteLine(discount);
    double finalAmount = pamount - discount;
    Console.WriteLine("Purchased Amount:" + pamount);
    Console.WriteLine("Final Payment: " + finalAmount);

}
*/

/*
int num=Convert.ToInt32(Console.ReadLine());
int sum = 0;
for( int i=0;i<num;i++)
{
    sum += num;
}
Console.WriteLine(sum);

*/
/* Summof the digits
int value = Convert.ToInt32(Console.ReadLine());
int sum_v = 0;
while(value!=0)
{
    int digit = value % 10;
    sum_v += digit;
    value=value/10;
}
Console.WriteLine(sum_v);
*/
//Write a program that takes a string input from the user and uses a loop to reverse the string.

/*
Console.Write("Enter a string: ");
string user = Console.ReadLine();

int user_len = user.Length;

Console.Write("Reversed string: ");
for (int i = user_len - 1; i >= 0; i--)
{
    Console.Write(user[i]);
}
 */

/* Write a program that uses a while loop to calculate the sum of all integers from 1 to 100.
Console.WriteLine("Enter the number:");
int num= Convert.ToInt32(Console.ReadLine());
int i = 0;
int sum = 0;
while(i<=num)
{
 sum+=i;
i++;
}
Console.WriteLine(sum);

*/

/*using do while loop, Create a game where the user has to guess a randomly generated number between 1 and 100. The program should tell the user if their guess is too high or too low and continue until they guess correctly.

Random random = new Random();
int r = random.Next(1, 100);
int guess_number;
do
{
    guess_number = Convert.ToInt32(Console.ReadLine());
    if (guess_number == 0)
    {
        Console.WriteLine("Should not nbe zero");
    }
    else if (guess_number < r)
    {
        Console.WriteLine("Its Low");
    }
    else if (guess_number > r)
    {
        Console.WriteLine("Its high");
    }
else
{

} while (guess_number != r);
    Console.WriteLine("Congratulation! you are correct");

*

/*using while loop, Write a program that counts down from a user specified number to zero.
Console.WriteLine("Enter the number:");
int num = Convert.ToInt32(Console.ReadLine());
while(num >= 0)
{
    Console.WriteLine(num);
    num--;
}
*/

/* Write a program that prints the multiplication table from 1 to 10 using nested for loops.
 
Console.WriteLine("Enter the number of tables to print:");
int n = Convert.ToInt32(Console.ReadLine());
int ii = 1;
while (ii <= n)
{
    int j = 1;
    while (j <= 10)
    {
        Console.WriteLine($"{ii} * {j} = {ii * j}");
        j++;
    }
    Console.WriteLine();
    ii++;
}

*/

/* Count Vowels and Consonants
Console.WriteLine("Enter the string");
string name = Console.ReadLine();
int vowel = 0, consonants = 0;
string ch = name.ToLower();
foreach(char c in ch)
{
    if("aeious".Contains(c))
    {
        vowel++;
    }
    else
    {
        consonants++;
    }
}
Console.WriteLine($"Vowel: {vowel}");
Console.WriteLine($"Consonants:{consonants}");
*/

/* Print Fibonacci Series

Console.WriteLine("Enter the number:");
int num = Convert.ToInt32(Console.ReadLine());
int a = 0;
int b = 1;
for(int i = 0; i < num; i++)
{
    Console.WriteLine(a);
    int c = a + b;
    a = b;
    b = c;
    
}

*/

/*
 
Count from 1 to N skipping even numbers

Console.WriteLine("Enter the number:");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 1; i< num; i++)
{
    if (i % 2 != 0)
    {
        count++;
    }
    else
    {
        continue;
    }
}
Console.WriteLine(count);

*/

/* Factorial of a Number

Console.WriteLine("Enter the factorial number:");
int num = Convert.ToInt32(Console.ReadLine());
for(int i = num - 1; i > 1; i--)
{
    num = num * i;
}
Console.WriteLine($"Result for the factorial number:" + num);

*/

/*Palindrome Checker

string name = Console.ReadLine();
string reversed = "";
for(int i = name.Length -1; i>=0;i--)
{
    reversed += name [i];
}
if(name.Equals(reversed))
{
    Console.WriteLine("Its polindrome");
}
else
{
    Console.WriteLine("Its not polindrome");
}
*/

