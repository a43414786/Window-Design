using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2_1
{
    public class Course {
        public string courseName;
        public int day;
        public int start;
        public int end;
        public Course(string courseName,int day,int start,int end)
        {
            this.courseName = courseName;
            this.day = day;
            this.start = start;
            this.end = end;
        }
    }
    class Program
    {
        public static void addCourses(ref List<Course> courses)
        {
            string str;
            string[] strs;
            Console.WriteLine("請輸入要加入的課程，格式為<課程代號 星期 開始節 結束節>");
            str = Console.ReadLine();
            strs = str.Split();
            if (strs.GetLength(0) != 4) {
                Console.WriteLine("Illegal input");
            }
            else
            {
                try
                {
                    string courseName = strs[0];
                    int day = int.Parse(strs[1]);
                    int start = int.Parse(strs[2]);
                    int end = int.Parse(strs[3]);
                    bool err = false;
                    for(int i = 0; i < courses.Count; i++)
                    {
                        Course temp = courses[i];
                        if (courseName.Equals(temp.courseName)) {
                            err = true;
                            Console.WriteLine("課程重複!");
                        }
                        if (temp.day == day) {
                            if (!(temp.start > end || temp.end < start)) {
                                err = true;
                                Console.WriteLine("課程衝堂!");
                            }
                        }
                    }
                    if (!err)
                    {
                        Console.WriteLine("成功加入課程!");
                        courses.Add(new Course(courseName, day, start, end));
                    }
                }
                catch
                {
                    Console.WriteLine("Illegal input");
                }
            }
        }
        public static void delCourses(ref List<Course> courses)
        {
            string str;
            Console.Write("請輸入要刪除的課程代號:");
            str = Console.ReadLine();
            bool find = false;
            try
            {
                for (int i = 0; i < courses.Count; i++)
                {
                    Course temp = courses[i];
                    if (str.Equals(temp.courseName))
                    {
                        find = true;
                        courses.RemoveAt(i);
                        Console.WriteLine($"成功刪除課程: {str}");
                        break;
                    }
                }
                if (!find)
                {
                    Console.WriteLine($"課程 {str} 不在課表中");
                }
            }
            catch
            {
                Console.WriteLine("Illegal input");
            }
        }
        public static void printCourse(List<Course> courses)
        {
            string[,] courseTable = new string[7, 8];
            for(int i = 0; i < courses.Count; i++)
            {
                Course temp = courses[i];
                for (int j = temp.start - 1; j < temp.end; j++) {
                    courseTable[temp.day - 1,j] = temp.courseName;
                }
            }
            string header = String.Format("{0,-6}{1,-6}{2,-6}{3,-6}{4,-6}{5,-6}{6,-6}{7,-6}", "", "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat");
            Console.WriteLine(header);
            //Console.WriteLine();
            for (int i = 0; i < 8; i++)
            {
                string contain = String.Format("{0,-6}{1,-6}{2,-6}{3,-6}{4,-6}{5,-6}{6,-6}{7,-6}",i + 1,courseTable[6,i], courseTable[0, i], courseTable[1, i], courseTable[2, i], courseTable[3, i], courseTable[4, i], courseTable[5, i]);
                Console.WriteLine(contain);
            }
        }
        public static void calculate(List<Course> courses)
        {
            int sum = 0;
            for (int i = 0; i < courses.Count; i++)
            {
                Course temp = courses[i];
                sum += (temp.end - temp.start + 1);
            }
            Console.WriteLine(sum);
        }
            static void Main(string[] args)
        {
            int choice = 0;
            List<Course> courses = new List<Course>();
            do
            {
                Console.WriteLine("(1)新增課程 (2)刪除課程 (3)列印課表 (4)計算學分 (5)離開程式");
                Console.Write("請輸入數字選擇功能: ");
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Illegal input");
                }
                switch (choice)
                {
                    case 1:
                        addCourses(ref courses);
                        break;
                    case 2:
                        delCourses(ref courses);
                        break;
                    case 3:
                        printCourse(courses);
                        break;
                    case 4:
                        calculate(courses);
                        break;
                    case 5:
                        break;
                }
                Console.WriteLine();
            } while (choice != 5);
        }
    }
}
