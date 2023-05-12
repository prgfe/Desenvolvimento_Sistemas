using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programa_Agenda_Interface
{
    public interface IContatoPessoal
    {
        bool ValidarCpf(string _cpf);
    }
}