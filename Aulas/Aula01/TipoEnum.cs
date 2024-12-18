using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula01
{
    //Classe dos enumeradores
    class TipoEnum 
    {
        //Criando um enumerador
        public enum Classes 
        {
            //Constantes do enumerador
            Guerreiro, Arqueiro, Assassino, Mago 
        }

        //Declaração de uma variável (_classe). O "." é um operador de acesso;
        public Classes _classes = Classes.Guerreiro; 

        public TipoEnum()
        {   

        }

      /*   public TipoEnum(TipoEnum enum)
        {
            _classes = enum;
    } */

    //Criação do método para pegar a classe contida no enumerador. O "Classes" está ali pois é o tipo do retorno daquela função, sendo o que está dentro dos parênteses um parâmetro
    public Classes GetClassesEnum(string _classes) 
    {
        switch (_classes.ToLower())
        {
            case "guerreiro":
                return Classes.Guerreiro;

            case "arqueiro":
                return Classes.Arqueiro;

            case "assassino":
                return Classes.Assassino;

            case "mago":
                return Classes.Mago;

            default:
                return Classes.Guerreiro;
        }
    }
}
}