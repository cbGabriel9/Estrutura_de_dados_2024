using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula01
{
    class TipoEnum //Classe dos enumeradores
    {
        public enum Classes //Criando um enumerador
        {
            Guerreiro, Arqueiro, Assassino, Mago //Constantes do enumerador
        }

        public Classes _classe = Classes.Guerreiro; //Declaração de uma variável (_classe). O "." é um operador de acesso;

        public Classes GetClasseEnum(string _classe) //Criação do método para pegar a classe contida no enumerador. O "Classes" está ali pois é o tipo do retorno daquela função, sendo o que está dentro dos parênteses um parâmetro
        {
            switch (_classe.ToLower())
            {
                case "guerreiro":
                    return Classes.Guerreiro;

                case "arqueiro":
                    return Classes.Arqueiro;

                case "assassino":
                    return Classes.Assassino;

                case "mago":
                    return Classes.Mago;

                default :
                    return Classes.Guerreiro;
            }
        }
    }
}