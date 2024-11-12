namespace PracticalWork_13._0
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ActionLog actionLog = new ActionLog();

            var bank = new Bank();
            var client = new Client("Иван Иванов");

            bank.AddClient(client);

            // Создадим депозитный счет
            DepositAccount myAccount = new DepositAccount();
            myAccount.OnAction += actionLog.Log; // Подписываемся на событие

            // Пополнение счета
            myAccount.Deposit(1000);

            // Создадим недепозитный счет
            NonDepositAccount nonDepositAccount = new NonDepositAccount();
            nonDepositAccount.OnAction += actionLog.Log; // Подписываемся на событие

            try
            {
                // Переводим средства
                myAccount.TransferTo(nonDepositAccount, 500);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            // Выводим записи журнала
            foreach (var log in actionLog.GetLogEntries())
            {
                Console.WriteLine(log);
            }

            DepositAccount depositAccount = new DepositAccount();
            depositAccount.OnAction += actionLog.Log; // Подписываемся на событие для нового деп. счета
            depositAccount.Deposit(1000); // Пополняем депозитный счет

            try
            {
                depositAccount.TransferTo(nonDepositAccount, 200); // Переводим деньги на недепозитный счет
                Console.WriteLine("Перевод выполнен успешно.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.WriteLine($"Баланс депозитного счета: {depositAccount.Balance}");
            Console.WriteLine($"Баланс недепозитного счета: {nonDepositAccount.Balance}");
        }
    }
}
