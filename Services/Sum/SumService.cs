namespace MiniChallengeTwoToFour___Endpoints.Services.Sum;
public class SumService : ISumService
{
    public int sum = 0;
    public string Addition(string aNum, string bNum)
    {
        int aParsed = 0;
        int bParsed = 0;

        bool aIsTrue = int.TryParse(aNum, out aParsed);
        bool bIsTrue = int.TryParse(bNum, out bParsed);
        
        if(bIsTrue == true && aIsTrue == true) {
            sum = aParsed + bParsed;
            return $"The sum of {aNum} and {bNum} is {sum}";
        }
        return "Your sum is not a number";
    }
}
