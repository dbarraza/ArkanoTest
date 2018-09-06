using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ComputerApp.BLL.DataTransferObject;
using ComputerApp.BLL.Inteface;
using ComputerApp.BLL.ModelMapper;
using ComputerApp.DAL;

namespace ComputerApp.BLL.Implementation
{
    public class MemorySvcImpl : IMemorySvc
    {
        public IList<MemoriaDto> GetMemories(int capacity)
        {
            using (var context = new ComputerDbEntities())
            {
                var entities = context.Memories.Where(m => m.Capacidad > capacity).Include(m => m.Computer);
                var dtos = entities.Select(MemoriaMapper.ToDto).ToList();
                return dtos;
            }
        }
    }
}
