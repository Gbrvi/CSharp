// See https://aka.ms/new-console-template for more information
using System.Reflection;
class Program
{
    static void Main(string[] args)
    {
        // Criando um motorista
        Motorista motorista = new Motorista("João", "123456789", 1, "CNH123");

    // Criando um veículo associado ao motorista
        Veiculo veiculo = new Veiculo("ABC123", "ModeloCarro", "Azul", motorista);

        // Criando um agente de trânsito
        AgenteTransito agente = new AgenteTransito("Agente", "987654321", 2);

        // Agente de trânsito efetua multa associada ao veículo
        agente.Multar(400, 1, 1, veiculo);
        agente.Multar(100, 3, 1, veiculo);
        agente.Multar(1004, 2, 1, veiculo);
        agente.Multar(100, 1, 1, veiculo);
        agente.Multar(2000, 4, 1, veiculo);
        List<Multa> multasDoMotorista = motorista.GetMultas();

        foreach (Multa multas in multasDoMotorista)
        {
            Console.WriteLine($"Informações da Multa - Valor: {multas.GetValor()}, Infração: {multas.GetInfracao()}, Status: {multas.GetStatus()} | O veículo: {multas.GetInfoVeiculo()}, ");
        }

        Console.WriteLine($"Motorista dados: {motorista.GetInfoMotorista()}");

        Console.WriteLine($"{motorista.Dirigir()}");

    }
}

