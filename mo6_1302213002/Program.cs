using mo6_1302213002;

class program
{
    static void Main(string[] args)
    {
        SayaTubeVideo video1 = new SayaTubeVideo("bintang lagu a");
        SayaTubeVideo video2 = new SayaTubeVideo("bintang lagu b");
        SayaTubeVideo video3= new SayaTubeVideo("bintang lagu c");
        SayaTubeVideo video4 = new SayaTubeVideo("bintang lagu d");
        SayaTubeVideo video5 = new SayaTubeVideo("bintang lagu e");
        SayaTubeVideo video6 = new SayaTubeVideo("bintang lagu f");
        SayaTubeVideo video7 = new SayaTubeVideo("bintang lagu g");
        SayaTubeVideo video8 = new SayaTubeVideo("bintang lagu h");
        SayaTubeVideo video9 = new SayaTubeVideo("bintang lagu i");
        SayaTubeVideo video10 = new SayaTubeVideo("bintang lagu j");

        video1.increasplaycount(1000000);
        video2.increasplaycount(1000000);
        video3.increasplaycount(1000000);
        video4.increasplaycount(1000000);
        video5.increasplaycount(1000000);
        video6.increasplaycount(1000000);
        video7.increasplaycount(1000000);
        video8.increasplaycount(1000000);
        video9.increasplaycount(1000000);
        video10.increasplaycount(1000000);

        video1.printvideodetails();
        video2.printvideodetails();
        video3.printvideodetails();
        video4.printvideodetails();
        video5.printvideodetails();
        video6.printvideodetails();
        video7.printvideodetails();
        video8.printvideodetails();
        video9.printvideodetails();
        video10.printvideodetails();

        SayaTubeUser user = new SayaTubeUser("bintang rayhan");
        user.Addvideo(video1);
        user.Addvideo(video2);
        user.Addvideo(video3);
        user.printAllvideo();
    }
}