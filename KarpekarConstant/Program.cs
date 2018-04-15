using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarpekarConstant
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter a 4 digit number that does not contain a 0");
            string firstNum = "";
            int fNum = 0;
            int sNum = 0;
            int finalNum = 0;
            int i = 1;
            firstNum = Console.ReadLine();
            Program p = new Program();
            while (true)
            {
                fNum = p.getSortedNum(firstNum, true);
                //Console.WriteLine(fNum);
                sNum = p.getSortedNum(firstNum, false);
                //Console.WriteLine(sNum);
                finalNum = sNum - fNum;
                if (finalNum == 6174)
                {
                    Console.WriteLine("Found Karpekar Constant " + finalNum + " in "+ i + " interations");
                    break;
                }
                else
                {
                    Console.WriteLine("Derived num " + finalNum);
                }                
                firstNum = finalNum.ToString();
                i++;
            }
            Console.ReadKey(true);
        }
        public int getSortedNum(string numToSort, bool sortOrder)
        {
            int result = 0;
            int i = 0;
            int[] newNum = new int[numToSort.Length];
            for (i = 0; i < numToSort.Length; i++)
            {
                newNum[i] = Convert.ToInt32(numToSort.Substring(i, 1));
            }
            if (sortOrder)
            {
                Array.Sort(newNum);
            }
            else
            {
                Array.Sort(newNum, (a, b) => (-a.CompareTo(b)));
            }
                        
            for (i=0; i<newNum.Length; i++)
            {
                result *= 10;
                result += newNum[i];
            }
            return result;
        }
    }
}
