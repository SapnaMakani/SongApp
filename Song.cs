using System;
using System.Collections.Generic;
using System.Text;

namespace SongApp
{
    public record Song(
    string Title,
    string Artist,
    int DurationSeconds
);
}
