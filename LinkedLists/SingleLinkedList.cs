namespace DataStructuresAndAlgorithms
{
    public class SingleLinkedList
    {
        public Node Head { get; set; }


        public void AddToLast(int value)
        {
            //create a new node with the value passed in
            var node = new Node(value);
            // if there is no head, set the head to the new node
            if (Head == null)
            {
                Head = node;
                return;
            }
            // otherwise, start at the head and traverse the list
            var current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            // when you get to the end of the list, set the next property of the last node to the new node
            current.Next = node;
        }
        public void AddToFirst(Node node)
        {
            // if there is no head, set the head to the new node
            if (Head == null)
            {
                Head = node;
                return;
            }
            // otherwise, set the next property of the new node to the current head
            node.Next = Head;
            // set the head to the new node
            Head = node;
        }
        public void AddToLast(Node node)
        {
            //if there is no head, set the head to the new node
            if (Head == null)
            {
                Head = node;
                return;
            }
            //otherwise start at the head and traverse the list
            var current = Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = node;
        
        }

        public void AddToIndex(Node node, int position)
        {
            //if there is no head, set the head to the new node
            if (Head == null)
            {
                Head = node;
                return;
            }
            //otherwise start at the head and traverse the list till you reach the index
            var current = Head;
            var index = 0;
            while (index != position)
            {
                current = current.Next;
                index++;
            }
            Node currentNode = current;
            current = node;
            current.Next = currentNode;           
        }
        public void RemoveFirst()
        {
            if (Head == null)
            {
                return;
            }
            var current = Head;
            Head = current.Next;            
        }
        public void removeLast()
        {
            if (Head == null)
            {
                return;
            }
            var current = Head;
            while (current.Next.Next != null)
            {
                current = current.Next;
            }
            current.Next = null;
        }

    }
}