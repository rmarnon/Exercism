namespace LinkedList
{
    class TNodo<T>
    {
        public T Value { get; set; }
        public TNodo<T> Previous { get; set; }
        public TNodo<T> Next { get; set; }
    }
}
