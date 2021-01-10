using DesignPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace DesignPattern.classes
{
    class BD : encheBD
    {
        public List<Carta> Monstros { get ; set ; }
        public BD()
        {
            preencherBDMonstros();
        }
        public void preencherBDMonstros()
        {
            this.Monstros = new List<Carta>();
            const string OldValue = @"\bin\Debug\netcoreapp3.1";
            const string NewValue = @"\simulacaoBD\meusMonstros.txt";
            string folder = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
            string diretorio = folder.Replace(OldValue, NewValue);
            //string text = System.IO.File.ReadAllText(diretorio);
            System.IO.StreamReader file = new System.IO.StreamReader(diretorio);
            string line;
            while ((line = file.ReadLine()) != null)
            {

                string[] linha = line.Split(";");
                 this.Monstros.Add(new Carta(linha[0], int.Parse(linha[1]),
                     linha[2], linha[3], int.Parse(linha[4]), int.Parse(linha[5])));
                Console.WriteLine(linha[0]);

            }
            //Console.WriteLine(this.Monstros[0].Nome);
        }
    }
}
