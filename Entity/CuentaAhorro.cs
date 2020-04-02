using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CuentaAhorro : Cuenta
    {
        private const decimal TOPE = 10000;
        public CuentaAhorro(decimal Saldo):base(Saldo)
        {
            
        }

        public override string Consignar(decimal valor)
        {
            if (valor>0)
            {
                Saldo += valor;
                AgregarMoviminetos(valor, "Consignacion");
                return $"\n Se consigno: {valor}, su nuevo saldo es de: {Saldo}";
            }
            return $"\n No se pueden consignar valores negativos: {valor}";
        }

        public override string Retirar(decimal valor)
        {
            if ((Saldo - valor)>=TOPE)
            {
                Saldo -= valor;
                AgregarMoviminetos(valor, "Retiro");
                return $"\n Se retiro: {valor}, su nuevo saldo es de: {Saldo}";
            }
            return $"\n Saldo insuficiente. No es posible retirar, su saldo es de: {Saldo}";
        }

        
    }
}
