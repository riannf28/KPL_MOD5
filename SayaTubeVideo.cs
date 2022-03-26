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
            Debug.Assert(title.Length <= 200, "Judul video maksimal 200 karakter");
            Contract.Requires(this.title != null);
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
            Debug.Assert(playCount <= 25000000, "Input penambahan play count maksimal 25.000.000");
            Debug.Assert(playCount >= 0, "Input play count tidak boleh berupa bilangan negatif");
            try
            {
                this.playCount = checked(this.playCount + playCount);
            }
            catch (System.OverflowException e)
            {
                Console.WriteLine("Check : " + e.ToString());
                Console.WriteLine("Melebihi batas input");
            }
            
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID : " + id);
            Console.WriteLine("TITLE : " + title);
            Console.WriteLine("playCount : " + playCount);
        }
    }
}
