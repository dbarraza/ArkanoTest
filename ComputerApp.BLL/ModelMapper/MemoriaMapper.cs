using ComputerApp.BLL.DataTransferObject;
using ComputerApp.DAL;

namespace ComputerApp.BLL.ModelMapper
{
    public static class MemoriaMapper
    {
        public static MemoriaDto ToDto(Memory entity)
        {
            if (entity == null)
                return null;

            return new MemoriaDto
            {
                Capacidad = entity.Capacidad,
                ComputerId = entity.ComputerId,
                ComputerName = entity.Computer != null ? entity.Computer.Nombre : string.Empty,
                //ComputerName = entity.Computer?.Nombre ?? string.Empty,  //C# 6
                Marcar = entity.Marcar,
                MemoryId = entity.MemoryId,
                Tipo = entity.Tipo
            };
        }
    }
}
