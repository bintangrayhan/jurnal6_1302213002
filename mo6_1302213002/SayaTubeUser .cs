using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mo6_1302213002
{
    internal class SayaTubeUser
    {
        int id;
        string username;
        List<SayaTubeVideo> uploudedVideos;

        public SayaTubeUser(string username)
        {
            Contract.Requires(username != null);
            Contract.Requires(username.Length <= 100);
            this.uploudedVideos = new List<SayaTubeVideo>();
            username = username;
            this.id = new Random().Next(10000, 99999);

        }
        public int GetTotalVideoPlayCount()
        {
            int jumlah = 0;
            for (int i = 0; i < uploudedVideos.Count; i++)
            {
                jumlah += uploudedVideos[i].getplaycount();
            } 
            return jumlah;
        }
        public void Addvideo(SayaTubeVideo video)
        {
            this.uploudedVideos.Add(video);
        }
        public void printAllvideo()
        {
            Console.WriteLine( id);
            Console.WriteLine(username);
            Console.WriteLine(GetTotalVideoPlayCount());  
        }


    }
}
