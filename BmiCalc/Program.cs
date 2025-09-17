namespace BmiCalc
{
    internal class Program
    {
        static double CalculateBMI(double weight, double height, string unit = "metric")
        {
            if (unit == "metric")
            {
                return weight / (height * height);
            }
            else if (unit == "imperial")
            {
                return 703 * (weight / (height * height)); // använder ej dessa
            }
            else
            {
                Console.WriteLine("Okänd enhet, returnerar 0"); //använder ej dessa
                return 0;
            }
        }
        
        static void Main(string[] args)
        {

            Console.WriteLine("Välkommen till BMI-kalkylatorn!");
            Console.Write("Ange din vikt: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ange din längd: ");
            double height = Convert.ToDouble(Console.ReadLine());
            if (weight <= 0 || height <= 0)
            {
                Console.WriteLine("Fel Vikt och längd båda värden måste var större än 0");
                return;
            }
            Console.WriteLine($"BMI (metriska enheter): {CalculateBMI(weight, height, "metric")}");
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"BMI (metriska enheter använder named arguments här): {CalculateBMI(height: height, weight: weight)}"); //ändrat ordningen med named arguments
         
        }
    }
}



