using System;
using System.IO;

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
        var content = File.ReadAllText(filePath);
        Console.WriteLine(content);
    }
}