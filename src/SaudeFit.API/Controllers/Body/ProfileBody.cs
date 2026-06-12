namespace SaudeFit.API.Controllers.Body;

public record ProfileBody(
    string Gender,
    int Age,
    double Weight,
    double Height);