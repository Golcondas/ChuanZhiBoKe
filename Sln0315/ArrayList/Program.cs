using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.ArrayList list1 = new System.Collections.ArrayList();
            //list1.Add("1");
            //list1.Add(1);
            //list1.Add("宝山");
            //Console.WriteLine(list1.Count);
            //for (int i=0;i<list1.Count;i++)
            //{
            //    Console.WriteLine(list1[i]);
            //}
            //foreach (object a in list1)
            //{
            //    Console.WriteLine(a);
            //}
            int[] num = new int[] {3,8,9,33,32};
            //list1.AddRange(num);
            //foreach (object a in list1)
            //{
            //    Console.WriteLine(a);
            //}
            //int[] a = new int[] {};
            //int[] b = new int[] {};
            
            for (int i=0;i<num.Length;i++)
            {
                if(num[i]%2!=0)
                {
                    list1.Add(num[i]);
                }
            }
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 0)
                {
                    list1.Add(num[i]);
                }
            }
            //list1.AddRange(a);
            //list1.AddRange(b);
            list1.Remove(8);
            list1.RemoveAt(1);
            //list1.Clear();
            
            Console.Write(list1.Contains(8));
            foreach (object c in list1)
            {
                Console.Write(c+"  ");
            }
            Console.ReadKey();
        }
    }
}
