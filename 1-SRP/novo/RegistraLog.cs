static class RegistraLog
{
    public static void Info(string info)
    {
        Console.WriteLine("[info] ["+ DateTime.Now +"] "+ info  );
    }
    public static void Erro(Exception erro)
    {
        Console.WriteLine($"[erro] [{DateTime.Now}] [{erro.TargetSite.DeclaringType.Name}:{erro.TargetSite.Name}] {erro.Message}");
    }
}