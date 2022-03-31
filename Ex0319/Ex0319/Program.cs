using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex0319
{
    class Program
    {
        static void Main(string[] args)
        {
            //第1題
            autoMobile mobile = new autoMobile();
            mobile.speedUp();
            motorcycle motor = new motorcycle();
            motor.speedUp();
            //StrConv();          //第2-1題
            //CutSpace();         //第2-2題
            //PrintStr();         //第2-3題
            //MinusOpt();         //第3-1題
            //Sort();             //第3-3題
            //Intersection();     //第5-1題
            //Except();           //第5-2題
            //Union();            //第5-3題
        }

        //第1題
        //繼承與介面相同之處在於可繼承的制度，
        //不同之處在於繼承中的父類別與子類別符合了「是-什麼」關係，另外，
        //繼承可以繼承自一個類別，而介面則是可以有多個。
        interface IProduct
        {
            string model { get; set; }
            int cc { get; set; }
            int price { get; set; }
        }

        interface ISpeedUp
        {
            void speedUp();
        }

        class Car : IProduct
        {
            public string model { get; set; }
            public int cc { get; set; }
            public int price { get; set; }
        }

        class autoMobile : Car, ISpeedUp
        {
            public autoMobile()
            {
                model = "LexusT3001";
                cc = 2000;
                price = 5000000;
            }

            public void speedUp()
            {
                Console.WriteLine("我的速度是40km/hr");
                Console.ReadKey();
            }
        }

        class motorcycle : Car, ISpeedUp
        {
            public motorcycle()
            {
                model = "Many100-115";
                cc = 115;
                price = 30000;
            }

            public void speedUp()
            {
                Console.WriteLine("我的速度是10km/hr");
                Console.ReadKey();
            }
        }

        //第2-1題
        static void StrConv()
        {
            string oldString1 = "人易科技:上 機 測 驗";
            Console.WriteLine(Strings.StrConv(oldString1, VbStrConv.Wide, 0));
            Console.ReadKey();
        }

        //第2-2題
        static void CutSpace()
        {
            string str = "人易科技:上 機 測 驗 - 演算法";
            int yenIndex = str.IndexOf("驗");
            int length = str.Length;
            string endStr = str.Substring(yenIndex + 1, length - 1 - yenIndex);
            string frontStr = str.Substring(0, yenIndex + 1);
            string newStr = frontStr.Replace(" ", "") + endStr;
            Console.WriteLine(newStr);
            Console.ReadKey();
        }

        //第2-3題
        static void PrintStr()
        {
            string str = "人易科技:上 機 測 驗 - 演算法";
            int index = str.IndexOf("-");
            Console.WriteLine(str.Substring(0, index));
            Console.ReadKey();
        }

        //第3-1題
        static void MinusOpt()
        {
            int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int evenSum = 0;
            int oddSum = 0;
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenSum += arr[i];
                }
                else
                {
                    oddSum += arr[i];
                }
            }
            result = oddSum - evenSum;
            Console.WriteLine($"奇數總和:{oddSum.ToString()}, 偶數總和:{evenSum.ToString()}, 相減結果:{result}");
            Console.ReadKey();
        }

        //第3-2題
        static void SepArr()
        {
            int[] arr = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] evenArr = new int[5]; //偶數陣列
            int e = 0;
            int[] oddArr = new int[5];  //奇數陣列
            int o = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenArr[e] = arr[i];
                    e++;
                }
                else
                {
                    oddArr[o] = arr[i];
                    o++;
                }
            }
        }

        //第4題 正序
        static void Sort()
        {
            int[] nums = { 77, 5, 5, 22, 13, 55, 97, 4, 796, 1, 0, 9 };
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 0; j < nums.Length - 1 - i; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }

            Console.ReadKey();
        }

        //第5-1題 交集
        static void Intersection()
        {
            int[] arrA = { 77, 5, 5, 22, 13, 55, 97, 4, 796, 1, 0, 9 };
            int[] arrB = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> interList = new List<int>();
            int k = 0;

            for (int i = 0; i < arrA.Length; i++)
            {
                for (int j = 0; j < arrB.Length; j++)
                {
                    if (arrA[i] == arrB[j])
                    {
                        interList.Add(arrA[i]);
                    };
                };
            };

            int[] arrC = interList.ToArray();
        }

        //第5-2題 差集
        static void Except()
        {
            int[] arrA = { 77, 5, 5, 22, 13, 55, 97, 4, 796, 1, 0, 9 };
            int[] arrB = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int[] arrD = arrA.Except(arrB).ToArray();
            List<int> exList = new List<int>();
            for (int i = 0; i < arrA.Length; i++)
            {
                int repeat = 0;
                for (int j = 0; j < arrB.Length; j++)
                {
                    if (arrA[i] == arrB[j])
                    {
                        repeat = 1;
                    }
                }
                if (repeat == 0)
                {
                    exList.Add(arrA[i]);
                }
            }
            int[] arrD = exList.ToArray();
        }

        //第5-3題 聯集
        static void Union()
        {
            int[] arrA = { 77, 5, 5, 22, 13, 55, 97, 4, 796, 1, 0, 9 };
            int[] arrB = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> unionList = new List<int>();

            int k = 0;
            //先將陣列A的元素全裝進陣列arr
            for (int i = 0; i < arrA.Length; i++)
            {
                unionList.Add(arrA[i]);
            };

            for (int i = 0; i < arrB.Length; i++)
            {
                int repeat = 0;
                for (int j = 0; j < arrA.Length; j++)
                {
                    if (arrB[i] == arrA[j])
                    {
                        repeat = 1;
                    }
                }
                //陣列B的元素與陣列A不重複
                if (repeat == 0)
                {
                    unionList.Add(arrB[i]);
                }
            };
            int[] arrE = unionList.ToArray();
        }
    }
}
