using _008_FacadePattern.Devices;

namespace _008_FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var homeTheater = new HomeTheaterFacade(new Amplifier(), new Tuner(),
                new DvdPlayer(), new CdPlayer(), new Projector(), new Screen(),
                new TheaterLights(), new PopcornPopper());
            homeTheater.WatchMovie("Raiders of the Lost Ark");
            homeTheater.EndMovie();
        }
    }
}
