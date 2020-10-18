using System;

namespace Teste
{
    public class Runner
    {
        private static float _n = 3.14159f;

        public static float AreaDoCirculo(float R)
        {
            float area = (float)(_n * Math.Pow(R,2));
            return area;
        }
    }
}
