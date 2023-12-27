using System;

namespace dislite.src.MODELS
{
    internal class DiscordMessage
    {
        public Author Author { get; set; }
        public string Content { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
