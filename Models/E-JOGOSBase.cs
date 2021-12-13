using System.IO;

namespace E_JOGOS.Models
{
    public class E_JOGOSBase
    {
        //criar uma função para criar a pasta e o arquivo, caso não existam
        public void CreateFolderandFile(string path)
        {
            //pasta / arquivo.csv
            string folder = path.Split('/')[0];
            string file = path.Split('/')[1];

            if (!Directory.Exists(folder))
            { Directory.CreateDirectory(folder); }

            if (!File.Exists(file))
            { File.Create(path); }
        }
    }
}
