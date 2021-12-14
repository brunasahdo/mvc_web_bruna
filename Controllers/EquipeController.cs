using E_JOGOS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_JOGOS.Controllers
{
    public class EquipeController : Controller
    {
        //IActionResult é um tipo vindo da classe controller. Dá o "status de resposta HTTP"(?). Um exemplo é o 404:Not found
        //200:Requisição bem sucedida (OK)
        //307:temporary redirect
        //500: Internal Server error

        Equipe equipeModel = new();
        public IActionResult Index()
        {

            //VIEW = responsável pela exibição do frontend
            //Viewbag = armazena as informações do backend
            //para serem acessadas no frontend (controller pra view).

            ViewBag.Equipes = equipeModel.ReadAll();

            return View();
        }

        public IActionResult Cadastrar(IFormCollection form)
        {
            //criar um objeto equipe a partir do frontend (IFormCollection)
            Equipe nova_equipe = new Equipe();
            nova_equipe.IdEquipe = int.Parse(form["IdEquipe"]);
            nova_equipe.Nome = form["Nome"];
            nova_equipe.Imagem = form["Imagem"];

            //chamando a funcao create do objeto passando a nova equipe.
            equipeModel.Create(nova_equipe);


            ViewBag.Equipes = equipeModel.ReadAll();


            return LocalRedirect("~/Equipe");
        }
        public IActionResult Remover(IFormCollection form)
        {
            int ID = int.Parse(form["IdDeletar"]);

            equipeModel.Delete(ID);

            ViewBag.Equipes = equipeModel.ReadAll();

            return LocalRedirect("~/Equipe");
        }
        
    }
}
