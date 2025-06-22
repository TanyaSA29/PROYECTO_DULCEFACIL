using DulceFacil.Infraestructura.AccesoDatos;
using DulceFacil.Infraestructura.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Aplicacion.Servicios

{
    [ServiceContract]
    public interface IClienteServicio
    {
        [OperationContract]
        Task AddProductoAsync(Cliente nuevocliente);
        [OperationContract]
        Task AddAsync(Cliente entidad);

        [OperationContract]
        Task DeleteProductoAsync(int id);
        [OperationContract]
        Task UpdateProductoAsync(Cliente entidad);
        [OperationContract]
        Task<IEnumerable<Cliente>> GetAllProductosAsync();

        [OperationContract]
        Task<Cliente> GetProductoByIdAsync(int id);
      
    }
}
