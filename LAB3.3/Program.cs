namespace LAB3._3
{
    class Parent
    {
        protected string Pole1;
        protected double Pole2;
        protected double Pole3;

        public Parent()
        {
            
        }

        public Parent(string name, double deposit, double interestRate)
        {
            Pole1 = name;
            Pole2 = deposit;
            Pole3 = interestRate;
        }

        public double Deposit
        {
            get { return Pole2; }
        }

        public void Print()
        {
            Console.WriteLine($"Iм'я: {Pole1}");
            Console.WriteLine($"Величина вкладу: {Pole2}");
            Console.WriteLine($"Ставка в%: {Pole3}");
        }

        public void Metod1()
        {
            double increase = Pole2 * (Pole3 / 100);
            Pole2 += increase;
        }
    }

    class Child : Parent
    {
        private double Pole4;

        public Child(string name, double deposit, double interestRate, double annualBonus)
            : base(name, deposit, interestRate)
        {
            Pole4 = annualBonus;
        }

        public new void Print()
        {
            base.Print();
            Console.WriteLine($"Додаткова сума щорiчно: {Pole4}");
        }

        public void Metod2()
        {
            base.Metod1();

            double annualIncrease = Pole2 * (Pole3 / 100);
            Pole2 += annualIncrease + Pole4;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Parent parentInvestor = new Parent("Iван", 10000, 5);
            Child vipInvestor = new Child("Олена", 50000, 7, 2000);

            Console.WriteLine("Батькiвський вкладник:");
            parentInvestor.Print();

            Console.WriteLine("\nVIP вкладник:");
            vipInvestor.Print();

            for (int i = 1; i <= 3; i++)
            {
                parentInvestor.Metod1();
                vipInvestor.Metod2();

                Console.WriteLine($"\nРiк {i}:");

                Console.WriteLine($"Батькiвський вкладник: Величина вкладу - {parentInvestor.Deposit}");
                Console.WriteLine($"VIP вкладник: Величина вкладу - {vipInvestor.Deposit}");
            }
        }
    }
}