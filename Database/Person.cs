using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Person 
    {
        public int Iidentifier;
        public string fio;
        public int age;
        public string workplace;
        public List<Numberscore> numercheta = new List<Numberscore>();

        public Person(string fio, int age, string workplace)
        {
            this.fio = fio;
            this.age = age;
            this.workplace = workplace;

        }
        public Person()
        {

        }

    }

    public class Numberscore
    {
        public int IDscore;
        public int balance ;
        public string prihod = "";
        public string uhod = "";

    }

}
