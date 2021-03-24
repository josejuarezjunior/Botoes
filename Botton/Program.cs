using System;

namespace Botoes {
    class Program {
        static void Main(string[] args) {
            Botao Cancela = new Cancela();
            Cancela.Click();
            Cancela.Estado = true;
            Cancela.Click();
            Cancela.MostraBotao();
        }
    }
}
