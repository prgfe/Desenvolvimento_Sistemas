

namespace Calculadora_POO
{
    public class Calculadora
    {  
        // Propriedades
        public float num1;

        public float num2;
       
        // Métodos
        public float Somar()
        {
            return this.num1 + this.num2;
        }
        public float Subtrair()
        {
            return this.num1 - this.num2;
        }
        public float Multiplicar()
        {
            return this.num1 * this.num2;
        }
        public float Dividir()
        {
            return this.num1 / this.num2;
        }
        
    }
}