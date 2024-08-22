using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcadAdvisor.System.Collections
{
    public class Computation
    {
        public void MinMax(int[] array, out int min, out int max, out int minIndex, out int maxIndex)
        {
            if (array.GetLength(0) == 0)
            {
                throw new Exception("No student queued for concerns.");
            }

            min = array[0];
            max = array[0];
            minIndex = 0;
            maxIndex = 0;

            for (int i = 1; i < array.GetLength(0); i+=1)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    minIndex = i;
                }
                if (array[i] > max)
                {
                    max = array[i];
                    maxIndex = i;
                }
            }
        }
    }

    public class Search
    {
        public static bool LinearSearch(string studentID, CircularQueue<StudentTicket> queue, out StudentTicket foundTicket)
        {
            var items = queue.GetItems();
            for (int i = 0; i < items.GetLength(0); i++)
            {
                if (items[i].StudentID == studentID)
                {
                    foundTicket = items[i];
                    return true;
                }
            }
            foundTicket = null;
            return false;
        }
    }

    public static class Sort
    {
        public static void BubbleSort(List<StudentTicket> list)
        {
            int n = 0;
            foreach (var item in list)
            {
                n+=1;
            }

            for (int i = 0; i < n - 1; i+=1)
            {
                for (int j = 0; j < (n - i) - 1; j+=1)
                {
                    if (list[j].DaysLeft > list[j + 1].DaysLeft)
                    {
                        var temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
        }
    }

    public class CircularQueue<T>
    {
        private T[] array;
        private int count, front, rear;

        public CircularQueue(int size)
        {
            array = new T[size];
            count = 0; front = 0; rear = -1;
        }

        public int Count
        {
            get { return count; }
        }

        public void Enqueue(T item)
        {
            if (count < array.GetLength(0))
            {
                rear = (rear + 1) % array.GetLength(0);
                array[rear] = item;
                count += 1;
            }
            else
            {
                throw new Exception("Queue is Full.");
            }
        }

        public T Dequeue()
        {
            if (count > 0)
            {
                T item = array[front];
                front = (front + 1) % array.GetLength(0);
                count -= 1;
                return item;
            }
            else
            {
                throw new Exception("Queue is Empty.");
            }
        }

        public T Peek(int index)
        {
            if (index >= 0 && index < count)
            {
                return array[(front + index) % array.GetLength(0)];
            }
            else
            {
                throw new Exception("Item is out of queue range.");
            }
        }

        public T[] GetItems()
        {
            T[] items = new T[count];
            for (int i = 0; i < count; i += 1)
            {
                items[i] = array[(front + i) % array.GetLength(0)];
            }
            return items;
        }

        public static void SortQueue(CircularQueue<StudentTicket> queue)
        {
            var list = new List<StudentTicket>(queue.GetItems());
            Sort.BubbleSort(list);
            queue.Clear();
            foreach (var ticket in list)
            {
                queue.Enqueue(ticket);
            }
        }

        public static int CountQueueElements(CircularQueue<StudentTicket> queue)
        {
            int count = 0;
            var tempQueue = new CircularQueue<StudentTicket>(queue.GetItems().GetLength(0));

            while (true)
            {
                try
                {
                    var item = queue.Dequeue();
                    tempQueue.Enqueue(item);
                    count+=1;
                }
                catch (Exception)
                {
                    break;
                }
            }

            while (true)
            {
                try
                {
                    var item = tempQueue.Dequeue();
                    queue.Enqueue(item);
                }
                catch (Exception)
                {
                    break;
                }
            }

            return count;
        }

        public void Clear()
        {
            count = 0;
            front = 0;
            rear = -1;
        }
    }

    internal class StudentTicketList
    {
        private StudentTicket[] array;
        private int index;

        public StudentTicketList()
        {
            array = new StudentTicket[5];
            index = -1;
        }

        public StudentTicketList(int size)
        {
            array = new StudentTicket[size];
            index = -1;
        }

        public void Add(StudentTicket item)
        {
            index += 1;
            if (index < array.GetLength(0))
            {
                array[index] = item;
            }
            else if (!(index < array.GetLength(0)))
            {
                index -= 1;
                IncreaseSize();
                Add(item);
            }
        }

        public void Insert(int index, StudentTicket item)
        {
            if (index > -1 && index <= this.index)
            {
                if (this.index > array.GetLength(0))
                {
                    IncreaseSize();
                }
                for (int i = this.index; i >= index; i -= 1)
                {
                    array[i + 1] = array[i];
                }
                array[index] = item;
                this.index += 1;
            }
            else if (!(index > -1 && index <= this.index))
            {
                throw new Exception("Index is out of bounds.");
            }
        }
        private void IncreaseSize()
        {
            StudentTicket[] newArray = new StudentTicket[array.GetLength(0) * 2];
            for (int i = 0; i < array.GetLength(0); i+=1)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }

        public StudentTicket[] GetItems()
        {
            StudentTicket[] items = new StudentTicket[index + 1];
            for (int i = 0; i < items.GetLength(0); i+=1)
            {
                items[i] = array[i];
            }
            return items;
        }

        public void ConsolePrintItems()
        {
            for (int i = 0; i <= index; i+=1)
            {
                Console.WriteLine(array[i].ToString());
            }
        }

        public void RemoveAt(int index)
        {
            if (index >= 0 && index <= this.index)
            {
                for (int i = index; i < this.index; i += 1)
                {
                    array[i] = array[i + 1];
                }
                this.index-=1;
            }
            else if (!(index > -1 && index <= this.index))
            {
                throw new Exception("Index is out of bounds.");
            }
        }
    }
        public class StudentTicket
    {
        public string StudentName { get; set; }
        public string StudentID { get; set; }

        public string DegreeCode { get; set; }
        public string CourseCode { get; set; }
        public string ConcernType { get; set; }
        public int DaysLeft { get; set; }

        public bool RegistrarApprovalStatus { get; set; }

        public StudentTicket(string studentName, string studentID, string degreeCode, string courseCode, string concernType, int daysLeft, bool registrarApprovalStatus)
        {
            StudentName = studentName;
            StudentID = studentID;
            DegreeCode = degreeCode;
            CourseCode = courseCode;
            ConcernType = concernType;
            DaysLeft = daysLeft;
            RegistrarApprovalStatus = registrarApprovalStatus;
        }
    }
}
