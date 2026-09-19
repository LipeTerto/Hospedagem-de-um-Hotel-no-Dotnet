using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospedagemDeUmHotel
{
    public class Pessoa
    {
        public string Nome {get; set;}

        public Pessoa (string nome)
        {
            Nome = nome;
        }
    }

    public class Suite
    {
        public string TipoSuite {get; set;}
        public int Capacidade {get; set;}
        public decimal ValorDiaria {get; set;}

        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }
    }

    public class Reserva
    {
        public int DiasReservados {get; set;}
        public List<Pessoa> Hospedes {get; set;}
        public Suite Suite {get; set;}

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
            Hospedes = new List<Pessoa>();
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                Console.WriteLine("Quantidade de hóspedes maior que a capacidade da suíte.");
            }
        }

        public int ObterQuantidadedeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;

            if(DiasReservados > 10)
            {
                valor *= 0.90m;
            }
            return valor;
        }
    }
}