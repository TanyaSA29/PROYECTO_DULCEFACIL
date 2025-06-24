using DulceFacil.Aplicacion.Servicios;
using DulceFacil.Dominio.Modelo.Abstracciones;
using DulceFacil.Infraestructura.AccesoDatos;
using DulceFacil.Infraestructura.AccesoDatos.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Aplicacion.ServicioImpl
{
    public readonly class ClienteServicioImpl : IClienteServicio
    {
        private IClienteRepositorio clienteRepositorio;
    public ClienteServicioImpl(BDDulceFacilContext _BDDulceFacilContext)
        {
            this.clienteRepositorio = new ClienteRepositorioImpl(_BDDulceFacilContext);
        }
 

        public Task AddAsync(Cliente entidad)
        {
            throw new NotImplementedException();
        }

        public Task AddProductoAsync(Cliente nuevocliente)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProductoAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Cliente>> GetAllProductosAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> GetProductoByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProductoAsync(Cliente entidad)
        {
            throw new NotImplementedException();
        }
    }
}
