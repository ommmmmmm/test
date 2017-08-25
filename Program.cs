﻿using System;
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
        static int oriA = 0;
        static int oriB = 2;
        static int nextA = 0;
        static int nextB = 1;
        static bool isBackwind = true;
        static int[,] arr ={{1,2,3},
                        {4,5,6},
                        {7,8,9},
                        {10,11,12}};

        static bool IsIncreaseOutLoop = false;
        static bool IsIncreaseInnerLoop = false;
        
        static void Main(string[] args)
        {
            Console.WriteLine(arr.GetLength(0));
            Console.WriteLine(arr.GetLength(1));
            Console.WriteLine("-----------------------");
            Console.WriteLine("Out Loop Hold "+GetOutLoopHold());
            Console.WriteLine("Out Loop Base " + GetOutLoopBase());
            Console.WriteLine(""+increaseLoop(GetOutLoopBase(), GetOutLoopHold()));
            Console.WriteLine("Inner Loop Hold "+GetinnerLoopHold());
            Console.WriteLine("Inner Loop Base "+GetinnerLoopBase());
            Console.WriteLine("" + increaseLoop(GetinnerLoopBase(), GetinnerLoopHold()));
            for(int i=0;i<arr.GetLength(0);i++)
            {
                for(int j=0;j<arr.GetLength(1);j++)
                {
                    Console.Write(arr[i, j]+"\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------");
            int outLoopHold = GetOutLoopHold();
            int outLoopBase = GetOutLoopBase();
            IsIncreaseOutLoop = increaseLoop(GetOutLoopBase(), GetOutLoopHold());

            int innerLoopHold = GetinnerLoopHold();
            int innerLoopBase = GetinnerLoopBase();
            IsIncreaseInnerLoop = increaseLoop(GetinnerLoopBase(), GetinnerLoopHold());
            bool IsSwap = true;

            while(outLoopJudg(outLoopBase,outLoopHold,IsIncreaseOutLoop))
            {
                Console.WriteLine("out hold {0}, out base {1}", outLoopHold, outLoopBase);
                Console.WriteLine("inner hold {0}, inner base {1}", innerLoopHold, innerLoopBase);
                
                while (outLoopJudg(innerLoopBase,innerLoopHold,IsIncreaseInnerLoop))
                {
                    
                    PringArray(outLoopBase, innerLoopBase);
                    if (IsIncreaseInnerLoop)
                        innerLoopBase++;
                    else
                        innerLoopBase--;
                     
                }
                Console.WriteLine();
                
                if (isBackwind && IsSwap)
                {
                    Console.WriteLine(isBackwind+" "+IsSwap);
                    innerLoopHold = GetinnerLoopBase();
                    innerLoopBase = GetinnerLoopHold();
                    IsIncreaseInnerLoop = increaseLoop(GetinnerLoopHold(),GetinnerLoopBase());
                    IsSwap = false;
                }
                else
                {
                    innerLoopHold = GetinnerLoopHold();
                    innerLoopBase = GetinnerLoopBase();
                    IsIncreaseInnerLoop = increaseLoop(GetinnerLoopBase(), GetinnerLoopHold());
                    IsSwap = true;
                }
                
                if (IsIncreaseOutLoop)
                    outLoopBase++;
                else
                    outLoopBase--;
            }
            
        }
        //取得外迴圈最終值
        static int GetOutLoopHold()
        {
            if (oriA == nextA && oriA == 0) {
                return arr.GetLength(0);
            }else if (oriB == nextB && oriB == 0){
                return arr.GetLength(1);
            }else
                return 0;
        }
        //取得外迴圈基底值
        static int GetOutLoopBase()
        {
            if (oriA == nextA)
                return oriA;
            else if (oriB == nextB)
                return oriB;
            else
                throw new ArgumentOutOfRangeException("GetOutLoopBase：原點、行走點陣列設定錯誤");
        }
        //取得外回圈要遞增或是遞減
        static bool increaseLoop(int OutLoopBase, int OutLoopHold)
        {
            if (OutLoopHold > OutLoopBase)
                return true;
            else if (OutLoopHold < OutLoopBase)
                return false;
            else
                throw new ArgumentOutOfRangeException("increaseOutLoop Error");
        }
        //外迴圈判斷式
        static bool outLoopJudg(int OutLoopBase, int OutLoopHold,bool IsIncreaseOutLoop)
        {
            if (IsIncreaseOutLoop)
                return (OutLoopBase < OutLoopHold);
            else
                return (OutLoopBase >= OutLoopHold);
        }
        
        static int GetinnerLoopHold()
        {
            if (oriA == 0 && nextA == 1)
                return arr.GetLength(0);
            else if (oriB == 0 && nextB == 1)
                return arr.GetLength(1);
            else
                return 0;
        }
        static int GetinnerLoopBase()
        {
            if ((oriA == 0 && nextA == 1) || (oriB == 0 && nextB == 1))
                return 0;
            else if ((oriA > nextA) && (oriB == nextB))
                return oriA;
            else if ((oriA == nextA) && (oriB > nextB))
                return oriB;
            else
                throw new ArgumentOutOfRangeException("innerLoopBase：內迴圈Base 計算錯");
        }
        static void PringArray(int a1,int a2)
        {
            if (oriA == nextA)
                Console.Write("[{0},{1}]",a1,a2 );
                //Console.Write("{0} ,", arr[a1, a2]);
            else if (oriB == nextB)
                //Console.Write("{0} ,", arr[a2, a1]);
                Console.Write("[{0},{1}]", a2, a1);
            else
                throw new ArgumentOutOfRangeException("PringArray：數值設定錯誤");
        }
    }
}
