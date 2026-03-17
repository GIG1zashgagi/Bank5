using System;

namespace BankAccountNS
{
    public class BankAccount
    {
        private readonly string m_customerName;
        private double m_balance;

        private BankAccount() { }

        /// <param name="customerName">Имя владельца счета</param>
        /// <param name="balance">Начальный баланс счета</param>
        public BankAccount(string customerName, double balance)
        {
            m_customerName = customerName;
            m_balance = balance;
        }

        public string CustomerName
        {
            get { return m_customerName; }
        }

        public double Balance
        {
            get { return m_balance; }
        }

        /// <param name="amount">Сумма для снятия</param>
        /// <exception cref="System.ArgumentOutOfRangeException">
    
        public void Debit(double amount)
        {
            if (amount > m_balance)
            {
                throw new System.ArgumentOutOfRangeException("amount", amount,
                    "Сумма снятия превышает баланс");
            }

            if (amount < 0)
            {
                throw new System.ArgumentOutOfRangeException("amount", amount,
                    "Сумма снятия не может быть отрицательной");
            }

            m_balance -= amount; 
        }

        /// <param name="amount">Сумма для внесения</param>
        /// <exception cref="System.ArgumentOutOfRangeException">

        public void Credit(double amount)
        {
            if (amount < 0)
            {
                throw new System.ArgumentOutOfRangeException("amount", amount,
                    "Сумма внесения не может быть отрицательной");
            }

            m_balance += amount;
        }

        public static void Main()
        {
            BankAccount ba = new BankAccount("Mr. Roman Abramovich", 11.99);
            ba.Credit(5.77);
            ba.Debit(11.22);
            Console.WriteLine("Current balance is ${0}", ba.Balance);
            Console.ReadLine();
        }

    }
}