using System.Globalization;

namespace DadosDoFuncionarios
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {

            return SalarioBruto -= Imposto;
            
        }
        public void  AumentoDeSalario(double porc)  {

            // double porc2 = (porc/100)*SalarioBruto ;
            double salario = SalarioBruto + Imposto; 
            double porc2 = (porc / 100) * salario+SalarioBruto;
            Console.WriteLine("Dados Atualizados : "
               + Nome
               + ", R$ "
               + porc2.ToString("f2", CultureInfo.InvariantCulture)
               );
        }

    }
    
 }



