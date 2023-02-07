using System;

namespace Core.Generation

{
    public static class NameGenerator
    {
        static Dictionary<int, string> openWith = new Dictionary<int, string>();

        // generation algos

        public static List<String> WordAlgo1(int wordListAmount, int wordsPerName, int syllableLength, Dictionary<int, string> syllableList)
        {
            // create the word list
            var wordList = new List<String>();

            // loop thru up to word list amount
            for (int i = 0; i < wordListAmount; i++)
            {
                string finalWord = "";

                for (int j = 0; j < wordsPerName; j++)
                {
                    string syllable = "";

                    Random rng = new Random();

                    for (int k = 0; k < syllableLength; k++)
                    {
                        syllable += syllableList[rng.Next(0, 25)];
                    }
                    finalWord += syllable + " ";


                }
                wordList.Add(finalWord);
            }

            return wordList;
        }

        public static List<String> WordAlgo2(int wordListAmount, int wordsPerName, int syllableCount, int syllableLength, Dictionary<int, string> syllableList)
        {
            // create the word list
            var wordList = new List<String>();

            // loop thru up to word list amount
            for (int i = 0; i < wordListAmount; i++)
            {
                string finalName = "";

                for (int j = 0; j < wordsPerName; j++)
                {
                    string word = "";

                    for (int k = 0; k < syllableCount; k++)
                    {
                        string syllable = "";

                        Random rng = new Random();

                        for (int l = 0; l < syllableLength; l++)
                        {
                            syllable += syllableList[rng.Next(0, 99)];
                        }

                        word += syllable;

                        //if (k != syllableCount - 1)
                        //{
                        //    word += "-";
                        //}
                        //else
                        //{

                        //}
                        
                    }

                    finalName += word + " ";


                }
                wordList.Add(finalName);
            }

            return wordList;
        }

        public static List<String> WordAlgo3(int wordListAmount, int wordsPerName, int syllableCountMax, int syllableLengthMax, Dictionary<int, string> syllableList)
        {
            // create the word list
            var wordList = new List<String>();

            // loop thru up to word list amount
            for (int i = 0; i < wordListAmount; i++)
            {
                string finalName = "";

                for (int j = 0; j < wordsPerName; j++)
                {
                    string word = "";

                    Random rng = new Random();

                    int syllableCountRand = rng.Next(1, syllableCountMax);

                    for (int k = 0; k < syllableCountRand; k++)
                    {
                        string syllable = "";

                        int syllableLengthRand = rng.Next(2, syllableLengthMax);

                        for (int l = 0; l < syllableLengthRand; l++)
                        {
                            syllable += syllableList[rng.Next(0, 99)];
                        }

                        word += syllable;

                        // syllable grouping by way of dash
                        // enable for debug
                        //if (k != syllableCountRand - 1)
                        //{
                        //    word += "-";
                        //}
                        //else
                        //{

                        //}

                    }

                    finalName += word + " ";


                }
                wordList.Add(finalName);
            }

            return wordList;
        }

        public static List<String> WordAlgo4(int wordListAmount, int wordsPerName, int syllableCountMax, int syllableLengthMax, Dictionary<int, string> consonantList, Dictionary<int, string> vowelList)
        {
            // create the word list
            var wordList = new List<String>();

            // loop thru up to word list amount
            for (int i = 0; i < wordListAmount; i++)
            {
                string finalName = "";

                for (int j = 0; j < wordsPerName; j++)
                {
                    string word = "";

                    Random rng = new Random();

                    int syllableCountRand = rng.Next(1, syllableCountMax);

                    for (int k = 0; k < syllableCountRand; k++)
                    {
                        string syllable = "";

                        int syllableLengthRand = rng.Next(2, syllableLengthMax);

                        for (int l = 0; l < syllableLengthRand; l++)
                        {
                            if (l == 0)
                            {
                                syllable += consonantList[rng.Next(0, consonantList.Count)];
                            }
                            else if (l % 2 == 1)
                            {
                                syllable += vowelList[rng.Next(0, vowelList.Count)];
                            }
                            else
                            {
                                syllable += consonantList[rng.Next(0, consonantList.Count)];
                            }
                        }

                        word += syllable;

                        // syllable grouping by way of dash
                        // enable for debug

                        //if (k != syllableCountRand - 1)
                        //{
                        //    word += "-";
                        //}
                        //else
                        //{

                        //}

                    }

                    finalName += word + " ";


                }
                wordList.Add(finalName);
            }

            return wordList;
        }

        // helper methods

        public static Dictionary<int, string> BuildLetterList()
        {
            Dictionary<int, string> letterList = new Dictionary<int, string>();

            letterList.Add(0, "a");
            letterList.Add(1, "b");
            letterList.Add(2, "c");
            letterList.Add(3, "d");
            letterList.Add(4, "e");
            letterList.Add(5, "f");
            letterList.Add(6, "g");
            letterList.Add(7, "h");
            letterList.Add(8, "i");
            letterList.Add(9, "j");
            letterList.Add(10, "k");
            letterList.Add(11, "l");
            letterList.Add(12, "m");
            letterList.Add(13, "n");
            letterList.Add(14, "o");
            letterList.Add(15, "p");
            letterList.Add(16, "q");
            letterList.Add(17, "r");
            letterList.Add(18, "s");
            letterList.Add(19, "t");
            letterList.Add(20, "u");
            letterList.Add(21, "v");
            letterList.Add(22, "w");
            letterList.Add(23, "x");
            letterList.Add(24, "y");
            letterList.Add(25, "z");

            return letterList;
        }

