using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExplorer
{
    public class Person
    {
        // в 1 клас можем д аслагаме методи, променливи, пропъртита или и други класове.
       private string simpleString = "тестова променлива от клас"; // това е глобална променлива!
       private string user = "";

        private string hiddenString = "";

        // първото нещо като създадем клас е да създадем конструктор( чети за конструктор!):
        public Person (string ini)
        {
            getUser(ini);
            setWelcomeText();

            //  simpleString = "Промяна на променлива при инициализиране.";        
        }
        private void getUser (string ini)
        {
            if (ini == "password1") hiddenString = "Потребител 1";
            if (ini == "passwor21") hiddenString = "Потребител 2";

            user = hiddenString;

        }
        private void setWelcomeText()
        {
            if (hiddenString.Length > 0)
                simpleString = "Добре дошли оново, " + user + "!";
            else
                simpleString = "Вие нямате достъп до тази програма";
        }

        public string getWelcomeMessage()
        {
            return simpleString;
        }
    }

    class Program
    {       
        static void Main(string[] args)
        {
            Console.Write("Парола: ");
            string user = Console.ReadLine();
            // Дефиниране на клас:
            Person person = new Person(user);

            // Достъпване на клас:
            //   Console.WriteLine(person.simpleString);
            Console.WriteLine(person.getWelcomeMessage());
            // Ако се опитаме да достъпим person.simpleString; и person.user; - не е проблем щот са public
            // Но тук нямаме достъп до hiddenString, защото е private

        }
    }
}
