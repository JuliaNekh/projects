using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_4
{
    class MyList
    {
        public MyNode head;             // голова списка
        public int count;               // число элементов
        public MyList()                 // Конструктор
        {
            head = null;
            count = 0;
        }

        public void Add(string inf)    // добавление нового элемента
        {
            if (count == 0)
            {
                head = new MyNode(inf, null);

            }
            else
            {
                MyNode p = GetNode(count - 1);
                MyNode tmp = new MyNode(inf, null);
                p.next = tmp;
            }
            count++;
        }

        public MyList ChangeList(MyList list1)
        {
            MyNode p = head;
            int i = 0;
            while (p.next != null)
            {
                if (p.inf == p.next.inf)
                {
                    Delete(i + 1);
                    i--;
                    list1.Printer();
                    Console.WriteLine();
                }
                else
                    p = p.next;
                i++;
            }
            return list1;
        }

        public void Printer()          // Вывод списка
        {
            MyNode p = head;
            while (p != null)
            {
                Console.Write("{0} ", p.inf);
                p = p.next;
            }
        }

        public MyNode GetNode(int index)
        {
            MyNode p = head;
            if (index == 0)
                return head;
            else
            {
                for (int i = 0; i < index; i++)
                    p = p.next;
            }
            return p;
        }

        public void Delete(int index) // Удалить по индексу
        {
            MyNode p;
            if (index == count)
            {
                p = GetNode(index - 1);
                p.next = null;
            }
            else
            {
                if (index != 0)
                {
                    p = GetNode(index - 1);
                    p.next = p.next.next;
                }
                else
                    head = head.next;
            }
            count--;
        }
    }

    class MyNode
    {
        public string inf;
        public MyNode next;
        public MyNode(string inf, MyNode next)
        // конструктор
        {
            this.inf = inf;
            this.next = next;
        }

    }
}
