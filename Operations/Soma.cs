using QuickCalculator.Utils;

namespace QuickCalculator.Operations{

struct Soma{

    public  Soma(){
        var valueUser = new InputUser().Read();

        float resultado = valueUser.VALUE01+valueUser.VALUE02;
        new Message($"{valueUser.VALUE01} + {valueUser.VALUE02} = {resultado}").Return();
    }

}
}