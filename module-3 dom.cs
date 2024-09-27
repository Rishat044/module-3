//создал один метод с параметром, который будет определять уровень лога.
public void Log(string level, string message)
{
    Console.WriteLine($"{level.ToUpper()}: {message}");
}

public void LogError(string message)
{
    Log("Error", message);
}

public void LogWarning(string message)
{
    Log("Warning", message);
}

public void LogInfo(string message)
{
    Log("Info", message);
}

//----------------------------------------------------------------------------

//Строка подключения хранится в классе Configuration.
public static class Configuration
{
    public static string ConnectionString = "Server=myServer;Database=myDb;User Id=myUser;Password=myPass;";
}

public class DatabaseService
{
    public void Connect()
    {
        string connectionString = Configuration.ConnectionString;
    }
}

public class LoggingService
{
    public void Log(string message)
    {
        string connectionString = Configuration.ConnectionString;
    }
}
//------------------------------------------------------------------------------

//Проверка на null и пустой массив объединены в одно условие.
//Удалил лишние вложенные if.

public void ProcessNumbers(int[] numbers)
{
    if (numbers == null || numbers.Length == 0)
        return;

    foreach (var number in numbers)
    {
        if (number > 0)
        {
            Console.WriteLine(number);
        }
    }
}
//-----------------------------------------------------------------------------------

//добавил проверку делителя b. Если он равен нулю, метод просто возвращает 0.
public int Divide(int a, int b)
{
    if (b == 0)
    {
        return 0; 
    }
    return a / b;
}
//-------------------------------------------------------------------------------------

//Убраны параметры useBuffer и bufferSize.

public class FileReader
{
    public string ReadFile(string filePath)
    {
        int bufferSize = 1024; 
        return "file content";
    }
}
//--------------------------------------------------------------------------------------

public class ReportGenerator
{
    public enum ReportFormat { Pdf, Excel, Html }

    public void GenerateReport(ReportFormat format)
    {
        if (format == ReportFormat.Pdf)
        {
            Console.WriteLine("Генерация PDF отчета...");
        }
        else if (format == ReportFormat.Excel)
        {
            Console.WriteLine("Генерация Excel отчета...");
        }
        else if (format == ReportFormat.Html)
        {
            Console.WriteLine("Генерация HTML отчета...");
        }
    }
}
