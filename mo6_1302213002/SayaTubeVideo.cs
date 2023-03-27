using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mo6_1302213002
{
    public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playcount;

        public SayaTubeVideo(string title)
        {
            Contract.Requires(title != null);
            Contract.Requires(title.Length <= 100);

            Random rand = new Random();
            id = rand.Next(10000, 99999);
            this.title = title;
            playcount = 0;
        }
        public void increasplaycount(int count)
        {
            Contract.Requires(count <= 10000000);
            try
            {
                checked
                {
                    this.playcount += count;
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("eror : {0}", ex.Message);
            }
        }
        public void printvideodetails()
        {
            Console.WriteLine($"video id    : {id}");
            Console.WriteLine($"title       : {title}");
            Console.WriteLine($"play count  : {playcount}");
        }
        public int getplaycount() { 
            
            return this.playcount;  
        }

    }
    
}
