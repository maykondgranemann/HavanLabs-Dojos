using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dojo11.Models
{
    public class Farmacia : BaseModels
    {
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string Localizacao { get; set; }
    }
}
