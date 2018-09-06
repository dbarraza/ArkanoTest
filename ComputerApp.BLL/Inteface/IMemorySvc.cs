using System.Collections.Generic;
using ComputerApp.BLL.DataTransferObject;

namespace ComputerApp.BLL.Inteface
{
    public interface IMemorySvc
    {
        IList<MemoriaDto> GetMemories(int capacity);
    }
}
