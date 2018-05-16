using System.Collections.Generic;

namespace Jigs
{
    public static class IntegerTypeCombinations
    {
        private static readonly IReadOnlyList<IntegerTypes> _types = new List<IntegerTypes>
        {
            IntegerTypes.Byte,
            IntegerTypes.Short,
            IntegerTypes.Int,
            IntegerTypes.Long
        };

        public static IEnumerable<(IntegerTypes, IntegerTypes)> GetDoubles()
        {
            for (byte i = 0; i < 4; i++)
                for (byte j = 0; j < 4; j++)
                    yield return (_types[i], _types[j]);
        }

        public static IEnumerable<(IntegerTypes, IntegerTypes, IntegerTypes)> GetTriples()
        {
            for (byte i = 0; i < 4; i++)
                for (byte j = 0; j < 4; j++)
                    for (byte k = 0; k < 4; k++)
                        yield return (_types[i], _types[j], _types[k]);
        }

        public static IEnumerable<(IntegerTypes, IntegerTypes, IntegerTypes, IntegerTypes)> GetQuadruples()
        {
            for (byte i = 0; i < 4; i++)
                for (byte j = 0; j < 4; j++)
                    for (byte k = 0; k < 4; k++)
                        for (byte l = 0; l < 4; l++)
                            yield return (_types[i], _types[j], _types[k], _types[l]);
        }
    }
}
