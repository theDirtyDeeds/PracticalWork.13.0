using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork_13._0
{
    public class Bank
    {
        private List<Client> clients;

        public Bank()
        {
            clients = new List<Client>(); // Инициализируем список клиентов
        }

        public void AddClient(Client client)
        {
            clients.Add(client); // Добавляем нового клиента
        }

        public void DepositToAccount(Client client, bool isDepositAccount, decimal amount)
        {
            if (isDepositAccount)
            {
                client.DepositAccount.Deposit(amount); // Пополняем депозитный счет
            }
            else
            {
                throw new InvalidOperationException("Недепозитный счет не может быть пополнен."); // Исключение для недепозитного счета
            }
        }
    }
}
