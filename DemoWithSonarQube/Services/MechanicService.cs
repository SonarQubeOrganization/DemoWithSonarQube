namespace DemoWithSonarQube.Services;

public class MechanicService : IMechanicService
{
    public Task<string> GetMechanicsAsync()
    {
        return null;
    }

    public Task<IList<TypeDocumentation>> GetReportsMechanicAsync()
    {
        throw new NotImplementedException();
    }
}
