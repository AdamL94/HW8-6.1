using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int col, rows = 0;
            Console.WriteLine("Enter Even Number of Rows And number greather than 2 for the columns For the matrix game");
            do    //משתמש בזה שיהיה לופ עד שהמשתמש יכניס את המספרים שלא יתאימו לתנאי ב while
            {
                //לוקח מספרים מהשמשתמש
                col = int.Parse(Console.ReadLine());
                rows = int.Parse(Console.ReadLine());

                //מציב את תנאי המטריצה
                if (rows % 2 != 0 || rows < 0 || col < 1)
                {
                    Console.WriteLine("Vaild values,Please try again");
                }
            } while (rows % 2 != 0 || rows < 0 || col < 1); //ממשיך את הלופ בתנאי שאחד מהם מתקיים

            int[,] arr = new int[rows, col];
            bool result = MirrorMatrix(arr);
            Console.WriteLine(result ? "The matrix is mirrored" : "The matrix is not mirrored");//מחזיר האם המטריצה מראה או לא
        }

        static bool MirrorMatrix(int[,] arr)
        {
            //יוצר מטריצה מהנתונים של המשתמש
            Console.WriteLine($"Please Enter {arr.Length} numbers");
            for (int i = 0; i < arr.GetLength(0); i++) //עמודות
            {
                for (int j = 0; j < arr.GetLength(1); j++)// שורות
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            //בדוק אם המטריצה משתקפת לאורך השורות
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int[] arr1 = new int[arr.GetLength(1)];
                int[] arr2 = new int[arr.GetLength(1)];

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr1[j] = (int)arr.GetValue(i, j);
                    arr2[j] = (int)arr.GetValue((arr.GetLength(0)) - i - 1, j);
                }

                if (!IsItMirror(arr1, arr2))
                {
                    return false;
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] != arr[j, i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        static bool IsItMirror(int[] arr1, int[] arr2)
        {
            //בודק האם שני המערכים שונים אחד מהשנים
            if (arr1.Length != arr2.Length)
            {
                return false;
            }
            return true;
        }
    }
}
