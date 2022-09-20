using @class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @class
{
    public enum Key {csharp, python, java, js}
    public class Student 
    {
        private int group;
        private int money;
        private Human human;
        private Key key;

        public Student() : base()
        {

        }
        public Student(Human human, int group, int money, Key key)
        {
            this.group = group;
            this.money = money;
            this.key = key;
        }
        public void printInfo()
        {
            
            string data =
               this.human +
               "Group: " + this.group.ToString() + "\n" +
               "Money: " + this.money.ToString() + "\n" +
               "Key: " + this.key.ToString();
            Console.WriteLine(data);

        }
        public int Group
        {
            get { return group; }
            set { group = value; }
        }
        public int Money
        {
            get { return money; }
            set { money = value; }
        }
        public Human Human
        {
            get { return human; }
            set { human = value; }
        }
        public Key Key
        {
            get { return key; }
            set { key = value; }
        }
    }
}
