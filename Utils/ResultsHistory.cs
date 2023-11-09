using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Xml.Linq;


namespace QuickCalculator{

    struct ResultsHistory{
        
        private static List<String> history = new List<string>();
        public void setHistory(String resut){

            history.Add(resut);

        }

        public List<String> getHistory(){
           
        string caminhoArquivo = ".\\cache\\resultHistory.json";

       
        string json = File.ReadAllText(caminhoArquivo);

        List<string> listaDeStrings = JsonSerializer.Deserialize<List<string>>(json);

        return listaDeStrings;
        }

        public void SaveHistory(){

            string json = JsonSerializer.Serialize(history);
            File.WriteAllText(".\\cache\\resultHistory.json", json);

        }

        internal static void setHistory()
        {
            throw new NotImplementedException();
        }
    }
}