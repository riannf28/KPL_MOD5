using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Text;

namespace modul5_1302200040
{
    class SayaTubeVideo
    {
        private int id;
        private String title;
        private int playCount;

        public SayaTubeVideo(String title)
        {
            this.title = title;
            String number = "";
            Random rnd = new Random();
            id = rnd.Next(1, 100000);
            number += id.ToString("D5");
            playCount = 0;
        }

        public String getTitle()
        {
            return title;
        }

        public void IncreasePlayCount(int playCount)
        {
            Debug.Assert(playCount >= 0, "Input play count tidak boleh berupa bilangan negatif");
            this.playCount = checked(this.playCount + playCount);
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID : " + id);
            Console.WriteLine("TITLE : " + title);
            Console.WriteLine("playCount : " + playCount);
        }
    }
}
