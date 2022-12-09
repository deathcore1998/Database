using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database
{
  
    public partial class CreatureScore : Form
       
    { 

        public CreatureScore()
        {
            
            InitializeComponent();
            indexPersonScore.Text = "Введите индекс пользователя";
            IndexForAction.Text = "Введите индекс счета, с которым будут выполнены действия";
            ValueForAddMoney.Text = "Введите сумму пополнения";
            ValueForTakeMoney.Text = "Ввведите какую сумму снять";
            balanceNewScore.Text = "";



        }

        private void AddNewScore_Click(object sender, EventArgs e)
        {
            bool check = false;
            if (indexPersonScore.Text != "Введите индекс пользователя")
            {
                if (balanceNewScore.Text == "")
                    
                    PersonDB.CreatureScore(Convert.ToInt32(indexPersonScore.Text),ref check);

                else
                    PersonDB.CreatureScore(Convert.ToInt32(indexPersonScore.Text),ref check, Convert.ToInt32(balanceNewScore.Text));

                balanceNewScore.Text = "";
            }
            else
                MessageBox.Show("Введите индекс пользователя!");

            if (check == true)
            {
                MessageBox.Show("Счет успешно создан");
            }
            else
            {
                MessageBox.Show("Счет не создан, введен несуществующий ID");
            }
        }

        private void IndexForAction_Enter(object sender, EventArgs e)
        {
            if (IndexForAction.Text == "Введите индекс счета, с которым будут выполнены действия")
            IndexForAction.Text = "";
        }

        private void IndexForAction_Leave(object sender, EventArgs e)
        {
            if (IndexForAction.Text == "")
                IndexForAction.Text = "Введите индекс счета, с которым будут выполнены действия";
        }

        private void ValueForAddMoney_Enter(object sender, EventArgs e)
        {
            if (ValueForAddMoney.Text == "Введите сумму пополнения")
                ValueForAddMoney.Text = "";
        }

        private void ValueForAddMoney_Leave(object sender, EventArgs e)
        {
            if (ValueForAddMoney.Text == "")
                ValueForAddMoney.Text = "Введите сумму пополнения";
        }

        private void ValueForTakeMoney_Leave(object sender, EventArgs e)
        {
            if (ValueForTakeMoney.Text == "")
                ValueForTakeMoney.Text = "Ввведите какую сумму снять";
        }

        private void ValueForTakeMoney_Enter(object sender, EventArgs e)
        {
            if (ValueForTakeMoney.Text == "Ввведите какую сумму снять")
                ValueForTakeMoney.Text = "";
        }

        private void CreatureScore_Load(object sender, EventArgs e)
        {

        }

        private void indexPersonScore_Leave(object sender, EventArgs e)
        {
            if (indexPersonScore.Text == "")
                indexPersonScore.Text = "Введите индекс пользователя";
        }

        private void indexPersonScore_Enter(object sender, EventArgs e)
        {
            if (indexPersonScore.Text == "Введите индекс пользователя")
                indexPersonScore.Text = "";
        }

        private void DeleteScore_Click(object sender, EventArgs e)//Удаление счета
        {
            if (indexPersonScore.Text != "Введите индекс пользователя" &&
                IndexForAction.Text != "Введите индекс счета, с которым будут выполнены действия")
            {

                PersonDB.RemoveScore(Convert.ToInt32(indexPersonScore.Text), Convert.ToInt32(IndexForAction.Text));
                MessageBox.Show("Счет удален");

                indexPersonScore.Text = "Введите индекс пользователя";
                IndexForAction.Text = "Введите индекс счета, с которым будут выполнены действия";
            }
            else
                MessageBox.Show("Счет не удален");

        }

        private void TekeMoneyToScore_Click(object sender, EventArgs e)
        {
            bool check = false;
            int newBalance = 0;
            if(indexPersonScore.Text != "Введите индекс пользователя" &&
                IndexForAction.Text != "Введите индекс счета, с которым будут выполнены действия" &&
                ValueForTakeMoney.Text != "Ввведите какую сумму снять")
            {
                PersonDB.TakeMoneyFromScore(Convert.ToInt32(indexPersonScore.Text),
                                Convert.ToInt32(IndexForAction.Text), Convert.ToInt32(ValueForTakeMoney.Text),ref check, ref newBalance);

                if (check == true)
                {
                    MessageBox.Show($"Со счета снято {ValueForTakeMoney.Text}, текущий баланс = {newBalance}");
                }
                else
                {
                    MessageBox.Show("Недостаточно средств");
                } 
                ValueForTakeMoney.Text = "Ввведите какую сумму снять";

            }


        }

        private void AddMoneyToScore_Click(object sender, EventArgs e)
        {
            string vrrr= "";

            if (indexPersonScore.Text != "Введите индекс пользователя" &&
               IndexForAction.Text != "Введите индекс счета, с которым будут выполнены действия" &&
                ValueForAddMoney.Text != "Введите сумму пополнения")
            {
                PersonDB.AddMoneyForScore(Convert.ToInt32(indexPersonScore.Text), Convert.ToInt32(IndexForAction.Text), 
                    Convert.ToInt32(ValueForAddMoney.Text), ref vrrr);
                ValueForAddMoney.Text = "Введите сумму пополнения";
            }
            MessageBox.Show($"Текущий баланс счета = {vrrr}");
        }

        private void TakeInfoScore_Click(object sender, EventArgs e)
        {
            int temporal = 0;
            bool check = false;

            if (indexPersonScore.Text != "Введите индекс пользователя" &&
                IndexForAction.Text != "Введите индекс счета, с которым будут выполнены действия")
            {
                PersonDB.ReceiveBalance(Convert.ToInt32(indexPersonScore.Text),
                                Convert.ToInt32(IndexForAction.Text), ref temporal,ref check);
                if (check == true)
                    MessageBox.Show($"Баланс счета с ID {Convert.ToInt32(indexPersonScore.Text)} пользователя с ID {Convert.ToInt32(IndexForAction.Text)} = {temporal}");
                else
                    MessageBox.Show("У данного пользователя нет такого счета");
            }

        }

    }
}
