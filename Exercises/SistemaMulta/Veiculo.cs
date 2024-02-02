using System;

class Veiculo
{
    private string placa;
    private string modelo;
    private string cor;
    private Motorista motorista;
    public Veiculo(string placa, string modelo, string cor, Motorista motorista)
    {
        this.placa = placa;
        this.modelo = modelo;
        this.cor = cor;
        this.motorista = motorista;
    }

    public Motorista GetMotorista()
    {
        return motorista;
    }

        public string GetPlaca()
    {
        return placa;
    }

    public string GetModelo()
    {
        return modelo;
    }

    public string GetCor()
    {
        return cor;
    }
}