using Transacao = (decimal Valor, System.DateTime Data, TipoTransacao Tipo);

List<Transacao> transacoes = new List<Transacao>
{
    (100.00M, DateTime.Now, TipoTransacao.Deposito),
    (100.00M, DateTime.Now, TipoTransacao.Saque),
    (100.00M, DateTime.Now, TipoTransacao.Transferencia),
    (100.00M, DateTime.Now, TipoTransacao.Deposito),
};
public enum TipoTransacao
{
    Deposito,
    Saque,
    Transferencia
}