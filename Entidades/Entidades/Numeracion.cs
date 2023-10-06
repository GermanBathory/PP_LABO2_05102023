
namespace Entidades
{
    public abstract class Numeracion
    {
        protected static string msgError;
        protected string valor;

        protected Numeracion(string valor)
        {
            this.InicializaValor(valor);
        }

        static Numeracion()
        {
            Numeracion.msgError = "Numero invalido";
        }

        public string Valor
        {
            get
            {
                return this.valor;
            }
        }
        internal abstract double ValorNumerico { get; }

        public abstract Numeracion CambiarSistemaDeNumeracion(ESistema sistema);

        protected bool EsNumeracionValida(string valor)
        {
            if (!String.IsNullOrWhiteSpace(valor))
            {
                return true;
            }
            return false;
        }

        private void InicializaValor(string valor)
        {
            if (EsNumeracionValida(valor))
            {
                this.valor = valor;
            }
            else
            {
                this.valor = msgError;
            }
        }
        public static bool operator ==(Numeracion n1, Numeracion n2)
        {
            if (n1 is not null && n2 is not null && (n1.GetType() == n2.GetType()))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Numeracion n1, Numeracion n2)
        {
            return !(n1 == n2);
        }

        public static explicit operator double(Numeracion numeracion)
        {
            return numeracion.ValorNumerico;
        }
    }
}