using System;

namespace QuickCalculator{

public struct Message{

    private string _message;
     public Message(string msg){
        _message = msg;
    }

    public void Error(){

            new ScreenConsole().Red();
            Console.WriteLine(_message);
            new ScreenConsole().ResetColor();

    }

    public void Return(){

        new ScreenConsole().Yellow();
        Console.WriteLine(_message);
        new ScreenConsole().ResetColor();

    }


}
}