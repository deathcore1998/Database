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
    
    public partial class RegistrationField : Form
    {
        
        List<Person> people = new List<Person>();//массив людей
        public RegistrationField()
        {
            InitializeComponent();

            fioField.Text = "Введите фио"; 
            ageField.Text= "Введите возраст";
            workplaceField.Text = "Введите место работы";

            //List<Person> people = new List<Person>();//массив людей

        
        }

        public class Numberscore
        {
            public int balance;
            public string prihod = "";
            public string uhod = "";

        }
    


    private void fioField_Enter(object sender, EventArgs e)
        { 
            if (fioField.Text == "Введите фио")
                fioField.Text = "";


        }
        
        private void fioField_Leave(object sender, EventArgs e)
        {
            if (fioField.Text == "")
                fioField.Text = "Введите фио";
        }

        private void ageField_Enter(object sender, EventArgs e)
        {
            if (ageField.Text == "Введите возраст")
                ageField.Text = "";
        }

        private void ageField_Leave(object sender, EventArgs e)
        {
            if (ageField.Text == "")
                ageField.Text = "Введите возраст";
        }

        private void workplaceField_Enter(object sender, EventArgs e)
        {
            if (workplaceField.Text == "Введите место работы")
                workplaceField.Text = "";
        }

        private void workplaceField_Leave(object sender, EventArgs e)
        {
            if (workplaceField.Text == "")
                workplaceField.Text = "Введите место работы";
        }

        private void RegistrationPers_Click(object sender, EventArgs e)// Добавление в базы данных персоны
        {
            Person pers = new Person();
            if (fioField.Text != "Введите фио" && ageField.Text != "Введите возраст" && workplaceField.Text != "Введите место работы")
            {
                PersonDB.AddPersonDB(fioField.Text, Convert.ToInt32(ageField.Text), workplaceField.Text);

                fioField.Text = "Введите фио";
                ageField.Text = "Введите возраст";
                workplaceField.Text = "Введите место работы";

                MessageBox.Show("Добавлен пользователь");
            }
            else
                MessageBox.Show("Пользователь не добавлен");
                
        }

        private void CreatAndAddScore_Click(object sender, EventArgs e)
        {
            CreatureScore opencreatureScore = new CreatureScore();

            opencreatureScore.Show();
        }


        private void indexPersonScore_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
