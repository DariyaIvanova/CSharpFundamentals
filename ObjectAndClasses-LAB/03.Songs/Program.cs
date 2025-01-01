namespace _03.Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            List<Song> songs = new();

            for (int i = 0; i < count; i++)
            {
                string[] songProperties = Console.ReadLine().Split("_").ToArray();
                Song song = new(songProperties[0], songProperties[1], songProperties[2]);
                songs.Add(song);
            }
            string typeList = Console.ReadLine();

            if (typeList=="all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (song.TypeList==typeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }
    public class Song
    {
        public Song(string typelist, string name, string time)
        {
            TypeList = typelist;
            Name = name;
            Time = time;
        }

        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}
