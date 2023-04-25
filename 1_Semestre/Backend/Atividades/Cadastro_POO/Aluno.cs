
namespace Cadastro_POO
{
    // Classe
    public class Aluno
    {
        // atributos (características) ou propriedades. Abstração: trazer apenas características relevantes para o projeto.
        public string Nome;

        public string Curso;

        public string Idade;

        public string Rg;

        public bool Bolsista;
        
        public float MediaFinal;

        public float ValorMensalidade;
        // métodos (comportamentos) ou funções
        public float VerMediaFinal()
        {
            return this.MediaFinal;
        }

        // public void VerMediaFinal()
        // {
        //     Console.WriteLine($"{this.MediaFinal}"); 
        // }
        public float VerMensalidade()
        {
            // Condicional
            // If encadeado (else if)
        float valor;
        if (this.Bolsista == true && this.MediaFinal >= 8)
        {
            valor = this.ValorMensalidade * 0.5F;
        }
        else if (this.Bolsista == true && this.MediaFinal > 6)
        {
            valor = this.ValorMensalidade * 0.7f;
        }
        else
        {
            valor = ValorMensalidade;
        }
            return valor;
        }
    }
}