using Newtonsoft.Json;

namespace PokeAPI.Models
{
    public class Pokemon
    {
        [JsonConstructor]
        private Pokemon(
            int id,
            string name,
            int weight,
            int height)
        {
            Id = id;
            Name = name;
            Weight = weight;
            Height = height;
        }

        public int Id { get; }
        public string Name { get; }
        public int Weight { get; }
        public int Height { get; }
    }
}