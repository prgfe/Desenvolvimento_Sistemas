namespace Static
{
    public static class ConversorTemperatura
    {
        // propriedade estática
        // fazer get e set...
        // métodos estáticos
        public static float CelsiusParaFahrenheit(float celsius)
        {
            float temperatura = celsius;

            float fahrenheit = (temperatura * 9/5) + 32;

            return fahrenheit;
        }

        public static float FahrenheitParaCelsius(float fahrenheit)
        {
            float temperatura = fahrenheit;

            float celsius = (temperatura - 32) * (5/9);

            return celsius;
        }
    }
}