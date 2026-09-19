using HospedagemDeUmHotel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Sistema de Hospedagem ===");

        Console.Write("Nome do hóspede: ");
        string nome = Console.ReadLine();

        Console.Write("Tipo da suíte: ");
        string tipoSuite = Console.ReadLine();

        Console.Write("Capacidade da suíte: ");
        int capacidade = int.Parse(Console.ReadLine());

        Console.Write("Valor da diária: ");
        decimal valorDiaria = decimal.Parse(Console.ReadLine());

        Console.Write("Quantidade de dias: ");
        int dias = int.Parse(Console.ReadLine());

        Pessoa pessoa = new Pessoa(nome);

        Suite suite = new Suite(
            tipoSuite,
            capacidade,
            valorDiaria
        );

        Reserva reserva = new Reserva(dias);

        reserva.CadastrarSuite(suite);

        List<Pessoa> hospedes = new List<Pessoa>();
        hospedes.Add(pessoa);

        reserva.CadastrarHospedes(hospedes);

        Console.WriteLine("\n=== Resumo da Reserva ===");
        Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadedeHospedes()}");
        Console.WriteLine($"Suíte: {suite.TipoSuite}");
        Console.WriteLine($"Dias: {dias}");
        Console.WriteLine($"Valor da diária: R$ {suite.ValorDiaria:F2}");
        Console.WriteLine($"Valor total: R$ {reserva.CalcularValorDiaria():F2}");
    }
}