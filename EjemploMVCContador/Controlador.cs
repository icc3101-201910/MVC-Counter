using EjemploMVCContador;
using Models;

namespace Controllers
{
    class Controlador
    {
        private Form1 form1;
        private Contador contador;

        public Controlador(Form1 f, Contador c)
        {
            form1 = f;
            contador = c;

            f.OnIncrementar += Incrementar;
        }

        public void Incrementar()
        {
            contador.Incrementar();
            form1.SetTexto(contador.Valor.ToString());
        }
    }
}
