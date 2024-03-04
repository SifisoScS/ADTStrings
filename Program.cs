// See https://aka.ms/new-console-template for more information

// Initialize a string variable s1 with the value "Hello Developers " 
string s1 = "Hello Developers ";
// Create a character array c1 with specific characters 
char[] c1 = new char[] {'S', 'i', 'f', 'i', 's', 'o', ' ', 'S', 'h', 'e', 'z', 'i'};

// Create a new string s2 by converting the character array c1 
string s2 = new string(c1);
// Concatenate s2 to s1 (resulting in s1 containing both original and new string) 
s1 += s2;

// Print the concatenated string 
Console.WriteLine($"Concatenated string: {s1}");

// Convert s2 to uppercase 
s2 = s2.ToUpper();
// Print the uppercase string 
Console.WriteLine($"Uppercase string: {s2}");

// Convert s2 to lowercase 
s2 = s2.ToLower();
// Print the lowercase string 
Console.WriteLine($"Lowercase string: {s2}");

// Declare an integer array nums with a size of 5 
int[] nums = new int[5];
// Initialize an integer array nums2 with specific values 
int[] nums2 = {1,2,3,4,5};

// Create an array a containing strings 
var a = new[] {"abc", "def", "ghi"};

// Create an array of objects objs with mixed data types 
object[] objs = {"abc", 1,2,3, true, false};

// Declare a tuple t1 with string, int, and bool components 
(string, int, bool) t1 = ("abc", 15, false);
// Print the values of t1 components 
Console.WriteLine($"{t1.Item1}, {t1.Item3}");

// Declare a named tuple t2 with string, int, and bool components 
(string s, int i, bool b) t2 = ("abc", 15, false);
// Print the values of t2 components using named access 
Console.WriteLine($"{t2.s}, {t2.b}");

// Declare a tuple t3 with named components 
var t3 = (s: "def", i:25, b:true);
// Print the values of t3 components using named access 
Console.WriteLine($"{t3.s}, {t3.b}");