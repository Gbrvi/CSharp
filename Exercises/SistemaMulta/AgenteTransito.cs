using System;

class AgenteTransito : Pessoa
{
    public AgenteTransito(string nome, string cpf, int ID)
    :base(nome, cpf, ID) 
    {
        
    }

    public void Multar(float valor, int infracao, int status, Veiculo veiculo)
    {
        Motorista motorista = veiculo.GetMotorista();

        if(motorista != null)
        {
            Multa multa = new Multa(valor, infracao, status, veiculo);

            motorista.AddMultas(multa, infracao);
        }
        else
        {
            Console.WriteLine("Nenhum motorista associa com esse veículo");
        }
    }


}