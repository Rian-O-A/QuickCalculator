using System;

namespace QuickCalculator{

public struct Message{

    private string _message;
     public Message(string msg){
        _message = msg;
    }

    public void Error(){

            new ScreenColor().Red();
            Console.WriteLine(_message);
            new ScreenColor().ResetColor();

    }

    public void Return(){

        new ScreenColor().Yellow();
        Console.WriteLine(_message);
        new ScreenColor().ResetColor();

    }


}
}