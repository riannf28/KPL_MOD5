using System;

namespace modul5_1302200040
{
    class Program
    {
        static void Main(string[] args)
        {
            SayaTubeUser user = new SayaTubeUser("Rian Nur Fauzi");
            SayaTubeVideo video1 = new SayaTubeVideo("Ready Player One");
            SayaTubeVideo video2 = new SayaTubeVideo("Spiderman 1");
            SayaTubeVideo video3 = new SayaTubeVideo("Thor");
            SayaTubeVideo video4 = new SayaTubeVideo("Joker");
            SayaTubeVideo video5 = new SayaTubeVideo("The Sniper");
            SayaTubeVideo video6 = new SayaTubeVideo("1917");
            SayaTubeVideo video7 = new SayaTubeVideo("Fast & Furious");
            SayaTubeVideo video8 = new SayaTubeVideo("Black Widow");
            SayaTubeVideo video9 = new SayaTubeVideo("Justice League");
            SayaTubeVideo video10 = new SayaTubeVideo("Ip Man");

            video1.PrintVideoDetails();
            video2.PrintVideoDetails();
            video3.PrintVideoDetails();
            video4.PrintVideoDetails();
            video5.PrintVideoDetails();
            video6.PrintVideoDetails();
            video7.PrintVideoDetails();
            video8.PrintVideoDetails();
            video9.PrintVideoDetails();
            video10.PrintVideoDetails();

            Console.WriteLine("Review Film " + video1.getTitle() + " oleh " + user.getUsername());

        }
    }
}
