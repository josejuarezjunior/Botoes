using System;

namespace Botoes
{
    class Cancela : Botao
    {
        public Cancela()
        {
            base.rotulo = "Cancelar";
            Estado = false;
        }
        public override void Click()
        {
            if (Estado)
            {
                Console.WriteLine("Cancelando!");
            }
        }
    }
}
