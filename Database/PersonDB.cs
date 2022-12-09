using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    static class PersonDB
    {
        static public void AddPersonDB(string fio,int age,string workplace)
        {
            DB db = new DB();    

            db.opencont();

            MySqlCommand command = new MySqlCommand("INSERT INTO `persondb` ( `fio`, `age`, `workplace`) VALUES ( @fio, @age, @workp)", db.getconnector());

            command.Parameters.Add("@fio", MySqlDbType.VarChar).Value = fio;
            command.Parameters.Add("@age", MySqlDbType.VarChar).Value =age;
            command.Parameters.Add("@workp", MySqlDbType.VarChar).Value = workplace;           

            command.ExecuteNonQuery();
            
            db.closecont();

           
        }

        static public void CreatureScore(int ID, ref bool check, int balance=0)// добавление счета
        {
            DB db = new DB();
            DataTable table = new DataTable();
            db.opencont();
            MySqlDataAdapter adapt = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT `id` FROM `persondb` WHERE `id` = @ip", db.getconnector());
            command.Parameters.Add("@ip", MySqlDbType.VarChar).Value = ID;

            adapt.SelectCommand = command;// какую команду выполнить
            adapt.Fill(table);// временная переменная для этих данных  


            MySqlCommand command2 = new MySqlCommand("INSERT INTO `scoredb` ( `id`,`balance`) VALUES ( @ip , @balance)", db.getconnector());

            if (table.Rows.Count > 0) 
            {
                command2.Parameters.Add("@ip", MySqlDbType.VarChar).Value = ID;
                command2.Parameters.Add("@balance", MySqlDbType.VarChar).Value = balance;
                command2.ExecuteNonQuery(); 
                check = true;
                
            }

            db.closecont();


        }
        static public void RemoveScore(int ID, int IDscore2)//  Удаление счета
        {

            DB db = new DB();

            db.opencont();

            MySqlCommand command = new MySqlCommand("DELETE FROM `scoredb` WHERE `scoredb`.`idscore` = @iss AND `scoredb`.`id` = @ip", db.getconnector());

            command.Parameters.Add("@iss", MySqlDbType.VarChar).Value = IDscore2;
            command.Parameters.Add("@ip", MySqlDbType.VarChar).Value = ID;

            command.ExecuteNonQuery();

            db.closecont();

        }
        static public void TakeMoneyFromScore(int ID, int IDscore2, int removesumm, ref bool check, ref int newBalance)// снятие денег
        {

            DB db = new DB();
            DataTable table = new DataTable();
            db.opencont();
            MySqlDataAdapter adapt = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT `balance` FROM `scoredb` WHERE `idscore` = @iss AND `id` = @ip", db.getconnector());
            command.Parameters.Add("@iss", MySqlDbType.VarChar).Value = IDscore2;
            command.Parameters.Add("@ip", MySqlDbType.VarChar).Value = ID;

            adapt.SelectCommand = command;// какую команду выполнить
            adapt.Fill(table);// временная переменная для этих данных  

            MySqlCommand command2 = new MySqlCommand("UPDATE `scoredb` SET `balance` = @balancee WHERE `scoredb`.`idscore` = @iss AND `scoredb`.`id` = @ip", db.getconnector());
            command2.Parameters.Add("@iss", MySqlDbType.VarChar).Value = IDscore2;
            command2.Parameters.Add("@ip", MySqlDbType.VarChar).Value = ID;

            if (table.Rows.Count > 0) 
            {
                if (removesumm <= Convert.ToInt32(command.ExecuteScalar().ToString()))
                {
                    newBalance = (Convert.ToInt32(command.ExecuteScalar().ToString())) - removesumm;
                    command2.Parameters.Add("@balancee", MySqlDbType.VarChar).Value = newBalance;
                    command2.ExecuteNonQuery();// ExecuteNonQuery
                    check = true;
                }
            }

            db.closecont();


        }
        static public void AddMoneyForScore(int ID, int IDscore2, int additionsumm,ref string vrrrrr)// добавление денег
        {
            int Receivebalancee;
            DB db = new DB();
            DataTable table = new DataTable();
            db.opencont();
            MySqlDataAdapter adapt = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT `balance` FROM `scoredb` WHERE `idscore` = @iss AND `id` = @ip", db.getconnector());
            command.Parameters.Add("@iss", MySqlDbType.VarChar).Value = IDscore2;
            command.Parameters.Add("@ip", MySqlDbType.VarChar).Value = ID;
            adapt.SelectCommand = command;// какую команду выполнить
            adapt.Fill(table);// временная переменная для этих данных  

            MySqlCommand command2 = new MySqlCommand("UPDATE `scoredb` SET `balance` = @balancee WHERE `scoredb`.`idscore` = @iss AND `scoredb`.`id` = @ip", db.getconnector());
            command2.Parameters.Add("@iss", MySqlDbType.VarChar).Value = IDscore2;
            command2.Parameters.Add("@ip", MySqlDbType.VarChar).Value = ID;
            
            if (table.Rows.Count > 0) 
            {
                Receivebalancee = (Convert.ToInt32(command.ExecuteScalar().ToString())) + additionsumm;
                command2.Parameters.Add("@balancee", MySqlDbType.VarChar).Value = Receivebalancee;
                command2.ExecuteNonQuery();
                vrrrrr =Convert.ToString(Receivebalancee); 
            }

            db.closecont();



        }

        static public void ReceiveBalance(int ID, int IDscore2, ref int Receivebalancee,ref bool check)///Проверка баланса
        {
 
            DB db = new DB();
            DataTable table = new DataTable();
            db.opencont();
            MySqlDataAdapter adapt = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT `balance` FROM `scoredb` WHERE `idscore` = @iss AND `id` = @ip", db.getconnector());        
            command.Parameters.Add("@iss", MySqlDbType.VarChar).Value = IDscore2;
            command.Parameters.Add("@ip", MySqlDbType.VarChar).Value = ID;
   
            adapt.SelectCommand = command;// какую команду выполнить

            adapt.Fill(table);// временная переменная для этих данных
            if (table.Rows.Count > 0) 
            {
                Receivebalancee = Convert.ToInt32(command.ExecuteScalar().ToString()); ;
                check = true;
            }
            db.closecont();

        }

    }



}
