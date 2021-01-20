using System;

namespace G2.DK.Domain.Aggregates.Character
{
    public class Character
    {
        private string _name;
        private string _description;

        public int Id { get; }
        public string Name => _name;
        public string Description => _description;

        private Character() { } // EF Core needs it

        private Character(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public static Character Create(string name, string description)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Parameter cannot be empty", nameof(name));

            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("Parameter cannot be empty", nameof(description));

            return new Character(name, description);
        }
    }
}
