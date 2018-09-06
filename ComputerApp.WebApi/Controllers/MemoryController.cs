using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using ComputerApp.BLL.DataTransferObject;
using ComputerApp.BLL.Implementation;
using ComputerApp.BLL.Inteface;

namespace ComputerApp.WebApi.Controllers
{
    public class MemoryController : ApiController
    {
        private readonly IMemorySvc _memorySvc;

        public MemoryController()
        {
            _memorySvc = new MemorySvcImpl();
        }

        //Futura Inyección de dependencia
        public MemoryController(IMemorySvc memorySvc) 
        {
            _memorySvc = memorySvc;
        }
         
        /// <summary>
        /// Una lista con las memorias que tengan capacidad superior a 8GB.
        /// </summary>
        /// <returns></returns>
        public List<MemoriaDto> Get()
        {
            return _memorySvc.GetMemories(8).ToList(); //
        }
    }
    
}
