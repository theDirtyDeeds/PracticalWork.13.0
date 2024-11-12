using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalWork_13._0
{
    public class Client
    {
        public string Name { get; private set; }
        public NonDepositAccount NonDepositAccount { get; private set; }
        public DepositAccount DepositAccount { get; private set; }

        public Client(string name)
        {
            Name = name; // Устанавливаем имя клиента
            NonDepositAccount = new NonDepositAccount(); // Создаем недепозитный счет
            DepositAccount = new DepositAccount(); // Создаем депозитный счет
        }
    }
}
