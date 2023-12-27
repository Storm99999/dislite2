using dislite.src.UTILS;
using Newtonsoft.Json;
namespace dislite.src.MODELS
{
    internal class Channel
    {
        [JsonProperty]
        private string id { get; set; }
        [JsonProperty]
        private int type { get; set; }
        [JsonProperty]
        private string name { get; set; }

        [JsonIgnore]
        public ChannelType Type => (ChannelType)type;

        [JsonIgnore]
        public string Name => name;

        [JsonIgnore]
        public Snowflake Id => Snowflake.Parse(id);

        public override string ToString()
        {
            return $"{id}: {Name}";
        }
    }
}
