using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public decimal ValorAPagar { get; set; }
        public Cliente(string nome, string telefone)
        {
            this.Nome = nome;
            this.Telefone= telefone;
            this.ValorAPagar = 0;
        }

        public void CortarCabelo()
        {
            this.ValorAPagar += 30;
        }
        public void CortarBarba()
        {
            this.ValorAPagar+= 20;
        }
    }
}
