﻿namespace MyListImplementation
{
    public class Stack
    {
        //private Box _head;
        private Box _tail;
        private Box _current;
        private int _count;

        public Stack()
        {
           // _head = null;
            _tail = null;
            _count = 0;
        }

        public int Count
        {
            get
            {
                return _count;
            }
        }

        public object Current
        {
            get
            {
                return _current.Value;
            }
        }

        public bool MoveNext()
        {
            if (_current == null)
            {
                return false;
            }

            _current = _current.Next;

            return _current != null;
        }

        public void Push(object value)
        {
            Box box = new Box(value);

            if (/*_head == null && */_tail == null)
            {
                //_head = box;
                _current = box;
                _tail = box;
            }
            else
            {
                Box tempBox = _tail;
                _tail = box;
                _tail.Next = tempBox;
            }

            _count++;
        }

        public object Pull()
        {
            // Удалять голову, если хвост указывает на голову (голова == хвост).
            if (_tail == null)
                return 0;

            object value = _tail.Value;
            _tail = _tail.Next;
            _count--;

            return value;
        }
    }
}
