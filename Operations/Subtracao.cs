using QuickCalculator.MainMenu;
using QuickCalculator.Utils;

namespace QuickCalculator.Operations{

    struct Subtracao{

        public Subtracao(){

            var valueUser = new InputUser().Read();
            float resultado = valueUser.VALUE01 - valueUser.VALUE02;
            new Message($"{valueUser.VALUE01} - {valueUser.VALUE02} = {resultado}").Return();
            new ResultsHistory().setHistory($":::::::: {valueUser.VALUE01} - {valueUser.VALUE02} = {resultado} ::::::::");
            new Menu().Init();
           
        }
    }
}