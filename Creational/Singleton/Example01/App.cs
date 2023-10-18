using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso_design_patterns.Creational.Singleton.Example01
{
    public class App
    {
        public void Run()
        {
            var connectionPool1 = ConnectionPool.CreateInstance(2);
            var connectionPool2 = ConnectionPool.CreateInstance(2);

            if (connectionPool1 == connectionPool2)
                Console.WriteLine("Mesma instância!");

            connectionPool1.GetConnection();
            connectionPool1.GetConnection();
            connectionPool2.GetConnection();
        }
    }
}
