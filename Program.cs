using System;
//still gives one more answer after white space is entered
bool stillAsking = true;
Main();

void Main()
{
    Console.WriteLine("Welcome to the Magic Moose!!");
    Console.WriteLine("--------------------------------------------");
    while (stillAsking)
    {
        MooseAsk();
    }
}

void MooseAsk()
{
    Console.Write("Ask me Anything: ");
    string question = Console.ReadLine();
    if (String.IsNullOrWhiteSpace(question))
    {
        stillAsking = false;
        MooseAnswers("Bye!");
        return;
    }
    int caseSwitch = RandomNumber();
    MooseAnswers(MagicMooseGetAnswer(caseSwitch));
}

int RandomNumber()
{
    Random r = new Random();
    int genRand = r.Next(0, 19);
    // Console.WriteLine("Random Number = " + genRand);
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
string MagicMooseGetAnswer(int caseSwitch)
{
    string answer = " ";
    switch (caseSwitch)
    {
        case 0:
            answer = "As I see it, yes.";
            return answer;
        case 1:
            answer = "Ask again later.";
            return answer;
        case 2:
            answer = "Better not tell you now.";
            return answer;
        case 3:
            answer = "Cannot predict now.";
            return answer;
        case 4:
            answer = " Concentrate and ask again.";
            return answer;
        case 5:
            answer = "Don’t count on it.";
            return answer;
        case 6:
            answer = " It is certain.";
            return answer;
        case 7:
            answer = "It is decidedly so.";
            return answer;
        case 8:
            answer = "Most likely.";
            return answer;
        case 9:
            answer = "My reply is no.";
            return answer;
        case 10:
            answer = "My sources say no.";
            return answer;
        case 11:
            answer = "Outlook not so good.";
            return answer;
        case 12:
            answer = "Outlook good.";
            return answer;
        case 13:
            answer = "Reply hazy, try again.";
            return answer;
        case 14:
            answer = "Signs point to yes.";
            return answer;
        case 15:
            answer = "Very doubtful.";
            return answer;
        case 16:
            answer = "Without a doubt.";
            return answer;
        case 17:
            answer = "Yes.";
            return answer;
        case 18:
            answer = "Yes – definitely.";
            return answer;
        case 19:
            answer = "You may rely on it.";
            return answer;
    }
    return answer;
}