using System;
class Assignments_Methods
{

    // Method to calculate product of square of two supplied number
    public double CalculateProductOfSquare(double first, double second)
    {
        double productSum = (first * first) * (second * second);
        return productSum;
    }

    // Method to calculate cubroot of a number
    public double CalculateCubeRoot(double num)
    {
        double cubeValue = Math.Cbrt(num);
        return cubeValue;
    }

    //Method to calculate BMI index of a person

    // <18.5 underweight
    // 18.5 < weight < 24.9
    // >=25 and <= 39.9

    public string CalculateBMI(float weight, float height)
    {
        float heightInm = height * 0.3048f;
        float bmi = (weight / (heightInm * heightInm));
        string message = string.Empty;
        
        if(bmi < 18.5)
        {
            message = "You are underweight.";
            
        }
        else if(bmi<25)
        {
            message = "You are normal, Congratulations !!";
        }
        else if(bmi < 40)
        {
            message = "You are over weightm, let's exercise together.";
        }
        else
        {
            message = "You are Obese, do exercise to live.";
        }
        return message;
    }
}