namespace Base64Utilities
{
    public static class StringUtility
    {
        /// <summary>
        /// Searches Base64 string for characters which are not valid Base64 characters. Returns an array of invalid characters. 
        /// </summary>
        /// <param name="inputString">Base64 encoded string.</param>
        /// <returns>Array of characters.</returns>
        public static char[] FindInvalidBase64Characters(string inputString)
        {
            var allowedCharacters = new List<char>
            {
                'A',
                'B',
                'C',
                'D',
                'E',
                'F',
                'G',
                'H',
                'I',
                'J',
                'K',
                'L',
                'M',
                'N',
                'O',
                'P',
                'Q',
                'R',
                'S',
                'T',
                'U',
                'V',
                'W',
                'X',
                'Y',
                'Z',
                'a',
                'b',
                'c',
                'd',
                'e',
                'f',
                'g',
                'h',
                'i',
                'j',
                'k',
                'l',
                'm',
                'n',
                'o',
                'p',
                'q',
                'r',
                's',
                't',
                'u',
                'v',
                'w',
                'x',
                'y',
                'z',
                '0',
                '1',
                '2',
                '3',
                '4',
                '5',
                '6',
                '7',
                '8',
                '9',
                '+',
                '/'
            };

            var inputCharacters = inputString.ToCharArray();

            var invalidCharacters = new List<char>();

            foreach (var inputCharacter in inputCharacters)
            {
                if (!allowedCharacters.Contains(inputCharacter))
                {
                    invalidCharacters.Add(inputCharacter);
                }
            }

            return invalidCharacters.ToArray();
        }
    }
}