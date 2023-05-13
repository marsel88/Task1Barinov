using System.ComponentModel.Design;

namespace taasks1113
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string str = "в шкафу стоят книги на полках лежат газеты и стеклянная посуда";
            CheckExceptionMethod(str);
            ChangeRegistrMethod(str);
            ChangeSyntxMethod(str);

        }

        //1.1 Метод отлова/оповещения об ошибке
        public static void CheckExceptionMethod(string str)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        //1.2 Метод изменения регистра
        public static void ChangeRegistrMethod(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentException("String is mull or empty");
            }

            Console.WriteLine(str[0].ToString().ToUpper() + str.Substring(1));
        }

        //1.3 Метод изменения синтаксиса
        public static void ChangeSyntxMethod(string str)
        {
            str = str.Insert(19, ",");
            Console.WriteLine(str);
        }
    }
}