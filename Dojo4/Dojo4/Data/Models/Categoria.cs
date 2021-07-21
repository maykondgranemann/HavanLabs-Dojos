using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Categoria : BaseModel
    {
        public string Descricao { get; set; }
        public string Nome { get; set; }
    }
}
