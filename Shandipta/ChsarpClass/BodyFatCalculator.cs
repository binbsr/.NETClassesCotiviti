/*BODY FAT PERCENTAGE: CLASSIFICATION - MEN
   Under 5%: Low Body Fat Risk.
   5%-8%: Ultra Lean. 
   8%-12%: Lean. 
   12%-20%: Moderately Lean.
   20%-30%: Excess Fat.
   Above 30%: High Body Fat Risk.*/

/*BODY FAT PERCENTAGE: CLASSIFICATION - WOMEN
Under 15%: Low Body Fat Risk.
15%-18%: Ultra Lean. 
18%-22%: Lean. 
22%-30%: Moderately Lean.
30%-40%: Excess Fat.
Above 40%: High Body Fat Risk.*/
/*Metric BMI Formula
 BMI = weight (kg) / [height (m)]2
e.g. BMI = 75 ÷ (1.8 × 1.8)
Body Fat Percentage Formula Using the BMI
Fat = (1.20 x BMI) + (0.23 x Age) - (10.8 x sex) - 5.4
in case of the BMI estimation formula, sex is 1 for males and 0 for females.
*/
using System;
namespace HealthAndFitness


{

    public class BodyFatCaclulator
    {
        private string gender, fatPercentageCategory;
        private float bmi, heightInMeter, weightInKg;
        private string nl = Environment.NewLine;
        //Default Constructor
        public BodyFatCaclulator()
        {

            Console.WriteLine("This system will calculate your body fat percentage based on your age, gender, height, weight and BMI.");
        }

        //Parameterized constructor
        public BodyFatCaclulator(float heightInMeter, float weightInKg) : this()
        {
            this.heightInMeter = heightInMeter;
            this.weightInKg = weightInKg;

        }

        //auto-implemented properties
        public int Age { get; set; }
        public string Gender { get; set; }
        public int GenderFlag { get; set; }

        public float BMICalculator
        {
            get
            {
                return bmi = (float)(Math.Round(weightInKg / (heightInMeter * heightInMeter), 2));
            }

        }

        //Method that returns auto implemented properties     
        public string PersonHealthDetail(float bmiValue)
        {
            return $"Personal detail:{nl}Age: {Age}{nl}Gender: {Gender}{nl}Height: {heightInMeter}m{nl}Weight: {weightInKg}kg{nl}Based on above detail your Body Mass Index (BMI) is {bmiValue}%";


        }
        public float BodyFatCalculation
        {
            get
            {
                return
               (float)(Math.Round((float)(1.20f * bmi) + (0.23f * Age)
               - (10.8f * GenderFlag) - 5.4f, 2));
            }

        }

        public string BodyFatResultEvaluationFemale
        {

            get
            {

                if (BodyFatCalculation < (int)fatPercentangeRangeFemale.UltraLeanMin)
                {
                    fatPercentageCategory = $"Based on your BMI {bmi}% Your body fat percentage is {BodyFatCalculation}% which is very low.";

                }
                else if (BodyFatCalculation >= (int)fatPercentangeRangeFemale.UltraLeanMin && BodyFatCalculation <= (int)fatPercentangeRangeFemale.UltraLeanMin)
                {
                    fatPercentageCategory = $"Based on your BMI {bmi}% Your body fat percentage is {BodyFatCalculation}% which means you are UltraLean.";
                }
                else if (BodyFatCalculation >= (int)fatPercentangeRangeFemale.LeanMin && BodyFatCalculation <= (int)fatPercentangeRangeFemale.LeanMax)
                {
                    fatPercentageCategory = $"Based on your BMI {bmi}% your body fat percentage is {BodyFatCalculation}% which means your are Lean.";
                }
                else if (BodyFatCalculation >= (int)fatPercentangeRangeFemale.ModeratelyLeanMin && BodyFatCalculation <= (int)fatPercentangeRangeFemale.ModeratelyLeanMax)
                {
                    fatPercentageCategory = $"Based on your BMI {bmi}% Your body fat percentage is {BodyFatCalculation}% which means you are Moderately Lean.";
                }
                else { fatPercentageCategory = $"Based on your BMI {bmi}% Your body fat percentage is {BodyFatCalculation}% which is very high."; }
                return fatPercentageCategory;
            }
        }


        public string BodyFatResultEvaluationMale
        {
            get
            {
                if (BodyFatCalculation < (int)fatPercentangeRangeMale.UltraLeanMin)
                {
                    fatPercentageCategory =
                     $"Based on your BMI {bmi}% Your body fat percentage is {BodyFatCalculation}% which is very low.";

                }
                else if (BodyFatCalculation >= (int)fatPercentangeRangeMale.UltraLeanMin && BodyFatCalculation <= (int)fatPercentangeRangeMale.UltraLeanMin)
                {
                    fatPercentageCategory
                    = $"Based on your BMI {bmi}% Your body fat percentage is {BodyFatCalculation}% which means you are UltraLean.";
                }
                else if (BodyFatCalculation >= (int)fatPercentangeRangeMale.LeanMin && BodyFatCalculation <= (int)fatPercentangeRangeMale.LeanMax)
                {
                    fatPercentageCategory =
                    $"Based on your BMI {bmi}% your body fat percentage is {BodyFatCalculation}% which means your are Lean.";
                }
                else if (BodyFatCalculation >= (int)fatPercentangeRangeMale.ModeratelyLeanMin && BodyFatCalculation <= (int)fatPercentangeRangeMale.ModeratelyLeanMax)
                {
                    fatPercentageCategory = $"Based on your BMI {bmi}% Your body fat percentage is {BodyFatCalculation}% which means you are Moderately Lean.";
                }
                else { fatPercentageCategory = $"Based on your BMI {bmi}% Your body fat percentage is {BodyFatCalculation}% which is very high."; }
                return fatPercentageCategory;
            }
        }

        enum fatPercentangeRangeFemale : int
        {
            UltraLeanMin = 15, UltraLeanMx = 18, LeanMin = 18, LeanMax = 22,
            ModeratelyLeanMin = 22, ModeratelyLeanMax = 30, ExcessFatMin = 30, ExcessFatMax = 40
        };
        enum fatPercentangeRangeMale : int
        {
            UltraLeanMin = 5, UltraLeanMx = 8, LeanMin = 8, LeanMax = 12,
            ModeratelyLeanMin = 12, ModeratelyLeanMax = 20, ExcessFatMin = 20, ExcessFatMax = 30
        };

    }
}