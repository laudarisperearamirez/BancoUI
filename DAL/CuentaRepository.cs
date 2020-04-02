using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class CuentaRepository
    {
        private List<Cliente> clientes;
        public CuentaRepository()
        {
            clientes = new List<Cliente>();
        }

        public void Guardar(Cliente cliente)
        {
            clientes.Add(cliente);
            
        }
        
        public Cuenta BuscarNumeroCuenta(string numeroCuenta)
        {
            foreach (var itemCliente in clientes)
            {
                foreach (var itemCuenta in itemCliente.Cuentas)
                {
                    if (itemCuenta.Numero.Equals(numeroCuenta))
                    {
                        return itemCuenta;
                    }
                }
            }
            return null;
        }

        public Cliente BuscarIdentificacion(string identificacion)
        {
            foreach (var itemCliente in clientes)
            {
                if (itemCliente.Identificacion.Equals(identificacion))
                {
                    return itemCliente;
                }
            }
            return null;
        }


        public List<Cliente> Consultar()
        {
            return clientes;
        }
    }
}
