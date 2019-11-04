using System;
using System.Linq;
using System.Threading.Tasks;

namespace EugPassGen.Data
{
    public class WordService
    {
        private static readonly Word[] Words = new Word[]
        {
            new Word{
                    Name = "Golden",
                    Type = WordType.Adjective,
                    },
            new Word{
                    Name = "Unicorn",
                    Type = WordType.Noun,
                    },
            new Word{
                    Name = "Awesome",
                    Type = WordType.Adjective,
                    },

        };

        public Task<Word[]> GetWordsAsync(int number)
        {
            var rng = new Random();

            return Task.FromResult(Enumerable.Range(1, number)
                .Select(w=>Words[rng.Next(Words.Length)])
                .ToArray());
        }
    }
}
