using System.ComponentModel.Design;

Console.WriteLine("Enter the number of words");
int n = Convert.ToInt32(Console.ReadLine());

string[] str = new string[n];
for (int i = 0; i < str.Length; i++)
{
    str[i] = Console.ReadLine();
}
string small = str[0];

for(int i = 1; i < n;i++)
{
    if (str[i].Length < small.Length)
    {
        small = str[i];
    }
}
Console.WriteLine($"The Shortest word in an array is {small}");
Console.WriteLine();


// 2nd Program

Console.WriteLine("Enter the word to check if it is present");
string s1 = Console.ReadLine();
bool isPresent = false;

foreach (string word in str)
{
    if (word.ToLower() == s1.ToLower())
    {
        isPresent = true;
        break;
    }
}

if (isPresent)
{
    Console.WriteLine("The word is present in the list");
}
else
{
    Console.WriteLine("The word is not present in the list");
}
Console.WriteLine();


// 3rd Program

Array.Sort(str);

Console.WriteLine("The sorted array is:");

for (int i = 0; i < n; i++)
{
    Console.WriteLine((i + 1) + ". " + str[i]);
}
Console.WriteLine();

// 4th Program

string[] s2 = { "racecar", "level", "hello", "world", "madam" };
int palindromeCount = 0;

Console.WriteLine("Palindrome words:");
foreach (string word in s2)
{
    bool isPalindrome = true;
    int length = word.Length;

    for (int i = 0; i < length / 2; i++)
    {
        if (word[i] != word[length - i - 1])
        {
            isPalindrome = false;
            break;
        }
    }

    if (isPalindrome)
    {
        Console.WriteLine(word);
        palindromeCount++;
    }
}

Console.WriteLine("The Number of palindrome words in the list is: " + palindromeCount);
Console.WriteLine();    

