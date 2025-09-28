namespace Singletone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var logger1 = Logger.Instance;
            var logger2 = Logger.Instance;

            logger1.Log("Программа запущена");
            logger2.Log("Пользователь вошёл в систему");

            Console.WriteLine(Object.ReferenceEquals(logger1, logger2) );
        }
    }
}
