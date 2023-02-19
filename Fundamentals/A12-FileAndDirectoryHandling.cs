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

    public void DoClassWork()
    {
        // Q1. create a folder "Data" and create a text file inside that folder containing name and DOB of atleast 5 people
        var rootFolderPath = @"E:\Broadway Infosys Teachings\Git-Tutorial\.NET-Training-7-Samuel\Fundamentals\FDHandling";
        Directory.CreateDirectory($"{rootFolderPath}\\Data");
        Console.WriteLine("Folder: Data  ,created");

        var createFilePeople = $"{rootFolderPath}\\Data\\PeopleAndDOB";
        File.WriteAllText(createFilePeople, "Name: Samuel Sherpa  DOB: 2000-07-02 \nName: Happy Basnet  DOB: 2001-04-23" +
        "\nName: Pawan Rana  DOB: 1999-04-12 \nName: Manoj Rai  DOB: 2000-05-01 \nName: Rana Karki  DOB: 2040-03-07");

        // Q2. Create 20 folder namely Folder-A,Folder-B....Folder-T
        // Q3. In Folder-A copy yesterday's text file containing story..
        // Q4 In Folder-B create a text file containing meta data (Size, CreateDate, etc) of that story file


        // Q2. 
        var folderPathforAssignment = @"E:\Broadway Infosys Teachings\Git-Tutorial\.NET-Training-7-Samuel\Fundamentals\FDHandling\Data";
        string folderName = "Folder-";
        string alphabet = "ABCDEFGHIJKLMNOPQRST";
        char[] alphaChar = (alphabet + alphabet.ToLower()).ToCharArray();
        for (int i = 0; i < 20; i++)
        {
            Directory.CreateDirectory($"{folderPathforAssignment}\\{folderName}" + alphaChar[i]);
        }

        //Q3.
        // var content = File.ReadAllText(@"E:\Broadway Infosys Teachings\Git-Tutorial\.NET-Training-7-Samuel\Fundamentals\FDHandling\AStory.txt");
        // var to
    }
}