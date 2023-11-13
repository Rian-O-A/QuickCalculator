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
        Console.ForegroundColor = ConsoleColor.Yellow;
        
        Console.WriteLine(_message);
        Console.ResetColor();

    }


}
}