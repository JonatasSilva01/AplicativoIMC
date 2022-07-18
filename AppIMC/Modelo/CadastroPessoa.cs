using System;
using CalculoIMC;
using Diretorio;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Modelo
{
    // Cadastro Pessoas
    public class CadastroPessoa : IMC
    {
        protected Guid Id { get; set; }
        public string Name { get; set; }
        protected string Tel { get; set; }

        // Criando Arquivo com Informações do paciente
        public void SetCreateFile(string nameFile, string formatFile)
        {
            string Path = $@"C:\ClinicaFulano\{nameFile}.{formatFile}";

            using (StreamWriter writer = new StreamWriter(Path))
            {
                writer.WriteLine(Id);
                writer.WriteLine(Name);
                writer.WriteLine(Tel);
                writer.WriteLine(ResultadoImc);
            }
        }

        public void SetCadastroPaciente()
        {
            Console.WriteLine("Nome: ");
            Name = Console.ReadLine().ToUpper();
            Console.WriteLine("Tel: ");
            Tel = Console.ReadLine().ToUpper();
            Console.WriteLine("Peso: ");
            Peso = double.Parse(Console.ReadLine().ToUpper());
            Console.WriteLine("Altura: ");
            Altura = double.Parse(Console.ReadLine().ToUpper());

            SetCalculoImc(Peso, Altura);
            Console.Clear();
            Console.WriteLine("1- para criar o arquivo para o paciente \n" +
                "2 - para sair");
            char res = char.Parse(Console.ReadLine());
            if(res == '1')
            {
                Console.WriteLine("Escreva o nome que quer colocar no arquivo: ");
                string nameFile = Console.ReadLine().ToUpper();

                Console.WriteLine("Escreva o formato do arquivo");
                string formatFile = Console.ReadLine().ToLower();

                SetCreateFile(nameFile, formatFile);
            }

        }

        public void ResultadoDoIMC()
        {
            if (ResultadoImc < 18.5) Console.WriteLine("Abaixo do Peso");
            if (ResultadoImc > 18.5 && ResultadoImc < 24) Console.WriteLine("Peso Normal");
            if (ResultadoImc > 24 && ResultadoImc < 29.5) Console.WriteLine("Sobre Peso");
            if (ResultadoImc > 30 && ResultadoImc < 34.9) Console.WriteLine("Obesidade I");
            if (ResultadoImc > 35 && ResultadoImc < 39.9) Console.WriteLine("Obesidade II");
        }

        public void GetLeituradoPaciente()
        {
            Console.WriteLine($"\n" +
                $"NOME: {Name}\n" +
                $"TEL: {Tel}\n" +
                $"PESO: {Peso}\n" +
                $"ALTURA: {Altura}\n" +
                $"RESULTADO DO PESO: {ResultadoImc}");
        }

        public CadastroPessoa()
        {
            Id = Guid.NewGuid();
        }
    }
}
