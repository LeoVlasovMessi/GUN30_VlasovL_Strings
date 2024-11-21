using System.Text;

string ConcatanateStrings(string str1, string str2) 
{
    string newString = str1 + str2;
    return newString;
}

void GreetUser(string name, int age) 
{
    Console.WriteLine($"Hello, {name}!\nYou are {age} years old.");
}

string ReturnDifferentStrings(string str)
{
    string newString = str.Length.ToString();
    newString += " ";
    newString += str.ToUpper();
    newString += " ";
    newString += str.ToLower();
    return newString;
}

string FirstFiveSymbols(string str)
{
    string newString = str.Substring(0, 5);
    return newString;
}

StringBuilder BuildString(string[] strings) 
{
    StringBuilder stringBuilder = new StringBuilder();
    foreach (string str in strings)
    {
        stringBuilder.Append(str).Append(" ");
    }
    return stringBuilder;
}

string ReplaceWord(string inputString, string wordToReplace, string replacementWord) 
{
    string[] words = inputString.Split(' ');
    string newString = "";
    foreach (string word in words) 
    {
        if (word.ToLower() == replacementWord.ToLower())
        {
            newString += wordToReplace + " ";
        }
        else 
        {
            newString += word + " ";
        }
    }
    return newString;
}