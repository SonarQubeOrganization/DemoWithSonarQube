namespace DemoWithSonarQube.Services;

public interface IMechanicService
{
    public Task<string> GetMechanicsAsync();
    public Task<IList<TypeDocumentation>> GetReportsMechanicAsync();
}
