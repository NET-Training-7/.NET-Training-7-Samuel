using System;
using System.IO;
using System.Text.RegularExpressions;

namespace IO;
class FDHandling
{
    public void LearnFiles()
    {
        // create new file
        var rootFolder = @"E:\Broadway Infosys Teachings\Git-Tutorial\.NET-Training-7-Samuel\Fundamentals\FDHandling";
        var filePath = $"{rootFolder}\\firstFile.txt";
        File.WriteAllText(filePath, "My name is Sanuel Sherpa..I like playing Futsal⚽.");
        Console.WriteLine(" File Created");



        var folderPath = $"{rootFolder}\\Nepal";
        Directory.CreateDirectory(folderPath);
        Console.WriteLine("Folder Nepal Created Succesfully");


        // create a text file "countries.txt" with at least of 5 country names
        var countryPath = $"{rootFolder}\\Nepal\\countries.txt";
        File.WriteAllText(countryPath, "Nepal \nIndia \nChina \nUSA \nNew Zealand \nScotland");
        Console.WriteLine("countries.txt file created.");
    }

    public void LearnMoreAboutFileHandling()
    {
        var filePath = @"E:\Broadway Infosys Teachings\Git-Tutorial\.NET-Training-7-Samuel\Fundamentals\FDHandling\AStory.txt";
        var testFilePath = @"E:\Broadway Infosys Teachings\Git-Tutorial\.NET-Training-7-Samuel\Fundamentals\FDHandling\TestWord.txt";
        var content = File.ReadAllText(filePath);
        var testContent = File.ReadAllText(testFilePath);

        // Find following in above file content:-

        // - No. of sentences and their list
        char[] separators = { '.', ',', '?' };
        string[] parts = content.Split(separators);
        // Console.WriteLine($"There are {parts.Length} sentences present in the story.");
        // foreach (var item in parts)
        // {
        //     Console.WriteLine(item);
        // }

        // - No of words and their list
        char[] wordSeparator = { ' ' };
        string[] wordPart = content.Split(wordSeparator);
        // Console.WriteLine($"There are {wordPart.Length} words in the story.");
        // foreach (var item in wordPart)
        // {
        //     Console.WriteLine(item);
        // }

        // - No of characters and their list
        string FileText = content.Replace("\r\n", "\r");
        int CharCount = FileText.Length;
        // Console.WriteLine("The total number of characters present in the content is: " + CharCount);
        // foreach (var item in FileText)
        // {
        //     Console.WriteLine(item);
        // }


        // - No of special characters and their list
        Regex regex = new Regex("[^a-zA-z0-9]");
        MatchCollection matches = regex.Matches(content);
        // Console.WriteLine("Special characters found:");
        // foreach (Match match in matches)
        // {
        //     Console.WriteLine(match.Value);
        // }
    }
}