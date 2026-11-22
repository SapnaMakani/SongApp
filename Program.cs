
using SongApp;

Playlist playlist = new Playlist();

Console.WriteLine("===== MY PLAYLIST =====");

Console.Write("How many songs do you want to add? ");
int numberOfSongs = Convert.ToInt32(Console.ReadLine());

// Take song information from user
for (int i = 0; i < numberOfSongs; i++)
{
    Console.WriteLine($"Enter Song {i + 1} Details\n");

    Console.Write("Song Title: ");
    string title = Console.ReadLine()!;

    Console.Write("Artist Name: ");
    string artist = Console.ReadLine()!;

    Console.Write("Duration in seconds: ");
    int duration = Convert.ToInt32(Console.ReadLine());

    Song song = new Song(title, artist, duration);

    playlist.Add(song);
}

// Display playlist
Console.WriteLine("\n===== PLAYLIST =====");

for (int i = 0; i < playlist.Count; i++)
{
    Console.WriteLine(
        $"{i + 1}. {playlist[i].Title} - " +
        $"{playlist[i].Artist} - " +
        $"{playlist[i].DurationSeconds} seconds"
    );
}

// Display count and total duration
Console.WriteLine($"Total Songs: {playlist.Count}\n");
Console.WriteLine($"Total Duration: {playlist.TotalDuration} seconds\n");

// Record equality
Console.WriteLine("\n===== SONG EQUALITY =====");

Song song1 = new Song("Perfect", "Ed Sheeran", 263);
Song song2 = new Song("Perfect", "Ed Sheeran", 263);

Console.WriteLine($"Song 1 == Song 2: {song1 == song2}");

// With expression
Console.WriteLine("\n===== WITH EXPRESSION =====");

Song modifiedSong = song1 with
{
    Title = "Modified Perfect"
};

Console.WriteLine($"Original Song: {song1.Title}");
Console.WriteLine($"Modified Song: {modifiedSong.Title}");
