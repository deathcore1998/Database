using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    class DB// Класс для работы с базой данных
    {
        //Подключение к хосту и выбор базы данных
        MySqlConnection connector = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=persondatabase");

        public void opencont()// Подключение к базе данных
        {
            if (connector.State == System.Data.ConnectionState.Closed)
            {
                connector.Open();
            }

        }

        public void closecont()// Отключение от базы данных
        {
            if (connector.State == System.Data.ConnectionState.Open)
            {
                connector.Close();
            }

        }

        public MySqlConnection getconnector()// Проверка состояния базы данных
        {
            return connector;
        }

    }
}
