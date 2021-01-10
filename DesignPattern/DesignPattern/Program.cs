using DesignPattern.classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace DesignPattern
{
    class Program
    {
        

        static void Main(string[] args)
        {
            BD meuBd = new BD();
            //AQUI EH UM TREINO PARA DECORATOR
            MonstroAtacante a = new MonstroAtacante(meuBd.Monstros[0]);
            Console.WriteLine(a.AtkEmAtk(meuBd.Monstros[1])); 



        }
    }
}
