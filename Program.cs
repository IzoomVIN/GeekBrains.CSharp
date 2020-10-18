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

            //hw.BMIwithRec();
            //hw.GoodNumbers();

            hw.AllNumFromAtoB(2, 4);
            hw.SumNumFromAtoB(3, 6);
        }
    }
}
