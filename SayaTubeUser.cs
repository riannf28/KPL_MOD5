using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
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
            Debug.Assert(Username.Length <= 100, "Username maksimal 100 karakter");
            Contract.Requires(this.Username != null);
            this.Username = Username;
            Contract.Requires(uploadedVideos != null);
            uploadedVideos = new List<SayaTubeVideo>();
            
        }

        public String getUsername()
        {
            return Username;
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
