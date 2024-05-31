namespace DemoWithSonarQube.Services;

public interface ICarService
{
    public Task<string> getListofMechanicalfailuresAsync();

    public int GetPerformance(int dependency);



}
