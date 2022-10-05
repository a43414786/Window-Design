using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3_2
{
    public class Game
    {
        private List<int>[] stacks;

        public bool canplace(int i)
        {
            if (stacks[i].Count == 4) return false;
            else return true;
        }
        public bool cantake(int i)
        {
            if (stacks[i].Count == 0) return false;
            else return true;
        }
        public void move(int i, int j)
        {
            int iSize = stacks[i].Count;
            stacks[j].Add(stacks[i][iSize - 1]);
            stacks[i].RemoveAt(iSize - 1);
        }
        public string[] output(int idx)
        {
            List<int> stack = stacks[idx];
            int length = 21, counter = 0;
            int num = length - stack.Count;
            string[] strArr = new string[length];
            for (int i = 0; i < num; i++)
            {
                strArr[i] = "";
            }
            for (int i = length - 1; i >= num; i--)
            {
                strArr[i] = stack[counter++].ToString();
            }
            return strArr;
        }
        public bool win()
        {
            for(int i = 0; i < 4; i++)
            {
                int[] temp = {0,0,0};
                if(stacks[i].Count > 3)
                {
                    return false;
                }
                for(int j = 0; j < stacks[i].Count; j++)
                {
                    temp[j] = stacks[i][j];
                }
                if (temp[0] != temp[1] || temp[1] != temp[2]) return false;
            }
            return true;
        }
        public Game(int[] stack1, int[] stack2, int[] stack3, int[] stack4) {
            stacks = new List<int>[4];
            for (int i = 0; i < 4; i++)
            {
                stacks[i] = new List<int>();
            }
            for (int i = 0; i < stack1[4]; i++)
            {
                stacks[0].Add(stack1[i]);
            }
            for (int i = 0; i < stack2[4]; i++)
            {
                stacks[1].Add(stack2[i]);
            }
            for (int i = 0; i < stack3[4]; i++)
            {
                stacks[2].Add(stack3[i]);
            }
            for (int i = 0; i < stack4[4]; i++)
            {
                stacks[3].Add(stack4[i]);
            }
        }
    }
}
