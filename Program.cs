using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        /*
         * 提供設定之變數
         */
        static int oriA = 3;
        static int oriB = 0;
        static int nextA = 2;
        static int nextB = 0;
        static bool isBackwind = false;
        static int[,] arr ={{1,2,3,6},
                        {4,5,6,7},
                        {7,8,9,4},
                        {10,11,12,13}};

        static bool IsIncreaseOutLoop = false;
        static bool IsIncreaseInnerLoop = false;

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(arr.GetLength(0));
                Console.WriteLine(arr.GetLength(1));
                Console.WriteLine("-----------------------");
                Console.WriteLine("Out Loop Hold " + GetOutLoopHold());
                Console.WriteLine("Out Loop Base " + GetOutLoopBase());
                Console.WriteLine("" + increaseLoop(GetOutLoopBase(), GetOutLoopHold()));
                Console.WriteLine("Inner Loop Hold " + GetinnerLoopHold());
                Console.WriteLine("Inner Loop Base " + GetinnerLoopBase());
                Console.WriteLine("" + increaseLoop(GetinnerLoopBase(), GetinnerLoopHold()));
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        Console.Write(arr[i, j].ToString().PadRight(5));
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("-----------------------");
                int outLoopHold = GetOutLoopHold();
                int outLoopBase = GetOutLoopBase();
                IsIncreaseOutLoop = increaseLoop(GetOutLoopBase(), GetOutLoopHold());
                if (!IsIncreaseOutLoop) outLoopBase -= 1;

                int innerLoopHold = GetinnerLoopHold();
                int innerLoopBase = GetinnerLoopBase();
                IsIncreaseInnerLoop = increaseLoop(GetinnerLoopBase(), GetinnerLoopHold());
                if (!IsIncreaseInnerLoop) innerLoopBase -= 1;


                bool IsSwap = true;

                while (LoopJudg(outLoopBase, outLoopHold, IsIncreaseOutLoop))
                {
                    //Console.WriteLine("out hold {0}, out base {1}", outLoopHold, outLoopBase);

                    while (LoopJudg(innerLoopBase, innerLoopHold, IsIncreaseInnerLoop))
                    {
                        //Console.WriteLine("[{0},{1}]", outLoopBase, innerLoopBase);
                        //Console.WriteLine("[{0},{1}]",innerLoopBase,outLoopBase);
                        PringArray(outLoopBase, innerLoopBase);
                        if (IsIncreaseInnerLoop)
                            innerLoopBase++;
                        else
                            innerLoopBase--;
                    }

                    if (isBackwind && IsSwap)
                    {
                        //Console.WriteLine(isBackwind + " " + IsSwap);
                        innerLoopHold = GetinnerLoopBase();
                        innerLoopBase = GetinnerLoopHold();
                        IsIncreaseInnerLoop = increaseLoop(GetinnerLoopHold(), GetinnerLoopBase());
                        if (!IsIncreaseInnerLoop) innerLoopBase -= 1;
                        IsSwap = false;
                    }
                    else
                    {
                        innerLoopHold = GetinnerLoopHold();
                        innerLoopBase = GetinnerLoopBase();
                        IsIncreaseInnerLoop = increaseLoop(GetinnerLoopBase(), GetinnerLoopHold());
                        if (!IsIncreaseInnerLoop) innerLoopBase -= 1;
                        IsSwap = true;
                    }

                    if (IsIncreaseOutLoop)
                        outLoopBase++;
                    else
                        outLoopBase--;
                }
                Console.WriteLine();
            }
            catch (Exception mess)
            {
                Console.WriteLine(mess.ToString());
            }
                

        }
        //取得外迴圈最終值
        static int GetOutLoopHold()
        {
            if (oriA == nextA && oriA == 0)
            {
                return arr.GetLength(0);
            }
            else if (oriB == nextB && oriB == 0)
            {
                return arr.GetLength(1);
            }
            else
                return 0;
        }
        //取得外迴圈基底值
        static int GetOutLoopBase()
        {
            int ele = 0;
            if (!((oriA == nextA) && (oriA == 0) || (oriB == nextB) && (oriB == 0)))
                ele = 1;
            if (oriA == nextA)
                return oriA+ele;
            else if (oriB == nextB)
                return oriB+ele;
            else
                throw new ArgumentOutOfRangeException("GetOutLoopBase：原點、行走點陣列設定錯誤");
        }
        //取得回圈要遞增或是遞減
        static bool increaseLoop(int OutLoopBase, int OutLoopHold)
        {
            if (OutLoopHold > OutLoopBase)
                return true;
            else if (OutLoopHold < OutLoopBase)
                return false;
            else
                throw new ArgumentOutOfRangeException("increaseOutLoop Error");
        }
        //迴圈判斷式
        static bool LoopJudg(int OutLoopBase, int OutLoopHold, bool IsIncreaseOutLoop)
        {
            if (IsIncreaseOutLoop)
                return (OutLoopBase < OutLoopHold);
            else
                return (OutLoopBase >= OutLoopHold);
        }
        //取得內迴圈最終值
        static int GetinnerLoopHold()
        {
            if (oriA == 0 && nextA == 1)
                return arr.GetLength(0);
            else if (oriB == 0 && nextB == 1)
                return arr.GetLength(1);
            else
                return 0;
        }
        //取得內迴圈基底值
        static int GetinnerLoopBase()
        {

            if ((oriA == 0 && nextA == 1) || (oriB == 0 && nextB == 1))
                return 0;
            else if ((oriA > nextA) && (oriB == nextB))
                return oriA+1;
            else if ((oriA == nextA) && (oriB > nextB))
                return oriB+1;
            else
                throw new ArgumentOutOfRangeException("innerLoopBase：內迴圈Base 計算錯");
        }
        static void PringArray(int a1, int a2)
        {
            if (oriA == nextA)
                //Console.Write("[{0},{1}]", a1, a2);
                Console.Write("{0},", arr[a1, a2]);
            else if (oriB == nextB)
                Console.Write("{0},", arr[a2, a1]);
                //Console.Write("[{0},{1}]", a2, a1);
            else
                throw new ArgumentOutOfRangeException("PringArray：數值設定錯誤");
        }
    }
}