        public static Dictionary<int, string> BuildLetterList2()
        {
            Dictionary<int, string> letterList = new Dictionary<int, string>();

            letterList.Add(0, "a");
            letterList.Add(1, "a");
            letterList.Add(2, "a");
            letterList.Add(3, "a");
            letterList.Add(4, "a");
            letterList.Add(5, "a");
            letterList.Add(6, "a");
            letterList.Add(7, "a");
            letterList.Add(8, "b");
            letterList.Add(9, "c");
            letterList.Add(10, "c");
            letterList.Add(11, "c");
            letterList.Add(12, "d");
            letterList.Add(13, "d");
            letterList.Add(14, "d");
            letterList.Add(15, "d");
            letterList.Add(16, "e");
            letterList.Add(17, "e");
            letterList.Add(18, "e");
            letterList.Add(19, "e");
            letterList.Add(20, "e");
            letterList.Add(21, "e");
            letterList.Add(22, "e");
            letterList.Add(23, "e");
            letterList.Add(24, "e");
            letterList.Add(25, "e");
            letterList.Add(26, "e");
            letterList.Add(27, "e");
            letterList.Add(28, "f");
            letterList.Add(29, "f");
            letterList.Add(30, "g");
            letterList.Add(31, "g");
            letterList.Add(32, "h");
            letterList.Add(33, "h");
            letterList.Add(34, "h");
            letterList.Add(35, "h");
            letterList.Add(36, "h");
            letterList.Add(37, "h");
            letterList.Add(38, "i");
            letterList.Add(39, "i");
            letterList.Add(40, "i");
            letterList.Add(41, "i");
            letterList.Add(42, "i");
            letterList.Add(43, "i");
            letterList.Add(44, "i");
            letterList.Add(45, "j");
            letterList.Add(46, "k");
            letterList.Add(47, "l");
            letterList.Add(48, "l");
            letterList.Add(49, "l");
            letterList.Add(50, "l");
            letterList.Add(51, "m");
            letterList.Add(52, "m");
            letterList.Add(53, "m");
            letterList.Add(54, "n");
            letterList.Add(55, "n");
            letterList.Add(56, "n");
            letterList.Add(57, "n");
            letterList.Add(58, "n");
            letterList.Add(59, "n");
            letterList.Add(60, "n");
            letterList.Add(61, "o");
            letterList.Add(62, "o");
            letterList.Add(63, "o");
            letterList.Add(64, "o");
            letterList.Add(65, "o");
            letterList.Add(66, "o");
            letterList.Add(67, "o");
            letterList.Add(68, "o");
            letterList.Add(69, "p");
            letterList.Add(70, "p");
            letterList.Add(71, "q");
            letterList.Add(72, "r");
            letterList.Add(73, "r");
            letterList.Add(74, "r");
            letterList.Add(75, "r");
            letterList.Add(76, "r");
            letterList.Add(77, "s");
            letterList.Add(78, "s");
            letterList.Add(79, "s");
            letterList.Add(80, "s");
            letterList.Add(81, "s");
            letterList.Add(82, "s");
            letterList.Add(83, "t");
            letterList.Add(84, "t");
            letterList.Add(85, "t");
            letterList.Add(86, "t");
            letterList.Add(87, "t");
            letterList.Add(88, "t");
            letterList.Add(89, "t");
            letterList.Add(90, "u");
            letterList.Add(91, "u");
            letterList.Add(92, "u");
            letterList.Add(93, "v");
            letterList.Add(94, "w");
            letterList.Add(95, "w");
            letterList.Add(96, "x");
            letterList.Add(97, "y");
            letterList.Add(98, "y");
            letterList.Add(99, "z");

            Random rng = new Random();

            for (int i = 0; i < 1; i++)
            {
                letterList.OrderBy(x => rng.Next(0, 99)).ToList();
            }

            return letterList;
        }

        public static Dictionary<int, string> BuildConsonantsList()
        {
            // instantiate a dict
            Dictionary<int, string> consonantList = new Dictionary<int, string>();

            // 21 - everything else
            // build the list
            consonantList.Add(0, "b");
            consonantList.Add(1, "c");
            consonantList.Add(2, "d");
            consonantList.Add(3, "f");
            consonantList.Add(4, "g");
            consonantList.Add(5, "h");
            consonantList.Add(6, "j");
            consonantList.Add(7, "k");
            consonantList.Add(8, "l");
            consonantList.Add(9, "m");
            consonantList.Add(10, "n");
            consonantList.Add(11, "p");
            consonantList.Add(12, "q");
            consonantList.Add(13, "r");
            consonantList.Add(14, "s");
            consonantList.Add(15, "t");
            consonantList.Add(16, "v");
            consonantList.Add(17, "w");
            consonantList.Add(18, "x");
            consonantList.Add(19, "y");
            consonantList.Add(20, "z");

            return consonantList;
        }

        public static Dictionary<int, string> BuildVowelsList()
        {
            // instantiat the dict
            Dictionary<int, string> vowelList = new Dictionary<int, string>();

            // 5 - a e i o u
            // build the list
            vowelList.Add(0, "a");
            vowelList.Add(1, "e");
            vowelList.Add(2, "i");
            vowelList.Add(3, "o");
            vowelList.Add(4, "u");

            return vowelList;
        }


    }
}

