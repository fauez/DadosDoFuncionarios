using DadosDoFuncionarios;
using System.Globalization;

namespace DadosdoFuncionarios
{
     class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario(); // Instancia o objeto 
            Console.WriteLine("Informe os dados abaixo:");
            Console.WriteLine();
            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();//Apos Istanciar Objeto chama as varias que estão publicas e insere os dados
            Console.Write("Salario Bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            //Aqui vamos criar avarias para inserir com retornos dos dados

            Console.WriteLine("Funcionário: "
                + funcionario.Nome
                + ", R$ "
                + funcionario.SalarioLiquido().ToString("f2", CultureInfo.InvariantCulture)
                );

            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salario: ");

            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            funcionario.AumentoDeSalario(porcentagem);
        }
    }
  
}