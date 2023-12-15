class RegistraLog : IRegistraLog
{
    public void Info(string info)
    {
        Console.WriteLine("[info] ["+ DateTime.Now +"] "+ info  );
    }
    public void Erro(string erro)
    {
        Console.WriteLine("[erro] [" + DateTime.Now + "] " + erro);
    }
}