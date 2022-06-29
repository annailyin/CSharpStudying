using System;
using TrainingLib;

namespace TrainingSite
{
    class Program
    {
        static void Main(string[] args)
        {
            TrainingSession session = new TrainingSession { Description = "test" };
            Console.WriteLine(session.Guid);
            Console.WriteLine(session.Description);
            session.TrainingMaterials.Add(new VideoMaterial("www.youtube.com", "www.screensavers.org", VideoFormat.AVI));
            session.TrainingMaterials.Add(new NetworkResourceReference("www.youtube.com", ReferenceType.Video));
            Console.WriteLine(session.GetSessionType());
            session.Description = "Test session";
            Console.WriteLine(session.ToString());
        }
    }
}
