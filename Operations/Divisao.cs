using QuickCalculator.Utils;

namespace QuickCalculator.Operations{

    struct Divisao{

        public Divisao(){
           
            var valueUser = new InputUser().Read();

            float resultado = valueUser.VALUE01 / valueUser.VALUE02;
            Console.WriteLine($"{valueUser.VALUE01} / {valueUser.VALUE02} = {resultado}");
            new ResultsHistory().setHistory($":::::::: {valueUser.VALUE01} / {valueUser.VALUE02} = {resultado} ::::::::");
        }
    }
}
