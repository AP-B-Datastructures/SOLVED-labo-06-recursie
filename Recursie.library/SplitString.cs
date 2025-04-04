using System;

namespace Recursie.library
{
    public class SplitString
    {
        public static QueueString ReverseTextToQueue(string text)
        {
            if (text == "")
                return new QueueString();

            var queue = ReverseTextToQueue(text.Substring(1));
            queue.Enqueue(text[0].ToString());

            return queue;
        }
    }
}
