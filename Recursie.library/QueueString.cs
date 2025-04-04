using System;

namespace Recursie.library
{
    public class QueueString
    {
        private string[] _data = new string[10];
        private int front = 0;
        private int back = 0;

        public bool IsEmpty => this.front == this.back;

        public bool IsFull => this.back == this._data.Length;
        public int Length => this.back - this.front;

        public QueueString(int initialSize = 10)
        {
            this._data = new string[initialSize];
        }

        public void Enqueue(string newValue)
        {
            if (IsFull)
            {
                if (this.Length < this._data.Length / 2)
                    ReorderArray();
                else
                    ResizeArray();
            }

            this._data[this.back] = newValue;
            this.back++;
        }

        public string Dequeue()
        {
            return this._data[this.front];
            this.front++;
        }


        private void ResizeArray()
        {
            string[] newDataArray = new string[this._data.Length * 2];

            for (var i = this.front; i < this.back; ++i)
            {
                newDataArray[i] = this._data[i];
            }

            this._data = newDataArray;
        }

        private void ReorderArray()
        {
            for (var i = this.front; i < this.back; ++i)
            {
                this._data[i - this.front] = this._data[i];
            }

            this.back = this.back - this.front;
            this.front = 0;
        }

    }
}
