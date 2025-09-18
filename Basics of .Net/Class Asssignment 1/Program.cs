namespace Class_Assessment_1
{
    internal class Program
    {
        static int bank_account_number = 0;
        static string account_holder_name = "";

        static void Main(string[] args)
        {
            int amount = 0;

            while (true)
            {
                try
                {
                    int choice = ShowInstruction();
                    if (choice == 1)
                    {
                        var result = SetBankAccountNumber();
                        if (result.newBankAccountNumber != bank_account_number)
                        {
                            bank_account_number = result.newBankAccountNumber;
                            account_holder_name = result.accountHoldername; 
                            Console.WriteLine("Account created successfully");
                        }
                        else
                        {
                            Console.WriteLine("Account already exists");
                        }
                    }
                    else if (choice == 2 && bank_account_number != 0)
                    {
                        int depositAmount = AddDeposit();
                        amount = amount + depositAmount;
                    }
                    else if (choice == 3 && bank_account_number != 0)
                    {
                        int withdrawAmount = WithdrawMoney();
                        if (withdrawAmount > amount)
                        {
                            Console.WriteLine("Not enough money in account");
                        }
                        else
                        {
                            amount = amount - withdrawAmount;
                            Console.WriteLine($"Rs. {withdrawAmount} withdrawn");
                        }
                    }
                    else if (choice == 4 && bank_account_number != 0)
                    {
                        Console.WriteLine($"Bank account Number: {bank_account_number}");
                        Console.WriteLine($"Bank account Holder Name: {account_holder_name}");
                        Console.WriteLine($"Account Balance: {amount}");
                    }
                    else if (choice == 5)
                    {
                        Console.WriteLine("Exited");
                        break;
                    }
                    else if (bank_account_number == 0 && choice >= 1 && choice <= 5)
                    {
                        Console.WriteLine("No bank account");
                    }
                    else
                    {
                        Console.WriteLine("Wrong Choice. Try again");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }

        static int ShowInstruction()
        {
            Console.WriteLine("Make your choice:");
            Console.WriteLine("1. Create a new bank account");
            Console.WriteLine("2. Deposit money");
            Console.WriteLine("3. Withdraw money");
            Console.WriteLine("4. Display account details");
            Console.WriteLine("5. Exit");
            
            return Convert.ToInt32(Console.ReadLine());
        }

        static (int newBankAccountNumber, string accountHoldername) SetBankAccountNumber()
        {
            Console.WriteLine("Enter Bank Account Number: ");
            int newBankAccountNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Bank Account holder name: ");
            string accountHoldername = Console.ReadLine();
            return (newBankAccountNumber, accountHoldername);
        }

        static int AddDeposit()
        {
            Console.WriteLine("Enter Deposit Amount: ");
            int amountAdded = Convert.ToInt32(Console.ReadLine());
            return amountAdded;
        }

        static int WithdrawMoney()
        {
            Console.WriteLine("Enter Withdraw Amount: ");
            int WithdrawAmount = Convert.ToInt32(Console.ReadLine());
            return WithdrawAmount;
        }
    }
}