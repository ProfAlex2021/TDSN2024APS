namespace TDSN2024
{
    abstract class Triangulo : FormaGeometrica
    {
        protected double _base;

        public double Base
        {
            get { return _base; }
            set { _base = value; }
        }
        protected double altura;

        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }
    }
}
