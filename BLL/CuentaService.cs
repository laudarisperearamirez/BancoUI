using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class CuentaService
    {
        CuentaRepository cuentaRepository;
        public CuentaService()
        {
            cuentaRepository = new CuentaRepository();
        }
        
        public string Guardar(Cliente cliente)
        {
            if(BuscarIdentificacion(cliente.Identificacion) == null)
            {
                cuentaRepository.Guardar(cliente);
                return $" Cliente [{cliente.Nombre} {cliente.Apellido}] registrado correctamente";
            }
            return $" El numero de identificacion: {cliente.Identificacion} ya existe, no se aceptan duplicados";
        }

        public Cuenta BuscarNumeroCuenta(string numeroCuenta)
        {
            return cuentaRepository.BuscarNumeroCuenta(numeroCuenta);
        }
        
        public Cliente BuscarIdentificacion(string identificacion)
        {
            return cuentaRepository.BuscarIdentificacion(identificacion);
        }

        public List<Cliente> Consultar()
        {
            return cuentaRepository.Consultar();
        }
    }
}
