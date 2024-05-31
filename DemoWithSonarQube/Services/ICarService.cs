namespace DemoWithSonarQube.Services;

public interface ICarService
{
    public Task<string> GetListOfMechanicalFailuresAsync();

    public Task GetPerformance();
}
