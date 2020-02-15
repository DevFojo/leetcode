namespace CodeSignal
{
    public class ListNode<T>
    {
        public T value { get; set; }
        public ListNode<T> next { get; set; }

        public static ListNode<T> FromArray(params T[] array)
        {
            ListNode<T> root = null;
            for (var i = array.Length - 1; i >= 0; i--)
            {
                root = new ListNode<T>
                {
                    next = root,
                    value = array[i]
                };
            }

            return root;
        }

        public override string ToString()
        {
            return $"{value}:{next}";
        }
    }
}