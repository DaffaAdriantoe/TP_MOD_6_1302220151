using TPMODUL6_1302220151;

internal class Program
{
    private static void Main(string[] args)
    {
        SayaTubeVidio video = new SayaTubeVidio("Tutorial Design By Contract - Daffa Adrianto Effendi");
        video.increasePlayCount(0);
        video.printVideoDetails();

        SayaTubeVidio video2 = new SayaTubeVidio("RandomRandomAjaaaaakadadanajdnanafnkfanfjcsnfuwbsjbsjvbeubvsjvbujbwfbjwbgjsb");
        for (int i = 0; i < 30; i++)
        {
            video2.increasePlayCount(1000000);
        }
        video2.printVideoDetails();
    }

    

    
}