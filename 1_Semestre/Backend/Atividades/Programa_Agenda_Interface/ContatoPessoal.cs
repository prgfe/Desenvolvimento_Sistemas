namespace Programa_Agenda_Interface
{
    public class ContatoPessoal : Contato, IContatoPessoal
    {
        public string Cpf { get; set; }

        public bool ValidarCpf(string _cpf)
        {
            throw new NotImplementedException();
        }
    }
}