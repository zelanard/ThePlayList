using System;

namespace ThePlayList.Model
{
    /// <summary>
    /// <c>Generator</c> contains methods to randomly generate values.
    /// </summary>
    public static class Generator
    {
        private static Random rnd = new Random();
        /// <summary>
        /// Generates a random track name.
        /// </summary>
        /// <returns></returns>
        public static string TrackAlbumName()
        {
            string[] adjectives = new string[] { "Beautiful", "Mysterious", "Enchanted", "Magical", "Epic", "Sunny", "Whimsical", "Dreamy", "Funky", "Melancholic", "Glorious", "Radiant", "Captivating", "Serene", "Passionate", "Ethereal", "Soothing", "Gentle", "Vibrant", "Wild", "Surreal", "Blissful", "Lively", "Tranquil", "Enigmatic", "Dazzling", "Hopeful", "Mesmerizing", "Dynamic", "Luminous", "Tender", "Wondrous", "Sensual", "Vivid", "Elegant", "Timeless", "Inspiring", "Majestic", "Harmonious", "Joyful", "Delicate", "Spiritual", "Fascinating", "Serendipitous", "Cinematic", "Dreamlike", "Otherworldly", "Breathtaking", "Daring", "Calm", "Thrilling", "Alluring", "Serenading", "Enthralling", "Electric", "Whispering", "Intoxicating", "Enlightening", "Epic", "Mythical", "Scenic", "Euphoric", "Mystical", "Celestial", "Enchanted", "Sensational", "Passion", "Infinite", "Radiant", "Glowing", "Blazing", "Heavenly", "Enveloping", "Golden", "Emerald", "Jubilant", "Silver", "Bewitching", "Resplendent", "Spellbinding", "Emergent", "Harmonic", "Echoing", "Astral", "Futuristic", "Silent", "Glistening", "Elusive", "Suspended", "Universal", "Ineffable", "Spectacular", "Delightful", "Whistling", "Reflective", "Encompassing", "Velvet", "Intriguing", "Tranquilizing", "Magnetic", "Paradise", "Dazzling", "Eclipsing", "Majestic", "Cascade", "Ethereal" };
            string[] nouns = new string[] { "Adventure", "Rainbow", "Universe", "Heart", "Dance", "Serenade", "Journey", "Harmony", "Dream", "Soul", "Whisper", "Symphony", "Rhythm", "Oasis", "Melody", "Fantasy", "Cascade", "Horizon", "Miracle", "Sunrise", "Horizon", "Mystery", "Legacy", "Infinity", "Euphoria", "Reflection", "Breeze", "Eclipse", "Desire", "Paradise", "Tranquility", "Lullaby", "Whimsy", "Echo", "Harbor", "Aurora", "Elegance", "Voyage", "Passion", "Sensation", "Aura", "Heaven", "Pulse", "Illusion", "Enchantment", "Destiny", "Metropolis", "Rapture", "Crescendo", "Embrace", "Enigma", "Majesty", "Abyss", "Jubilation", "Legacy", "Radiance", "Elevation", "Odyssey", "Serendipity", "Silhouette", "Cascade", "Velvet", "Reverie", "Elysium", "Labyrinth", "Harbor", "Synchrony", "Reverie", "Inception", "Inferno", "Solitude", "Symmetry", "Horizon", "Paragon", "Pandemonium", "Vortex", "Whirlwind", "Utopia", "Ebullience", "Phenomenon", "Wonderland", "Sentiment", "Spectrum", "Nirvana", "Whispers", "Desolation", "Legacy", "Genesis", "Imagination", "Dawn", "Solstice", "Quasar", "Cascade", "Whisper", "Voyage", "Luminance", "Whimsy", "Sensation", "Synchrony", "Reverie" };
            return $"{adjectives[rnd.Next(0, adjectives.Length - 1)]} {nouns[rnd.Next(0, nouns.Length - 1)]}";
        }

        /// <summary>
        /// Generate a random artist name.
        /// </summary>
        /// <returns></returns>
        public static string GetRandomName()
        {
            string[] firstNames = { "John", "Jane", "Michael", "Emily", "William", "Olivia", "James", "Sophia", "Benjamin", "Emma", "Daniel", "Ava", "Matthew", "Isabella", "Joseph", "Mia", "David", "Charlotte", "Andrew", "Lucy", "Ethan", "Grace", "Christopher", "Lily", "Daniel", "Sophia", "Alexander", "Chloe", "Matthew", "Amelia", "Nicholas", "Abigail", "William", "Ella", "Samuel", "Madison", "Joseph", "Scarlett", "Nathan", "Avery", "Thomas", "Sofia", "Jacob", "Hannah", "Christopher", "Elizabeth", "Anthony", "Victoria", "Joshua", "Penelope", "Ryan", "Natalie", "Elijah", "Zoe", "Liam", "Audrey", "Tyler", "Layla", "William", "Aria", "Alexander", "Madeline", "Mason", "Hazel", "Luke", "Leah", "Evan", "Aubrey", "Christian", "Nora", "Isaac", "Aurora", "Dylan", "Brooklyn", "Carter", "Riley", "Gabriel", "Ellie", "Logan", "Savannah", "Jack", "Alice", "Jackson", "Stella", "Owen", "Maya", "Henry", "Julia", "Sebastian", "Evelyn", "Landon", "Claire", "Zachary", "Abigail", "Eli", "Harper", "Nathaniel", "Lillian", "Gavin", "Anna" };
            string[] lastNames = { "Smith", "Johnson", "Brown", "Davis", "Wilson", "Lee", "Anderson", "Harris", "Clark", "White", "Walker", "Hall", "Young", "Allen", "King", "Wright", "Turner", "Hill", "Carter", "Scott", "Adams", "Mitchell", "Robinson", "Garcia", "Martinez", "Miller", "Thomas", "Hernandez", "Moore", "Martin", "Jackson", "Thompson", "Lewis", "Lewis", "Allen", "Young", "Wright", "Turner", "Hill", "Carter", "Scott", "Adams", "Mitchell", "Robinson", "Garcia", "Martinez", "Miller", "Thomas", "Hernandez", "Moore", "Martin", "Jackson", "Thompson", "Lewis", "Allen", "Young", "Wright", "Turner", "Hill", "Carter", "Scott", "Adams", "Mitchell", "Robinson", "Garcia", "Martinez", "Miller", "Thomas", "Hernandez", "Moore", "Martin", "Jackson", "Thompson", "Lewis", "Walker", "Hall", "Young", "Allen", "King", "Wright" };
            return $"{firstNames[rnd.Next(firstNames.Length - 1)]} {lastNames[rnd.Next(lastNames.Length - 1)]}";
        }
        /// <summary>
        /// Generate a random track duration.
        /// </summary>
        /// <returns></returns>
        public static TimeSpan GetRandomDuration()
        {
            return new TimeSpan(0, rnd.Next(1, 13), rnd.Next(0, 60));
        }
    }
}
