using Menso.Tools.Exceptions;

namespace SaudeFit.Domain.Entities;

public class UserProfile
{
    public Guid Id { get; private set; }
    public string UserId { get; private set; } = string.Empty;
    public string Gender { get; private set; } = string.Empty;
    public int Age { get; private set; }
    public double Weight { get; private set; }
    public double Height { get; private set; }
    public double Bmi { get; private set; }
    public string Classification { get; private set; } = string.Empty;

    private UserProfile() { }

    public UserProfile(string userId, string gender, int age, double weight, double height)
    {
        Id = Guid.NewGuid();
        UserId = userId;

        ValidateData(age, weight, height);

        Gender = gender;
        Age = age;
        Weight = weight;
        Height = height;

        CalculateBmi();
    }

    public static void ValidateData(int age, double weight, double height)
    {
        Throw.When.True(age <= 0, "Age must be greater than zero.");
        Throw.When.True(weight <= 0, "Weight must be greater than zero.");
        Throw.When.True(height <= 0, "Height must be greater than zero.");
    }
    
    public void UpdateData(string gender, int age, double weight, double height)
    {
        ValidateData(age, weight, height);

        Gender = gender;
        Age = age;
        Weight = weight;
        Height = height;

        CalculateBmi();
    }

    private void CalculateBmi()
    {
        Bmi = Math.Round(Weight / (Height * Height), 2);
        Classification  = ClassifyBmi(Bmi);
    }

    private static string ClassifyBmi(double bmi)
    {
        return bmi switch
        {
            < 18.5 => "Underweight",
            < 25 => "Normal weight",
            < 30 => "Overweight",
            _ => "Obesity"
        };
    }
}