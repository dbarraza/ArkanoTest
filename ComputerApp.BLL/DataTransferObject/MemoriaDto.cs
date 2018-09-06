namespace ComputerApp.BLL.DataTransferObject
{
    public class MemoriaDto
    {
        public int MemoryId { get; set; }
        public string Marcar { get; set; }
        public string Tipo { get; set; }
        public int Capacidad { get; set; }

        public int ComputerId { get; set; }
        public string ComputerName { get; set; }

    }
}
