﻿using System.Runtime.InteropServices;
using System.Xml.Schema;

namespace 猜数字
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool youXiXunHuan = true;
            string panDuanYouXi;
            int jieGuo;
            bool xunhuan = true;
            int chance;
            Console.WriteLine("猜数字");
            Thread.Sleep(250);
            Console.WriteLine("版本v4.00");
            Thread.Sleep(250);
            Console.Write("请输入你的用户名：");
            string userName = Console.ReadLine();
            while (youXiXunHuan)
            {
                xunhuan = true;
                Random random = new Random();
                int miDi = random.Next(0, 101); //生成一个在0~100之间的一个随机数。
                if (userName == "lym" || userName == "李一鸣" || userName == "mzykl" || userName == "木子一口鸟")
                {
                    Console.WriteLine($"飞舞！{userName}");
                    Thread.Sleep(250);
                    Console.WriteLine("这是一个猜数字的游戏，你的同类会随机的从0~100（包括100）中随机的抽取一个数字");
                    Thread.Sleep(250);
                    Console.WriteLine($"你个废物要做的就是猜对它！！！");
                    Console.Write("你可以自由选择有多少次机会！输入：");
                }
                else
                {
                    Console.WriteLine($"你好！{userName}");
                    Console.WriteLine("这是一个猜数字的游戏，电脑会随机的从0~100（包括100）中随机的抽取一个数字");
                    Thread.Sleep(250);
                    Console.WriteLine($"你要做的就是猜对它！！！");
                    Console.Write("你可以自由选择有多少次机会！请输入：");
                }
                string strChance = Console.ReadLine();
                chance = int.Parse(strChance);
                //Console.WriteLine(miDi); //测试代码，一会注释掉
                while (xunhuan)
                {
                    Console.WriteLine($"你现在有{chance}次机会");
                    Console.Write("请输入一个你猜的数字：");
                    string wanJiaShuRu = Console.ReadLine();
                    int intwanJiaShuRu = int.Parse(wanJiaShuRu);
                    int a;
                    a = panduan(intwanJiaShuRu, miDi);
                    if (chance > 1)
                    {
                        if (a == 1)
                        {
                            Console.WriteLine("你猜的太大了！");
                            chance = chance - 1;
                        }
                        else if (a == 2)
                        {
                            Console.WriteLine("你猜的太小了！");
                            chance = chance - 1;
                        }
                        else if (a == 0)
                        {
                            int win = 0;
                            Console.WriteLine("你赢了！！！！");
                            Thread.Sleep(500);
                            Console.WriteLine("游戏结束！");
                            Console.WriteLine("如果想退出游戏，请按n键，否则任意按一个键。");
                            panDuanYouXi = Console.ReadLine().ToLower();
                            if (panDuanYouXi == "n")
                            {
                                youXiXunHuan = false;
                            }
                            //xunhuan = false;
                        }
                    }
                    else if(chance == 1)
                    {
                        if (a == 0)
                        {
                            Console.WriteLine("你赢了！！！！");
                            Thread.Sleep(500);
                            Console.WriteLine("游戏结束！");
                            Console.WriteLine("如果想退出游戏，请按n键，否则任意按一个键。");
                            panDuanYouXi = Console.ReadLine().ToLower();
                            if (panDuanYouXi == "n")
                            {
                                youXiXunHuan = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("机会用完了！你输了！！！！！！");
                            Console.WriteLine($"答案是{miDi}");
                            Console.WriteLine("游戏结束！");
                            Console.WriteLine("如果想退出游戏，请按n键，否则任意按一个键。");
                            panDuanYouXi = Console.ReadLine().ToLower();
                            if (panDuanYouXi == "n")
                            {
                                youXiXunHuan = false;
                            }
                            xunhuan = false;
                        }
                    }
                }
            }
            
        }

        private static int panduan(int intwanJiaShuRu, int suiJi)
        {
            // 0代表猜对，1代表猜太大，2代表猜太小
            int fanHui;
            if (intwanJiaShuRu < suiJi)
            {
                fanHui = 2;
            }
            else if (intwanJiaShuRu > suiJi)
            {
                fanHui = 1;
            }
            else
            {
                fanHui = 0;
            }
            return fanHui;
        }
    }
}