using System;

namespace Open_Lab_05._02
{
    public class StringTools
    {
        public string NoYelling(string sentence)
        {
            for(int i = 0; i < sentence.Length; i++)
            {

                if (sentence[sentence.Length - 1] == sentence[sentence.Length - 2] && sentence[sentence.Length - 1] == '.')
                {
                    return sentence;

                }
                else if (sentence[sentence.Length - 1] != sentence[sentence.Length - 2])
                {
                    return sentence;

                }
                else
                {
                    while (sentence[sentence.Length - 1] == sentence[sentence.Length - 2])
                    {
                        sentence = sentence.Substring(0, sentence.Length - 1);
                    }
                }
            
            }
            return sentence;
        }
    }
}
