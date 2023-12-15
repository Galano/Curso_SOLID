class PedidoSRP
{
    private IRegistraLog _registraLog;
    private IEnviarEmail _enviaEmail;
    public long Quantidade { get; set; }
    public DateTime Data { get; set; }

    public PedidoSRP()
    {
        _enviaEmail = new EnviarEmail();
        _registraLog = new RegistraLog();
    }
    public void IncluirPedido()
    {
        try
        {
            _registraLog.Info("Pedido incluido ");
            _enviaEmail.Enviar("EMailFrom@gmail.com", 
                "EMailTo@gmail.com", "EMailSubject", "EMailBody");
            _registraLog.Info("E-mail enviado.");

        }
        catch (Exception ex)
        {
            _registraLog.Erro("Erro ao enviar email : " + ex.Message);
        }
    }
    public void DeletaPedido()
    {
        try
        {
            _registraLog.Info("Pedido deletado");
        }
        catch (Exception ex)
        {
            _registraLog.Erro("Erro ao deletar pedido " + ex.Message);
        }
    }
}
