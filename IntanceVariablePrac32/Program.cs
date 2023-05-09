﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntanceVariablePrac32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //자바 스타일
            product product1 = new product();
            product1.name = "감자";
            product1.price = 2000;

            // C# 스타일 
            product product2 = new product() { name = "고구마", price = 2100 };
            product product3 = new product() { name = "옥수수" };
            product product4 = new product() { price = 999999 };
            product product5 = new product() { price = 7777, name = "비트" };

            // 클래스 변수 출력
            Console.WriteLine(product.origin);

            Console.WriteLine(product1.name + " / " + product1.price);
            Console.WriteLine(product1);

            List<Student> list = new List<Student>();
            list.Add(new Student() { name = "곽경희", grade = 3 });
            list.Add(new Student() { name = "권하은", grade = 2 });
            list.Add(new Student() { name = "김선혜", grade = 1 });

            List<Student> list2 = new List<Student>() {
                new Student(){ name = "곽경희", grade=3 },
                new Student(){ name = "권하은", grade=2 },
                new Student(){ name = "김선혜", grade=1 },
            };

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
