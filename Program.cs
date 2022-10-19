using System.Diagnostics;
namespace LAB_1;
class Program
{
    static void Main(string[] args){
    int choice = 0;
    Random rnd = new Random();
       
        while(choice == 0){
            Console.WriteLine("\nLets play RPS\n\nChoose Rock [R], Paper [P] or scissors [S]\n");
            String player = Console.ReadLine()!;
            player = player.ToUpper().Trim();
            Console.WriteLine($"You have chosen: {player}\n");
            int ran = rnd.Next(1,4);
            String computer = "";

            if (player != "R" && player != "P" && player != "S" ){
                Console.WriteLine("Computer is confused, try again!\n");
                break;
            }

            switch (ran){
                case 1: {computer = "R"; break;}
                case 2: {computer = "P"; break;}
                case 3: {computer = "S"; break;}
            }
            Console.WriteLine($"Computer selected: {computer}\n");
            
            
            if(player == computer){
                Console.WriteLine("It's a tie\n");
            }
            else if (player == "R") {
                if(computer == "P"){Console.WriteLine("Computer wins!\n");}
                else {Console.WriteLine("You win!");}
            }
            else if (player == "P") {
                if(computer == "S"){Console.WriteLine("Computer wins!\n");}
                else {Console.WriteLine("You win!");}
            }
            else if (player == "S") {
                if(computer == "R"){Console.WriteLine("Computer wins!\n");}
                else {Console.WriteLine("You win!\n");}
            }

            Console.WriteLine("Do you want to play again?\n\nYes [Y] or No [N]\n");

            String yesOrNo = Console.ReadLine()!;
            yesOrNo = yesOrNo.ToUpper().Trim();

            if (yesOrNo == "Y"){
                Console.WriteLine("Got u\n");
            }
            else if (yesOrNo == "N"){
                Console.WriteLine("It was nice to play with you!!!\n");
                break;
            }



        }
        

    }
}
