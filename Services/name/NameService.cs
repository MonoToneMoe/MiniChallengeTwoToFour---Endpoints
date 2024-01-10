namespace MiniChallengeTwoToFour___Endpoints.Services.name;
public class NameService : INameService
{
    public string Name(string name, string time)
    {
        return $"Your name is {name} and you woke up at {time}";
    }
}