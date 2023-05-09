namespace Static_ConversorMoeda
{
    public static class Conversao
    {
        public static float DolarParaReal(float dolar, float real)
        {
            float moedaReal = dolar * real;

            return moedaReal;
        }

        public static float RealParaDolar(float real, float dolar)
        {
            float moedaDolar = real * dolar;

            return moedaDolar;
        }
    }
}