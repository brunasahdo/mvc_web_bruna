using E_JOGOS.Interface;
using System;
using System.Collections.Generic;
using System.IO;

namespace E_JOGOS.Models
{
    public class Equipe:E_JOGOSBase,IEquipe

    {

         private const string path = "database/equipe.csv"; //atributo


        //Construtor 
        public Equipe()
        {
            CreateFolderandFile(path);
        }


        //Propriedades
        public int IdEquipe { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; } //Vamos aprender a gravar uma imagem


        //Métodos

         

        //Métodos exigidos pela interface
        
        public void Create(Equipe nova_equipe) //recebe o objeto e grava no csv
        {

            //
           string[] linha = { $"{nova_equipe.IdEquipe}; {nova_equipe.Nome}; {nova_equipe.Imagem}" }; //como as infos serão gravadas
            //se quiser, fazer um método Prepare que retorna a string acima

           // File.AppendAllText(path, $"{nova_equipe.IdEquipe}; {nova_equipe.Nome}; {nova_equipe.Imagem}/n"); 
            //Não funciona porque não pula linhas no csv

           File.AppendAllLines(path, linha); //recebe array na segunda entrada. Então definimos acima um array de tamanho 1.
        }

        public void Delete(int idEquipe)
        {
            throw new System.NotImplementedException();
        }

        public List<Equipe> ReadAll()
        {
            List<Equipe> equipes = new();
            string[] linhas = File.ReadAllLines(path);

            foreach (string linha in linhas)
            {
                Equipe equipe = new Equipe();
                equipe.IdEquipe = int.Parse(linha.Split(';')[0]);
                equipe.Nome = linha.Split(';')[1];
                equipe.Imagem = linha.Split(';')[2];

                equipes.Add(equipe);
            }

            return equipes;


        }

        public void Update(Equipe equipe)
        {
            throw new System.NotImplementedException();
        }

        


    }
}
