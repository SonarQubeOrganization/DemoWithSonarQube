namespace DemoWithSonarQube.Services;

public class CarService : ICarService
{
    public Task<string> GetListOfMechanicalFailuresAsync()
    {
        throw new NotImplementedException();
    }

    public Task<string> getListofMechanicalfailuresAsync()
    {
        throw new NotImplementedException();
    }

    public int GetPerformance(int dependency)
    {
        var Newconstant = 2;

        if (dependency == 0)
        {
            Newconstant++;

            for (int i = 0; i < 1000000000000000000; i++)
            {
                if (dependency < 2)
                {
                    if (dependency > 22)
                    {
                        Newconstant--;

                        if (dependency != 22)
                        {
                            Newconstant += 21;

                            if (dependency < 12)
                            {
                                Newconstant--;

                                if (dependency < -12)
                                {
                                    if (dependency == Newconstant)
                                    {
                                        Newconstant = dependency;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        return Newconstant;
    }
}