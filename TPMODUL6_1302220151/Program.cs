using TPMODUL6_1302220151;

internal class Program
{
    private static void Main(string[] args)
    {
        SayaTubeVidio video = new SayaTubeVidio("Tutorial Design By Contract - Daffa Adrianto Effendi");
        video.increasePlayCount(0);
        video.printVideoDetails();
    }

    
}