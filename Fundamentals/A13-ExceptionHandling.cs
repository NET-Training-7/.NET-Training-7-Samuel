using System;
using System.IO;

class ExceptionHandling
{
    public void CreateNewFile()
    {
        FileStream stream = default;
        try
        {
            var folderPath = @"E:\Broadway Infosys Teachings\Git-Tutorial\.NET-Training-7-Samuel\Fundamentals\FDHandling1";
            var file = "abc.me";
            var fileFullPath = $"{folderPath}\\{file}";


            if (!Directory.Exists(folderPath))
            {
                throw new IOException("FDDHandling1 folder doesn't exist !!");
            }


            stream = File.Create(fileFullPath);
            stream.WriteByte(45);

        }
        catch (IOException ex)
        {
            Console.WriteLine($"Can't create new file.:{ex.Message}");

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Can't create new file.\nGeneric Error:{ex.Message}");

        }

        finally
        {
            stream.Close();
        }
    }

    public void DoClassWork()
    {
        // Write a code to calculate remaining for upcoming holi festival        // "Holi" festival
        // Write try/catch block to handle possible error
        // And finally greet user with "Happy Holi"
        try
        {
            DateTime holiDate = new(2023, 03, 18);
            var remainingDays = (holiDate - DateTime.Now).Days;
            Console.WriteLine($"{remainingDays} days are remaining for holi");


        }

        catch (FormatException ex)
        {
            Console.WriteLine($"Invalid Datetime format.\n{ex.Message}");
        }

        catch (Exception ex)
        {
            Console.WriteLine($"Entered Date time is out of range.\n{ex.Message}");
        }
        finally
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("HAPPY");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" HOLI !!");

            Console.ResetColor();
        }
    }
}