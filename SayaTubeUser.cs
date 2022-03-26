using System;
using System.Collections.Generic;
using System.Text;

namespace modul5_1302200040
{
    class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos = new List<SayaTubeVideo>();
        private String Username;
        public SayaTubeUser(String Username)
        {
            this.Username = Username;
            uploadedVideos = new List<SayaTubeVideo>();
            
        }

        public int GetTotalVideoPlayCount()
        {
            return uploadedVideos.Count;
        }

        public void AddVideo(SayaTubeVideo video)
        {
            uploadedVideos.Add(video);
        }

        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine("User: " + Username);
            Console.WriteLine("Video 1 judul: " + uploadedVideos);
            Console.WriteLine("Video 2 judul: " + uploadedVideos);
            Console.WriteLine("Video 3 judul: " + uploadedVideos);
            Console.WriteLine("Video 4 judul: " + uploadedVideos);
            Console.WriteLine("Video 5 judul: " + uploadedVideos);
            Console.WriteLine("Video 6 judul: " + uploadedVideos);
            Console.WriteLine("Video 7 judul: " + uploadedVideos);
            Console.WriteLine("Video 8 judul: " + uploadedVideos);
            Console.WriteLine("Video 9 judul: " + uploadedVideos);
            Console.WriteLine("Video 10 judul: " + uploadedVideos);
        }
    }
}
