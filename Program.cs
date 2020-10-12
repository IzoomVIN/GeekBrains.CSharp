namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            var hw = new Homework2();

            //hw.MinOfThree();

            //int number = int.Parse(Support.GetFromUser("Enter number:"));
            //System.Console.WriteLine($"Number of digits = {hw.NumberOfDigitsInNumber(number)}");
            //Support.Pause();

            //if(hw.LogIn()) hw.SumOfOddNumbers();

            hw.BMIwithRec();
        }
    }
}
