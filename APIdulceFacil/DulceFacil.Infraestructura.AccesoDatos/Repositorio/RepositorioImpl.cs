using DulceFacil.Dominio.Modelo.Abstracciones;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulceFacil.Infraestructura.AccesoDatos.Repositorio
{
    public  class RepositorioImpl<T> : IRepositorio<T> where T : class
    {
        private readonly BDDulceFacilContext _context;
        private readonly DbSet<T> _dbSet;
        public RepositorioImpl(BDDulceFacilContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task AddAsync(T entidad)
        {
            try
            {
                await _dbSet.AddAsync(entidad);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error No se pudo insertar registro" + ex.Message);
            }
        }

        public async Task DeleteAsync(int id)
        {
            try
            {
                var entity = await GetByIdAsync(id);
                _dbSet.Remove(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw new Exception("Error No se pudo eliminar registro" + ex.Message);
            }
        }


        public async Task<IEnumerable<T>> GetAllAsync()
        {
            try
            {
                return await _dbSet.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error Clase Gnerica: No se pudo listar Datos" + ex.Message);
            }
        }
        public async Task<T> GetByIdAsync(int id)
        {
            try
            {
                return await _dbSet.FindAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error Clase Gnerica: No se pudo recuperar Datos" + ex.Message);
            }
        }
        public async Task UpdateAsync(T entidad)
        {
            try
            {
                _dbSet.Update(entidad);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error No se pudo actualizar el  registro" + ex.Message);
            }
        }
    }
}
