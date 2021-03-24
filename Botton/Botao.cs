using System;

namespace Botoes
{
    abstract class Botao
    {
        protected string rotulo;
        private bool estado;
        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        abstract public void Click();

        public void MostraBotao()
        {
            if (estado)
            {
                Console.WriteLine($"O botão {rotulo} está ativado!");
            }
            else
            {
                Console.WriteLine($"O botão {rotulo} está desativado!");
            }
        }

    }
}
