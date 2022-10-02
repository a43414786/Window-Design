using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2_2
{
    class Program
    {
        public static void printTable(char[,] table)
        {
            string str = "";
            Console.WriteLine("  A B C D E F G H");
            for (int i = 0; i < 8; i++)
            {
                str += $"{i + 1} ";
                for (int j = 0; j < 8; j++)
                {
                    str += table[i, j] + " ";
                }
                if (i == 7) break;
                str += "\n";
            }
            Console.WriteLine(str);
        }
        static void Main(string[] args)
        {
            int counter = 0;
            string str;
            int row,col,top,bottom,lmost,rmost;
            char[,] table = new char[8, 8];
            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    table[i, j] = '-';
                }
            }
            
            
            while (true)
            {
                Console.Clear();
                printTable(table);
                if (counter == 64) {
                    int oSum = 0,xSum = 0;
                    for (int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            if(table[i,j] == 'O')
                            {
                                oSum++;
                            }
                        }
                        
                    }
                    xSum = 64 - oSum;
                    if (xSum > oSum)
                    {
                        Console.WriteLine("遊戲結束 玩家X獲勝!");
                    }
                    else
                    {
                        Console.WriteLine("遊戲結束 玩家O獲勝!");

                    }
                    Console.ReadLine();
                    break;
                }
                if (counter % 2 == 0)
                {
                    Console.WriteLine("輪到玩家O 請輸入要下的位置:");
                }
                else
                {
                    Console.WriteLine("輪到玩家X 請輸入要下的位置:");
                }
                try
                {
                    str = Console.ReadLine();
                    col = str[0] - 'A';
                    row = str[1] - '0' - 1;
                }
                catch
                {
                    continue;
                }
                if(table[row,col] != '-')
                {
                    Console.WriteLine("此位置已有棋子! 按任意鍵繼續遊戲");
                    Console.ReadLine();
                    continue;
                }
                top = bottom = row;
                lmost = rmost = col;
                if(counter %2 == 0)
                {
                    table[row, col] = 'O';
                    for(int i = col; i >= 0; i--)
                    {
                        if(table[row,i] == 'O')
                        {
                            lmost = i;
                        }
                    }
                    for (int i = col; i < 8; i++)
                    {
                        if (table[row, i] == 'O')
                        {
                            rmost = i;
                        }
                    }
                    for (int i = row; i >= 0; i--)
                    {
                        if (table[i, col] == 'O')
                        {
                            top = i;
                        }
                    }
                    for (int i = row; i < 8; i++)
                    {
                        if (table[i, col] == 'O')
                        {
                            bottom = i;
                        }
                    }
                    for (int i = lmost; i <= rmost; i++)
                    {
                        if (table[row, i] != '-')
                        {
                            table[row, i] = 'O';
                        }
                    }
                    for (int i = top; i <= bottom; i++)
                    {
                        if (table[i, col] != '-')
                        {
                            table[i, col] = 'O';
                        }
                    }
                }
                else
                {
                    table[row, col] = 'X';
                    for (int i = col; i >= 0; i--)
                    {
                        if (table[row, i] == 'X')
                        {
                            lmost = i;
                        }
                    }
                    for (int i = col; i < 8; i++)
                    {
                        if (table[row, i] == 'X')
                        {
                            rmost = i;
                        }
                    }
                    for (int i = row; i >= 0; i--)
                    {
                        if (table[i, col] == 'X')
                        {
                            top = i;
                        }
                    }
                    for (int i = row; i < 8; i++)
                    {
                        if (table[i, col] == 'X')
                        {
                            bottom = i;
                        }
                    }
                    for (int i = lmost; i <= rmost; i++)
                    {
                        if (table[row, i] != '-')
                        {
                            table[row, i] = 'X';
                        }
                    }
                    for (int i = top; i <= bottom; i++)
                    {
                        if (table[i, col] != '-')
                        {
                            table[i, col] = 'X';
                        }
                    }
                }
                counter++;
            }
        }
    }
}
