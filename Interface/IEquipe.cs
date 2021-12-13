using E_JOGOS.Models;
using System.Collections.Generic;

namespace E_JOGOS.Interface
{/// <summary>
/// Responsável por determinar quais métodos uma clase precisa ter. É o "contrato da classe"
/// </summary>
//é o comentário que aparece quando passamos o cursor em um objeto daqui
    public interface IEquipe
    {
        //CREATE 

        //READALL 

        //UPDATE

        //DELETE


        void Create(Equipe nova_equipe); 

        List<Equipe> ReadAll(); //uma classe não deixa escrever essa linha sem corpo

        void Update(Equipe equipe);

        void Delete(int idEquipe);


        
        
    }
}
