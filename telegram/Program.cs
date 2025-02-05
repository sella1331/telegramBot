
string messageUser = "start";
string contact = "+777777777777, adres = city, work hours 08:00 - 20:00";
string information = "we're glad to see you";
OutMessageBot(messageUser);
Console.WriteLine("Bye-bye");

void OutMessageBot(string message)
{
    while (message != "/stop")
    {                  
        Console.WriteLine("Hi, my dear Friend\nPlease, nessesary commands");
        Console.WriteLine("/контакты\n/информация\n/заказать\n/stop");
        message = Console.ReadLine();
        switch (message)
        {
            case ("/контакты"):
                Console.WriteLine(contact);
                break;
            case ("/заказать"):
                GetChoiceOrder();
                break;
            case ("/информация"):
                Console.WriteLine(information);
                break;
            default: Console.WriteLine("sorry, you are blunt "); break;

        }
    }
}

string GetChoiceOrder()
{ string choiceOrder = "";
    string allPacket = "bla-bla-bla\n2-la-la-la\n3 - bla-bla-bla";                         
    Console.WriteLine("Выберете пакет услуг\n/exit\n" + allPacket);
    choiceOrder =  Console.ReadLine();
    Console.WriteLine("Введите дату в формате дд.мм.гг");
    choiceOrder +="\n" + Console.ReadLine();                     
    Console.WriteLine(choiceOrder);
    return choiceOrder.Trim();
}