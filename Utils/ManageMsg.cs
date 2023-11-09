using System;

namespace QuickCalculator{

public struct Message{

    private string _message;
     public Message(string msg){
        _message = msg;
    }

    public void Error(){

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(_message);
            Console.ResetColor();

    }

    public void Return(){
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        var resutFormat = $"::::::: {_message} :::::::";
        Console.WriteLine(resutFormat);
        new ResultsHistory().setHistory(resutFormat);
        Console.ResetColor();

    }


}
}