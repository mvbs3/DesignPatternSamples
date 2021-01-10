using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.classes
{
    class MonstroAtacante
    {
        Carta meuMonstro;
        public MonstroAtacante(Carta monstro)
        {
            this.meuMonstro = monstro;
        }
        public string AtkEmAtk(Carta defensor)
        {
            int dano;
            string destruicao;
            dano =  this.meuMonstro.ataque - defensor.ataque;
            if (dano > 0)
            {
                destruicao = defensor.Nome +" foi destruido e foi causado " + dano + " de dano";
            }
            else if (dano == 0)
            {
                destruicao = this.meuMonstro.Nome+ " e " +defensor.Nome + "foram destruidos e nenhum dano foi causado";
            }
            else
            {
                dano = -dano;
                destruicao = this.meuMonstro.Nome + " foi destruido e foi causado " + dano + " de dano";
            }
            return destruicao;
        }

    }
}
