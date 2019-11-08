namespace DotnetHomeWorks
{
    public class GenderCount
    {

        public (int, int, int) DisplayCount()
        {
            char?[] genderCollection = new char?[] { 'F', 'M', 'F', 'M', null, 'M', null, 'F', 'F', 'M', null, null, 'F', 'M', 'M' };

            int countMale = 0;
            int countFemale = 0;
            int countOthers = 0;

            foreach (char? gender in genderCollection)
            {
                if (gender == 'M')
                {
                    countMale++;
                }
                else if (gender == 'F')
                {
                    countFemale++;
                }
                else
                {
                    countOthers++;
                }
            }
            return (countMale, countFemale, countOthers);
        }
    }

}