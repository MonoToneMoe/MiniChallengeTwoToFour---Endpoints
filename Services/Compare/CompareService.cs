namespace MiniChallengeTwoToFour___Endpoints.Services.Compare;
public class CompareService : ICompareService
{
    public string Compare(string numA, string numB) {
        int aParsed = 0;
        int bParsed = 0;

        bool aIsTrue = int.TryParse(numA, out aParsed);
        bool bIsTrue = int.TryParse(numB, out bParsed);

        if(aIsTrue == true && bIsTrue == true) {
            if(aParsed < bParsed){
                return $"{numA} is less than {numB}. {numB} is greater than {numA}";
            } else if(aParsed > bParsed) {
                return $"{numA} is greater than {numB}. {numB} is less than {numA}.";
            } else {
                return $"{numA} is equal to {numB}. {numB} is equal to {numA}.";
            }
        }
        return "One or more of your inputs is not a number";
    }
}