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
            return false;
        }
        public bool cantake(int i)
        {
            return false;
        }
        public void move(int i, int j)
        {

        }
        public string output(int i)
        {
            return null;
        }
        public bool win()
        {
            return false;
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
        public List<int>[] getStacks()
        {
            return stacks;
        }
    }
}
