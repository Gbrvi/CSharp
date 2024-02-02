using System;

class Motorista : Pessoa
{
    private string CNH {set; get;}
    private int quant_multas {set; get;}
    private List<Multa> multas;
    private int CNHPontos;

    private bool CNHValido;
    private float valorTotal;
    public Motorista(string nome, string cpf, int ID, string CNH)
       : base(nome, cpf, ID)

    {
        this.CNH = CNH;
        this.multas = new List<Multa>();
        this.valorTotal = 0;
        this.CNHPontos = 0;
        this.CNHValido = true;

    }

    public string GetCNH()
    {
        return CNH;
    }

    public void AddMultas(Multa multa, int infracao)
    {
        multas.Add(multa);
        valorTotal += multa.GetValor();
        AddCNHInfracao(infracao);
        quant_multas = multas.Count;

    }

    public void AddCNHInfracao(int infracao)
    {
        if(infracao == 1)
        {
            CNHPontos += 3;
        }

        else if (infracao == 2)
        {
            CNHPontos += 4;
        }

        else if (infracao == 3)
        {
            CNHPontos += 5;
        }

        else if (infracao == 4)
        {
            CNHPontos += 7;
        }

        CheckCNHValida(CNHPontos);

    }

    public void CheckCNHValida(int CNHPontos)
    {
        if (CNHPontos >= 20)
        {
            CNHValido = false;
        }
    }

    public List<Multa> GetMultas()
    {
        return multas;
    }

    public int GetQuantmultas()
    {
        return quant_multas;
    }

    public int GetCNHPontos()
    {
        return CNHPontos;
    }

    public bool GetValidCNH()
    {
        return CNHValido;
    }

    public string Dirigir()
    {
        if (CNHValido)
        {
            return "Posso dirigir! ";
        }

        else
        {
            return($"Não posso dirigir pois tenho {CNHPontos} pontos na carteira");
        }
    }

    public string GetInfoMotorista()
    {   
        return $" Nome: {nome} CNH Valida? {CNHValido} | CNH Pontos {CNHPontos} | Quantidade Multas: {quant_multas} | Total a pagar {valorTotal}";
    }

    public float GetValorTotal()
    {
        return valorTotal;
    }

}