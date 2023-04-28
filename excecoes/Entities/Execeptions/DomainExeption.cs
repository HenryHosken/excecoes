using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excecoes.Entities.Execeptions
{
    internal class DomainExeption : ApplicationException
    {
        public DomainExeption(String message) : base(message)
        {

        }
    }
}
