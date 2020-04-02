using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    abstract public class Cuenta
    {
        public Cuenta(decimal saldo)
        {
            Saldo = saldo;
        }

        public List<Movimiento> Movimientos { get; set; }
        public string Numero { get; set; }
        public string Tipo { get; set; }
        public decimal Saldo { get; set; }

        abstract public string Consignar(decimal valor);
        abstract public string Retirar(decimal valor);

        public Movimiento AgregarMoviminetos(decimal valor, string tipo, decimal cupo=0)
        {
            
            Movimiento movimiento = new Movimiento();
            movimiento.Tipo = tipo;
            movimiento.Valor = valor;
            movimiento.Fecha = DateTime.Now;
            movimiento.Cupo = cupo;
            movimiento.Saldo = Saldo;
            Movimientos.Add(movimiento);
            return movimiento;
        }
    }
}
