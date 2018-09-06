using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerApp.BLL.DataTransferObject;
using ComputerApp.BLL.Inteface;

namespace ComputerApp.Test
{
    public class FakeMemorySvcImpl : IMemorySvc 
    {
        private readonly List<MemoriaDto> _fakeDtos = new List<MemoriaDto>
        {
            new MemoriaDto{Capacidad = 8},
            new MemoriaDto{Capacidad = 7},
            new MemoriaDto{Capacidad = 9},
            new MemoriaDto{Capacidad = 6},
            new MemoriaDto{Capacidad = 10},
        };

        public IList<MemoriaDto> GetMemories(int capacity)
        {
            return _fakeDtos.Where(m => m.Capacidad > capacity).ToList();
        }
    }
}
