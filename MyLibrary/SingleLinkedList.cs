using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    /// <summary>
    /// Клас односпрямованого списка
    /// </summary>
    public class SingleLinkedList : ILinkedList
    {
        private Node? head { get; set; }

        public SingleLinkedList()
        {
            head = null;
        }
        public void AddFirst(short value)
        {
            Node newNode = new Node(value);
            newNode.Next = head;
            head = newNode;
        }

        public SingleLinkedList GetListBy3()
        {
            SingleLinkedList newlist = new SingleLinkedList();
            Node? current = head;
            int index = 0;

            while (current != null)
            {
                if (current.Value % 3 == 0)
                {
                    newlist.AddFirst(current.Value);
                }
                current = current.Next;
                index++;
            }

            return newlist;
        }

        public int GetNumberBy3()
        {

            Node? current = head;
            int index = 0;

            while (current != null)
            {
                if (current.Value % 3 == 0)
                {
                    return index + 1;
                }
                current = current.Next;
                index++;
            }

            return -1;
        }

        public long ProductOfElementsLessThanAverage()
        {
            if (head == null)
            {
                return 0;
            }

            int sum = 0;
            int count = 0;
            Node? current = head;
            while (current != null)
            {
                sum += current.Value;
                count++;
                current = current.Next;
            }

            double average = (double)sum / count;

            long product = 1;
            bool found = false;
            current = head;
            while (current != null)
            {
                if (current.Value < average)
                {
                    product *= current.Value;
                    found = true;
                }
                current = current.Next;
            }

            return found ? product : 0;
        }

        public void RemoveElementsLessThanAverage()
        {
            if (head == null)
            {
                return;
            }

            int sum = 0;
            int count = 0;
            Node? current = head;
            while (current != null)
            {
                sum += current.Value;
                count++;
                current = current.Next;
            }

            double average = (double)sum / count;

            // Видалення елементів, менших за середнє значення
            Node? previous = null;
            current = head;
            while (current != null)
            {
                if (current.Value < average)
                {
                    // Видалення поточного елемента
                    if (previous == null)
                    {
                        head = current.Next;
                    }
                    else
                    {
                        previous.Next = current.Next;
                    }
                }
                else
                {
                    // Перейти до наступного елемента
                    previous = current;
                }
                current = current.Next;
            }
        }
    }
}
