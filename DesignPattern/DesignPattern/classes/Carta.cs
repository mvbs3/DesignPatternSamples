using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace DesignPattern.classes
{
    class Carta : IEquatable<Carta>
    {
        public Carta(string nome, int nivel, string atributo, string tipo, int ataque, int defesa)
        {
            this.Nome = nome;
            this.nivel = nivel;
            this.atributo = atributo;
            this.tipo = tipo;
            this.ataque = ataque;
            this.defesa = defesa;
        }
        public string Nome{ get; set; }
        public int nivel { get; set; }
        public string atributo { get; set; }
        public string tipo{ get; set; }
        public int ataque{ get; set; }
        public int defesa { get; set; }
        public bool Equals([AllowNull] Carta other)
        {
            return (this.Nome == other.Nome);
        }
    }
}
