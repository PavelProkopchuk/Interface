interface IDataProvider
{
    string GetData();
}
 
interface IDataProcessor
{
    void ProcessData(IDataProvider dateProvider);
}

class ConsoleDataProcessor : IDataProcessor
{
    public void ProcessData(IDataProvider dateProvider)
    {
        Console.WriteLine(dateProvider.GetData());
    }
}

class DbDataProvider : IDataProvider
{
    public string GetData()
    {
        return "Данные из БД";
    }
}

class FileDataProvider : IDataProvider
{
    public string GetData()
    {
        return "Данные из провайдера";
    }
}

class APIDataProvider : IDataProvider
{
    public string GetData()
    {
        return "Данные из API";
    }
}

class Program
{
    static void Main(string[] args)
    {
        IDataProcessor dataProcessor = new ConsoleDataProcessor();
        dataProcessor.ProcessData(new DbDataProvider());
        dataProcessor.ProcessData(new FileDataProvider());
        dataProcessor.ProcessData(new APIDataProvider());
    }
}