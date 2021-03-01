using System;

Main();

void Main()
{
    Console.WriteLine("Welcome to the Magic Moose!!");
    Console.WriteLine("--------------------------------------------");



    //let the moose ask a question
    MooseAnswers("this is an answer");
}

void MooseAsk()
{
    Console.WriteLine("Ask me Anything");
    Console.ReadLine();
}

int RandomNumber()
{
    Random r = new Random();
    int genRand = r.Next(0, 19);
    Console.WriteLine("Random Number = " + genRand);
    return genRand;
}
void MooseAnswers(string answer)
{
    Console.WriteLine($@"
                                      _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {answer}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}


{
    case 0:
        Console.WriteLine("As I see it, yes.");
    break;
    case 1:
        Console.WriteLine("Ask again later.");
    break;
    case 2:
        Console.WriteLine("Better not tell you now.");
    break;
    case 3:
        Console.WriteLine("Cannot predict now.");
    break;
    case 4:
        Console.WriteLine(" Concentrate and ask again.");
    break;
    case 5:
        Console.WriteLine("Don’t count on it.");
    break;
    case 6:
        Console.WriteLine(" It is certain.");
    break;
    case 7:
        Console.WriteLine("It is decidedly so.");
    break;
    case 8:
        Console.WriteLine("Most likely.");
    break;
    case 9:
        Console.WriteLine("My reply is no.");
    break;
    case 10:
        Console.WriteLine("My sources say no.");
    break;
    case 11:
        Console.WriteLine("Outlook not so good.");
    break;
    case 12:
        Console.WriteLine("Outlook good.");
    break;
    case 13:
        Console.WriteLine("Reply hazy, try again.");
    break;
    case 14:
        Console.WriteLine("Signs point to yes.");
    break;
    case 15:
        Console.WriteLine("Very doubtful.");
    break;
    case 16:
        Console.WriteLine("Without a doubt.");
    break;
    case 17:
        Console.WriteLine("Yes.");
    break;
    case 18:
        Console.WriteLine("Yes – definitely.");
    break;
    case 19:
        Console.WriteLine("You may rely on it.");
    break;
}