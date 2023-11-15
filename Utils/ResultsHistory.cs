using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Xml.Linq;


namespace QuickCalculator{

    struct ResultsHistory{
        
        private static List<String> history = JsonSerializer.Deserialize<List<string>>(File.ReadAllText(".\\cache\\resultHistory.json"));
        public void setHistory(String resut){

            history.Add(resut);
            SaveHistory();

        }

        public List<string> getHistory()
        {
        string caminhoArquivo = ".\\cache\\resultHistory.json";

        try
            {
                string json = File.ReadAllText(caminhoArquivo);

                List<string> listaDeStrings = JsonSerializer.Deserialize<List<string>>(json);

                return listaDeStrings;
            }
        catch(Exception)
            {
                string json = JsonSerializer.Serialize(new List<string>());
                File.WriteAllText(".\\cache\\resultHistory.json", json);
                return null;
                
            }
        }

        public void SaveHistory(){

            string json = JsonSerializer.Serialize(history);
            File.WriteAllText(".\\cache\\resultHistory.json", json);

        }

        
        public void outHistory(){
          
            foreach(string value in getHistory()){

                new Message(value).Return();
            }
        }

        public void cleanCache(){
            File.WriteAllText(".\\cache\\resultHistory.json", JsonSerializer.Serialize(new List<string>()));
        }
    }
}