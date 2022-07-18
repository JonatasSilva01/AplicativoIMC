using System;
using Modelo;
using System.Collections.Generic;
using System.Text;

namespace Inicilizador
{
    // Classe que pega todos metodos de outras classes para jogar na main principal
    public class Iniciar : CadastroPessoa
    {
        public void Inicializador()
        {
            string Menssagem = $"Digite \n" +
                $"1 - Registro de Novos Pacientes\n" +
                $"2 - Ler Arquivo de um Paciente\n" +
                $"3 - Ler muitos Arquivos de varios Pacientes\n" +
                $"4 - Excluir Arquivos de Pacientes\n" +
                $"0 - Para Sair";

            Console.WriteLine(Menssagem);

            char Res = char.Parse(Console.ReadLine());
            if(Res == '0')
            {
                Console.WriteLine("Programa Finalizado");
            }
            if(Res == '1')
            {
                CadastroPessoa hospital = new CadastroPessoa();
                hospital.SetCadastroPaciente();
                hospital.GetLeituradoPaciente();
                hospital.ResultadoDoIMC();
            }
            if(Res == '2')
            {
                Console.WriteLine("Escreva o nome do arquivo para a consulta: ");
                string nameFile = Console.ReadLine();
                Console.WriteLine("Formato do Arquivo? txt ou json");
                string formatName = Console.ReadLine();
                GetReadingFile(nameFile, formatName);
            }

            if (Res == '3')
            {
                Console.WriteLine("Escreva o nome do Arquivo: ");
                string nameFile = Console.ReadLine();
                Console.WriteLine("Escreva o numero de onde quer ler os Registros: ");
                int numberFile = int.Parse(Console.ReadLine());
                Console.WriteLine("Escreva o formato dos arquivos: ");
                string formatFile = Console.ReadLine();

                GetReadingManyFiles(nameFile, numberFile, formatFile);
            }

            if(Res == '4')
            {
                Console.WriteLine("Escreva o nome completo do arquivo que quer deletar: ");
                string nameFile = Console.ReadLine();
                Console.WriteLine("Formato do Arquivo é? txt ou json");
                string formatFile = Console.ReadLine();
                SetDeleteFile(nameFile, formatFile);
            }
        }
    }
}
