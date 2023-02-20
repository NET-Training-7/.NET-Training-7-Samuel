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
        string[] peopleData = {
            "Ram Rana\t1998/12/12",
            "Kishan Rana\t1999/12/10",
            "Sita Rana\t1998/2/22",
            "Suju Nepal\t1998/1/30",
            "Samuel Sherpa\t1998/3/23"
        };

        var createFilePeople = $"{rootFolderPath}\\Data\\PeopleAndDOB";

        File.WriteAllLines(createFilePeople, peopleData);



        // Q2. Create 20 folder namely Folder-A,Folder-B....Folder-T

        // -- below is a difficult way
        // string folderName = "Folder-";
        // string alphabet = "ABCDEFGHIJKLMNOPQRST";
        // char[] alphaChar = (alphabet + alphabet.ToLower()).ToCharArray();
        // for (int i = 0; i < 20; i++)
        // {
        //     Directory.CreateDirectory($"{folderPathforAssignment}\\{folderName}" + alphaChar[i]);
        // }

        var folderPathforAssignment = @"E:\Broadway Infosys Teachings\Git-Tutorial\.NET-Training-7-Samuel\Fundamentals\FDHandling\Data";
        for (char i = 'A'; i <= 'T'; i++)
        {
            Directory.CreateDirectory($"{folderPathforAssignment}\\Folder-{i}");
        }

        // Q3. In Folder-A copy yesterday's text file containing story..

        var source = @"E:\Broadway Infosys Teachings\Git-Tutorial\.NET-Training-7-Samuel\Fundamentals\FDHandling\AStory.txt";
        var target = @"E:\Broadway Infosys Teachings\Git-Tutorial\.NET-Training-7-Samuel\Fundamentals\FDHandling\Data\Folder-A\Story-A1Copy.txt";
        File.Copy(source, target);


        // Q4 In Folder-B create a text file containing meta data (Size, CreateDate, etc) of that story file

        var filePath1 = @"E:\Broadway Infosys Teachings\Git-Tutorial\.NET-Training-7-Samuel\Fundamentals\FDHandling\Data\Folder-B\metadata.txt";

        var storyFilePath = @"E:\Broadway Infosys Teachings\Git-Tutorial\.NET-Training-7-Samuel\Fundamentals\FDHandling\AStory.txt";

        FileInfo fileInfos = new FileInfo(storyFilePath);
        var name = $"Name: {fileInfos.Name}";
        var size = $"Size: {fileInfos.Length}  Bytes";
        var created = $"Created: {fileInfos.CreationTime}";


        File.WriteAllText(filePath1, $"{name}\n{size}\n{created}");

    }
}