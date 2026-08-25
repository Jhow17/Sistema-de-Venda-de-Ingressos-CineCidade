using System;
using System.Collections.Generic;
using System.Formats.Tar;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenda
{
    class Cliente
    {
        public string Nome { get; set; }
        public int Ingressos { get; set; } 

        public string CDesconto { get; set; }


        public int Idade { get; set; }

        public double TaxaConveniencia = 5.0;


        public double CalcularBruto()
        {

            //O Custo Bruto: R$ 5,00 de taxa de conveniência/reserva + R$ 25,00 por ingresso comprado.

            return TaxaConveniencia + 25 * Ingressos;

        }


        public double CalcularLiquido()
        {

            //O Desconto: Se o cupom digitado for igual a "CINEMA10" (independente de maiúsculas/minúsculas), conceder 10% de desconto sobre o custo bruto; caso contrário, o desconto é R$ 0,00.
            if (CDesconto.ToUpper() == "CINEMA10")
            {
                return CalcularBruto() - CalcularBruto() * 0.1;
            }
            else { 
                return CalcularBruto(); 
            }

            

        }
    }


  
    }
