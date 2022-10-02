using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CostList {
        public string name;
        public int costNum;
        public CostList(string name,int costNum) {
            this.name = name;
            this.costNum = costNum;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            string func;
            string money;
            List<CostList> list = new List<CostList>();
            int choice = 0;
            int costSum = 0;
            int total = 0;
            do
            {
                Console.WriteLine("(1)輸入收入 (2)輸入支出 (3)新增項目 (4)刪除項目 (5)計算比例 (6)查詢支出 (7)剩餘金額 (8)退出程式");
                Console.Write("輸入數字選擇功能: ");
                func = Console.ReadLine();
                try
                {
                    choice = int.Parse(func);
                }
                catch
                {
                    continue;
                }
                switch (choice)
                {
                    case 1:
                        {
                            Console.Write("輸入金額: ");
                            money = Console.ReadLine();
                            try
                            {
                                int iMoney = int.Parse(money);
                                if (iMoney < 0)
                                {
                                    Console.WriteLine("收入不可為負數");
                                }
                                else total += iMoney;
                            }
                            catch
                            {
                                Console.WriteLine("請輸入數字");
                            }
                            break;
                        }
                    case 2:
                        {
                            int idx = 0;
                            int iMoney = 0;
                            
                            if (list.Count == 0)
                            {
                                Console.WriteLine("請新增支出項目");
                                break;
                            }
                            for (int i = 0; i < list.Count; i++)
                            {
                                Console.Write("({0}){1} ", i + 1, list[i].name);
                            }
                            Console.WriteLine();
                            Console.Write("輸入數字選擇支出項目: ");
                            func = Console.ReadLine();
                            try
                            {
                                idx = int.Parse(func) - 1;
                                if (idx < 0 || idx >= list.Count)
                                {
                                    Console.WriteLine("此數字不在範圍中");
                                    break;
                                }
                            }
                            catch
                            {
                                Console.WriteLine("請輸入數字");
                                break;
                            }
                            Console.Write("輸入支出金額: ");
                            money = Console.ReadLine();
                            try
                            {
                                iMoney = int.Parse(money);
                                if (iMoney > total)
                                {
                                    Console.WriteLine("存款不足");
                                    break;
                                }
                                list[idx].costNum += iMoney;
                                costSum += iMoney;
                                total -= iMoney;
                            }
                            catch
                            {
                                Console.WriteLine("請輸入數字");
                                break;
                            }
                            break;
                        }
                    case 3:
                        {
                            if (list.Count == 5)
                            {
                                Console.WriteLine("已無法再新增支出項目");
                                break;
                            }
                            Console.Write("輸入項目名稱: ");
                            string name = Console.ReadLine();
                            bool find = false;
                            for (int i = 0; i < list.Count; i++)
                            {
                                if (list[i].name.Equals(name))
                                {
                                    find = true;
                                    Console.WriteLine("支出項目已存在");
                                    break;
                                }
                            }
                            if (find)break;
                            list.Add(new CostList(name, 0));
                            break;
                        }
                    case 4:
                        {
                            if (list.Count == 0)
                            {
                                Console.WriteLine("已無法再刪除支出項目");
                                break;
                            }
                            Console.Write("輸入項目名稱: ");
                            bool find = false;
                            string delName = Console.ReadLine();
                            for (int i = 0; i < list.Count; i++)
                            {
                                if (list[i].name.Equals(delName))
                                {
                                    find = true;
                                    total += list[i].costNum;
                                    costSum -= list[i].costNum;
                                    list.RemoveAt(i);
                                }
                            }
                            if (!find) Console.WriteLine("此項目不存在");
                            break;
                        }
                    case 5:
                        {
                            if (costSum == 0)
                            {
                                for (int i = 0; i < list.Count; i++)
                                {
                                    Console.WriteLine("({0}){1}: 0% ",i+1,list[i].name);
                                }
                            }
                            else
                            {
                                for (int i = 0; i < list.Count; i++)
                                {
                                    Console.WriteLine("({0}){1}: {2}% ",i+1,list[i].name, ((Double)list[i].costNum / (Double)costSum) * 100);
                                }
                            }
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("目前總支出: {0}", costSum);
                            Console.Write("輸入要查詢的項目: ");
                            bool find = false;
                            string name = Console.ReadLine();
                            for (int i = 0; i < list.Count; i++)
                            {
                                if (list[i].name.Equals(name))
                                {
                                    find = true;
                                    Console.WriteLine("{0}: {1}", list[i].name, list[i].costNum);
                                }
                            }
                            if (!find) Console.WriteLine("此項目不存在");
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("剩餘金額為: {0}", total);
                            break;
                        }
                    case 8:
                        break;
                }
                Console.WriteLine();
            } while (choice != 8);
        }
    }
}
