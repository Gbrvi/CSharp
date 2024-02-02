class Multa
{
    private float valor;
    private int infracao;

    private int status;
    private Veiculo veiculo;
    public Multa(float valor, int infracao, int status, Veiculo veiculo)
    {
        this.valor = valor;
        this.infracao = infracao;
        this.status = status;
        this.veiculo = veiculo;

    }

    public float GetValor()
    {
        return valor;
    }

    public int GetInfracao()
    {
        return infracao;
    }

    public int GetStatus()
    {
        return status;
    }

    public Veiculo GetVeiculo()
    {
        return veiculo;
    }

    public string GetInfoVeiculo()
    {
        return $"{veiculo.GetPlaca()}, {veiculo.GetModelo()}, {veiculo.GetCor()}, {veiculo.GetMotorista()}";
    }
}