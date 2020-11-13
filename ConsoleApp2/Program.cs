using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*            
                        Console.WriteLine("練習問題 2 - 1");
                        Console.WriteLine("文字を入力して下さい：");
                        string s1 = Console.ReadLine();
                        Console.WriteLine("その文字を出力します：");
                        Console.WriteLine(s1);
                        Console.WriteLine("\n");

                        Console.WriteLine("練習問題 2 - 2");
                        Console.WriteLine("数値を入力して下さい：");
                        string s2 = Console.ReadLine();    // 1行分の文字列を入力する
                        int n2 = int.Parse(s2);          // 文字列から数値を得る
                        Console.WriteLine("その数値を出力します：");
                        Console.WriteLine(n2);
                        Console.WriteLine("\n");

                        Console.WriteLine("練習問題 2 - 3");
                        Console.WriteLine("数値を入力して下さい：");
                        string s3 = Console.ReadLine();    // 1行分の文字列を入力する
                        int n = int.Parse(s3);          // 文字列から数値を得る
                        double x203 = Math.Pow(n, 2);
                        double y203 = Math.Pow(n, 3);
                        double z203 = Math.Pow(n, 4);
                        Console.WriteLine("その数値を、べき乗します：");
                        Console.WriteLine(n + "の2乗={0}", x203);
                        Console.WriteLine(n + "の3乗={0}", y203);
                        Console.WriteLine(n + "の4乗={0}", z203);
                        Console.WriteLine("\n");

                        Console.WriteLine("練習問題 2 - 4");
                        Console.WriteLine("2つの数値を入力して下さい：");
                        string line = Console.ReadLine();
                        string[] array = line.Split(' ');
                        int num1 = int.Parse(array[0]);
                        int num2 = int.Parse(array[1]);
                        int sum24 = num1 + num2;
                        int dif24 = num1 - num2;
                        int mul24 = num1 * num2;
                        int syou24 = DivRem(num1, num2, out int amari24);
                        Console.WriteLine("和={0}", sum24);
                        Console.WriteLine("差={0}", dif24);
                        Console.WriteLine("積={0}", mul24);
                        Console.WriteLine("商={0}", syou24);
                        Console.WriteLine("余={0}", amari24);
                        Console.WriteLine("\n");

                        Console.WriteLine("練習問題 2 - 5");
                        Console.WriteLine("2つの数値を入力して下さい：");
                        string line25 = Console.ReadLine();
                        string[] array25 = line25.Split(' ');
                        int num125 = int.Parse(array25[0]);
                        int num225 = int.Parse(array25[1]);
                        int ave25 = (num125 + num225) / 2;
                        Console.WriteLine("平均={0}", ave25);
                        Console.WriteLine("\n");

                        Console.WriteLine("練習問題 2 - 6");
                        Console.WriteLine("あなたは何歳ですか：");
                        string s26 = Console.ReadLine();    // 1行分の文字列を入力する
                        int n26 = int.Parse(s26);          // 文字列から数値を得る
                        n26 = n26 * 365;
                        Console.WriteLine("あなたは 約" + n26 + "日 生きました");
                        Console.WriteLine("\n");

                        Console.WriteLine("練習問題 3 - 1");
                        Console.WriteLine("2つの数値を入力して下さい：");
                        string line31 = Console.ReadLine();
                        string[] array31 = line31.Split(' ');
                        int num31x = int.Parse(array31[0]);
                        int num31y = int.Parse(array31[1]);
                        Console.WriteLine("x={0}", num31x);
                        Console.WriteLine("y={0}", num31y);
                        if (num31x > num31y)
                        {
                            Console.WriteLine("xはyより大きい");
                        }
                        Console.WriteLine("\n");

                        Console.WriteLine("練習問題 3 - 2");
                        Console.WriteLine("2つの数値を入力して下さい：");
                        string line32 = Console.ReadLine();
                        string[] array32 = line32.Split(' ');
                        int num32x = int.Parse(array32[0]);
                        int num32y = int.Parse(array32[1]);
                        Console.WriteLine("x={0}", num32x);
                        Console.WriteLine("y={0}", num32y);
                        if (num32x > num32y)
                        {
                            Console.WriteLine(num32x);
                            Console.WriteLine("\n");
                        }
                        else if (num32x < num32y)
                        {
                            Console.WriteLine(num32y);
                            Console.WriteLine("\n");
                        }
                        else
                        {
                            Console.WriteLine("xとyは等しい");
                            Console.WriteLine("\n");
                        }

                        Console.WriteLine("練習問題 3 - 3");
                        Console.WriteLine("2つの数値を入力して下さい：");
                        string line33 = Console.ReadLine();
                        string[] array33 = line33.Split(' ');
                        int num33x = int.Parse(array33[0]);
                        int num33y = int.Parse(array33[1]);
                        Console.WriteLine("x={0}", num33x);
                        Console.WriteLine("y={0}", num33y);
                        if (num33x > num33y)
                        {
                            Console.WriteLine("xはyより大きい");
                            Console.WriteLine("\n");
                        }
                        else if (num33x < num33y)
                        {
                            Console.WriteLine("xはyより小さい");
                            Console.WriteLine("\n");
                        }

                        Console.WriteLine("練習問題 3 - 4");
                        Console.WriteLine("2つの数値を入力して下さい：");
                        string line34 = Console.ReadLine();
                        string[] array34 = line34.Split(' ');
                        int num34x = int.Parse(array34[0]);
                        int num34y = int.Parse(array34[1]);
                        Console.WriteLine("x={0}", num34x);
                        Console.WriteLine("y={0}", num34y);
                        if (num34x > num34y)
                        {
                            Console.WriteLine("xはyより大きい");
                            Console.WriteLine("\n");
                        }
                        else if (num34x < num34y)
                        {
                            Console.WriteLine("xはyより小さい");
                            Console.WriteLine("\n");
                        }
                        else
                        {
                            Console.WriteLine("xとyは等しい");
                            Console.WriteLine("\n");
                        }

                        Console.WriteLine("練習問題 3 - 5");
                        Console.WriteLine("数値を入力して下さい：");
                        string s35 = Console.ReadLine();    // 1行分の文字列を入力する
                        int n35 = int.Parse(s35);          // 文字列から数値を得る
                        int syou25 = DivRem(n35, 2, out int amari35);

                        if (amari35 == 0)
                        {
                            Console.WriteLine("入力値は偶数です");
                            Console.WriteLine("\n");
                        }
                        else
                        {
                            Console.WriteLine("入力値は奇数です");
                            Console.WriteLine("\n");
                        }

                        Console.WriteLine("練習問題 3 - 6");
                        Console.WriteLine("数値を入力して下さい：");
                        string s36 = Console.ReadLine();    // 1行分の文字列を入力する
                        int n36 = int.Parse(s36);          // 文字列から数値を得る
                        int syou36 = DivRem(n36, 2, out int amari36);

                        if (syou36 == 0)
                        {
                            Console.WriteLine("入力値は偶数です");
                        }
                        else if (amari36 == 0)
                        { 
                            if (syou36 > 0)
                            {
                               Console.WriteLine("入力値は正の偶数です");
                            }
                            else
                            {
                               Console.WriteLine("入力値は負の偶数です");
                            }
                        }
                        else
                        {
                            if (syou36 > 0)
                            {
                               Console.WriteLine("入力値は正の奇数です");
                            }
                            else
                            {
                               Console.WriteLine("入力値は負の奇数です");
                            }
                        }
                        Console.WriteLine("\n");

            Console.WriteLine("練習問題 3 - 7");
            Console.WriteLine("点数とケース番号(1～3)を入力して下さい：");
            string line37 = Console.ReadLine();
            string[] array37 = line37.Split(' ');
            int nTensu = int.Parse(array37[0]);
            int nCaseN = int.Parse(array37[1]);
            if (nCaseN == 1)
            {
                if (nTensu >= 60)
                {
                    Console.WriteLine("合格");
                }
                else
                {
                    Console.WriteLine("不合格");
                }
            }
            else if (nCaseN == 2)
            {
                if (nTensu >= 80)
                {
                    Console.WriteLine("たいへんよくできました。");
                }
                else if (60 <= nTensu && nTensu < 80)
                {
                    Console.WriteLine("よくできました。");
                }
                else
                {
                    Console.WriteLine("ざんねんでした。");
                }
            }
            else if (nCaseN == 3)
            {
                if (nTensu >= 80)
                {
                    Console.WriteLine("優");
                }
                else if (70 <= nTensu && nTensu < 80)
                {
                    Console.WriteLine("良");
                }
                else if (60 <= nTensu && nTensu < 70)
                {
                    Console.WriteLine("可");
                }
                else
                {
                    Console.WriteLine("不可");
                }
            }
            else
            {
                Console.WriteLine("正しいケース番号(1～3)を入力して下さい");
            }
            Console.WriteLine("\n");

                        Console.WriteLine("練習問題 3 - 8");
                        Console.WriteLine("中間試験と、期末試験の点数を入力して下さい：");
                        string line38 = Console.ReadLine();
                        string[] array38 = line38.Split(' ');
                        int nTyukn = int.Parse(array38[0]);
                        int nKimat = int.Parse(array38[1]);
                        if ((nTyukn >= 60 & nKimat >= 60) || 
                            (nTyukn + nKimat >= 130) ||
                            (nTyukn + nKimat >= 100) && (nTyukn >= 90 || nKimat >= 90))
                        {
                            Console.WriteLine("合格");
                        }
                        else
                        {
                            Console.WriteLine("不合格");
                        }
                        Console.WriteLine("\n");

                        Console.WriteLine("練習問題 3 - 9");
                        Console.WriteLine(">0=日曜、1=月曜、2=火曜、3=水曜、4=木曜、5=金曜、6=土曜");
                        Console.WriteLine(">0=午前、1=午後、2=夜間");
                        Console.WriteLine("受診を希望する時間帯を入力して下さい：");
                        Console.WriteLine("例）水曜の夜間：3 2");
                        //二次元配列
                        int[,] Byoin = new int[,]
                        {
                            { 0, 1, 0, 1, 1, 0, 1 },
                            { 0, 1, 1, 1, 1, 1, 0 },
                            { 0, 1, 1, 0, 1, 1, 0 }
                        };
                        string line39 = Console.ReadLine();
                        string[] array39 = line39.Split(' ');
                        int n39x = int.Parse(array39[0]);
                        int n39y = int.Parse(array39[1]);
                        int result = Byoin[n39y, n39x];
                        if (result == 0)
                        {
                            Console.WriteLine("病院は休診です");
                        }
                        else
                        {
                            Console.WriteLine("病院は開いています");
                        }

                        Console.WriteLine("練習問題 3 - 10");
                        Console.WriteLine("2つの数値を入力して下さい：");
                        string line310 = Console.ReadLine();
                        string[] array310 = line310.Split(' ');
                        int nx = int.Parse(array310[0]);
                        int ny = int.Parse(array310[1]);
                        int syoux = DivRem(nx, 2, out int amarix);
                        int syouy = DivRem(ny, 2, out int amariy);

                        if (nx < ny & amarix == 0 & amariy == 0)
                        {
                            Console.WriteLine("xはyより小さく、かつ、xとyは共に偶数である。");
                        }
                        if (nx == ny & nx < 0 & ny < 0)
                        {
                            Console.WriteLine("xとyは等しく、かつ、負の数である。");
                        }
                        if (nx < ny || amarix == 0)
                        {
                            Console.WriteLine("xはyより小さい、または、xは偶数である。");
                        }
                        if ((nx <= 10 || nx >= 100) & (ny >= 10 && ny <= 100))
                        {
                            Console.WriteLine("xは10以下または100以上で、かつ、yは10以上かつ100以下である。");
                        }
                        if (!(nx < 0 && ny < 0))
                        {
                            Console.WriteLine("xもyも負の数である、ではない。");
                        }
                        Console.WriteLine("\n");

                        Console.WriteLine("練習問題 3 - 11");
                        Console.WriteLine("好きな鮨を選択して下さい：");
                        Console.WriteLine("1：まぐろ　2：えび　3：こはだ　4：たまご　5：うに");
                        string s311 = Console.ReadLine();    // 1行分の文字列を入力する
                        int n311 = int.Parse(s311);          // 文字列から数値を得る
                        switch (n311)
                        {
                            case 1:
                                Console.WriteLine("まぐろ ね");
                                break;
                            case 2:
                                Console.WriteLine("えび ね");
                                break;
                            case 3:
                                Console.WriteLine("こはだ ね");
                                break;
                            case 4:
                                Console.WriteLine("たまご ね");
                                break;
                            case 5:
                                Console.WriteLine("うに ね");
                                break;
                            default:
                                Console.WriteLine("それは、ありません");
                                break;
                        }
                        Console.WriteLine("\n");

                        Console.WriteLine("練習問題 3 - 12");
                        Console.WriteLine("月を入力して下さい：");
                        Console.WriteLine("1：1月　2：2月　3：3月 ..");
                        string s312 = Console.ReadLine();    // 1行分の文字列を入力する
                        int n312 = int.Parse(s312);          // 文字列から数値を得る
                        switch (n312)
                        {
                            case 1:
                            case 3:
                            case 5:
                            case 7:
                            case 8:
                            case 10:
                            case 12:
                                Console.WriteLine("31日です");
                                break;
                            case 2:
                                Console.WriteLine("28日です");
                                break;
                            case 4:
                            case 6:
                            case 9:
                            case 11:
                                Console.WriteLine("30日です");
                                break;
                            default:
                                Console.WriteLine("その月は、ありません");
                                break;
                        }
                        Console.WriteLine("\n");

            Console.WriteLine("練習問題 4 - 1");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("SPAM"); 
            }
            Console.WriteLine("\n");

            Console.WriteLine("練習問題 4 - 2");
            int n42 = 3;
            int result42 =0;
            for (int i = 1; i < 10; i++)
            {
                result42 = n42* i;
                Console.WriteLine(result42);
            }
            Console.WriteLine("\n");

            Console.WriteLine("練習問題 4 - 3");
            double result43 = 0;
            for (int i = 1; i < 9; i++)
            {
                result43 = Math.Pow(2,i);
                Console.WriteLine(result43);
            }
            Console.WriteLine("\n");

            Console.WriteLine("練習問題 4 - 4");
            long lkaijyo44 = Factorial(7);
            Console.WriteLine("7の階乗は"+ lkaijyo44);
            Console.WriteLine("\n");

            Console.WriteLine("練習問題 4 - 5");
            int sum45=0;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("整数を入力して下さい(" + i + "/10回目)：");
                string s45 = Console.ReadLine();    // 1行分の文字列を入力する
                int n45 = int.Parse(s45);          // 文字列から数値を得る
                sum45 = sum45 + n45;
            }
            Console.WriteLine("合計：" + sum45);

            Console.WriteLine("練習問題 4 - 6");
            int sum460 = 0;
            int sum461 = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("0か1を入力して下さい(" + i + "/10回目)：");
                string s46 = Console.ReadLine();    // 1行分の文字列を入力する
                int n46 = int.Parse(s46);          // 文字列から数値を得る
                if (n46 == 0)
                {
                    sum460 = sum460 + 1;
                }
                else if (n46 == 1)
                {
                    sum461 = sum461 + 1;
                }
                else
                {
                    ;
                }
            }
            Console.WriteLine("勝ち数：" + sum461 + "   負け数：" + sum460);

            Console.WriteLine("練習問題 4 - 7");
            int sum47G = 0;
            int sum47T = 0;
            for (int i = 1; i < 10; i++)
            {
                Console.Write(i + "回の表、巨人の得点は？  ");
                string s47G = Console.ReadLine();    // 1行分の文字列を入力する
                int n47G = int.Parse(s47G);          // 文字列から数値を得る
                sum47G = sum47G + n47G;

                Console.Write(i + "回の裏、阪神の得点は？  ");
                string s47T = Console.ReadLine();    // 1行分の文字列を入力する
                int n47T = int.Parse(s47T);          // 文字列から数値を得る
                sum47T = sum47T + n47T;

            }
            Console.WriteLine("巨人：" + sum47G + "点   阪神：" + sum47T + "点");
            if (sum47G > sum47T)
            {
                Console.WriteLine("巨人の勝ち");
            }
            else if (sum47G < sum47T)
            {
                Console.WriteLine("阪神の勝ち");
            }
            else
            {
                Console.WriteLine("引き分け");
            }

            Console.WriteLine("練習問題 4 - 8");
            int max48 = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("自然数（正の整数）を入力して下さい(" + i + "/10回目)：");
                string s48 = Console.ReadLine();    // 1行分の文字列を入力する
                int n48 = int.Parse(s48);          // 文字列から数値を得る
                if (n48 > max48)
                {
                    max48 = n48;
                }


            }
            Console.WriteLine("最大数：" + max48);

            Console.WriteLine("練習問題 4 - 9");
            List<int> intList = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("整数を入力して下さい(" + i + "/10回目)：");
                string s49 = Console.ReadLine();    // 1行分の文字列を入力する
                int n49 = int.Parse(s49);          // 文字列から数値を得る
                intList[i] = n49;
            }
            Console.WriteLine("最大数：" + intList.Max() + "  最小数：" + intList.Min());

            Console.WriteLine("練習問題 4 - 10");
            Console.WriteLine("*を表示する個数を入力して下さい");
            string s410 = Console.ReadLine();    // 1行分の文字列を入力する
            int n410 = int.Parse(s410);          // 文字列から数値を得る

            for (int i = 0; i < n410; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine("練習問題 4 - 11");
            Console.WriteLine("0-9を表示する個数を入力して下さい");
            string s411 = Console.ReadLine();    // 1行分の文字列を入力する
            int n411 = int.Parse(s411);          // 文字列から数値を得る
            int j = 0;

            for (int i = 0; i < n411; i++)
            {
                Console.Write(j);
                j++;
                if (j == 10)
                {
                    j = 0;
                }
            }

            Console.WriteLine("練習問題 4 - 12");
            int sum412 = 0;
            for (int i = 1; sum412 <= 100; i++)
            {
                Console.WriteLine("合計が 100 を超えるまで数値を入力して下さい：");
                string s412 = Console.ReadLine();    // 1行分の文字列を入力する
                int n412 = int.Parse(s412);          // 文字列から数値を得る
                sum412 = sum412 + n412;
            }
            Console.WriteLine("合計：" + sum412);

            Console.WriteLine("練習問題 4 - 13");
            int sum413s = 0;
            int sum413b = 0;
            while ( true )
            {
                Console.WriteLine("ストライク=1 or ボール=2 ？");
                string s413 = Console.ReadLine();    // 1行分の文字列を入力する
                int n413 = int.Parse(s413);          // 文字列から数値を得る
                if (n413 == 1)
                {
                    sum413s = sum413s + 1;
                    if (sum413s == 3)
                    {
                        break;
                    }
                }
                else if (n413 == 2)
                {
                    sum413b = sum413b + 1;
                    if (sum413b == 4)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(sum413b + "ボール, " + sum413s + "ストライク");

            Console.WriteLine("練習問題 4 - 14");
            int sum414s = 0;
            int sum414b = 0;
            while (true)
            {
                Console.WriteLine("ストライク=1 or ボール=2 or ファール=3 ？");
                string s414 = Console.ReadLine();    // 1行分の文字列を入力する
                int n413 = int.Parse(s414);          // 文字列から数値を得る
                if (n413 == 1 || n413 == 3)
                {
                    if (!(sum414s == 2 && n413 == 3))
                    {
                        sum414s = sum414s + 1;
                    }
                    if (sum414s == 3)
                    {
                        break;
                    }
                }
                else if (n413 == 2)
                {
                    sum414b = sum414b + 1;
                    if (sum414b == 4)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(sum414b + "ボール, " + sum414s + "ストライク");

            Console.WriteLine("練習問題 4 - 15");
            Console.WriteLine("素因数分解する2以上の数値を入力しなさい：");
            string s415 = Console.ReadLine();    // 1行分の文字列を入力する
            int n415 = int.Parse(s415);          // 文字列から数値を得る
            List<int> Factorization = new List<int>();
            for (int i = 2; i <= Math.Sqrt(n415); i++)
            {
                while (n415 % i == 0)
                {
                    Factorization.Add(i);
                    n415 = n415 / i;
                }
            }
            Factorization.Add(n415);
            foreach (int i in Factorization)
            {
                if (i != 1)
                {
                    Console.Write(i + "  ");
                }
            }

            Console.WriteLine("練習問題 4 - 16");
            Console.WriteLine("素数を入力して下さい：");
            string s416 = Console.ReadLine();    // 1行分の文字列を入力する
            int n416 = int.Parse(s416);          // 文字列から数値を得る
            if (n416 < 2 || n416 == 2 || n416 % 2 == 0)
            {
                Console.WriteLine(n416 + "は素数ではありません");
                goto end;
            }
            double sqrtNum = Math.Sqrt(n416);
            for (int i = 3; i <= sqrtNum; i += 2)
            {
                if (n416 % i == 0)
                {
                    // 素数ではない
                    Console.WriteLine(n416 + "は素数ではありません");
                    goto end;
                }
            }
            Console.WriteLine(n416 + "は素数です");
            end:

            Console.WriteLine("練習問題 4 - 17");
            //二次元配列
            int[,] Kuku = new int[10, 10];
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Kuku[i, j] = j * i;
                    if (j == 9)
                    {
                        Console.Write(i + " x " + j + " =");
                        Console.WriteLine(" {0,2}", Kuku[i, j]);
                    }
                    else
                    {
                        Console.Write(i + " x " + j + " =");
                        Console.Write(" {0,2}   ", Kuku[i, j]);
                    }
                }
            }

            Console.WriteLine("練習問題 4 - 18");
            int sum418n = 0;
            while (true)
            {
                Console.WriteLine("数値入力して下さい");
                string s418 = Console.ReadLine();    // 1行分の文字列を入力する
                int n418 = int.Parse(s418);          // 文字列から数値を得る
                sum418n = n418 + sum418n;
                if (n418 == 0)
                {
                    break;
                }
            }
            Console.WriteLine("合計：" +  sum418n);

            Console.WriteLine("練習問題 4 - 19");
            int sum419n = 0;
            int i = 0;
            while (true)
            {
                Console.WriteLine("数値を入力して下さい");
                string s419 = Console.ReadLine();    // 1行分の文字列を入力する
                int n419 = int.Parse(s419);          // 文字列から数値を得る
                i = i + 1;
                if (n419 == 0 & i == 1) 
                {
                    Console.WriteLine("最初に 0 を入力してはいけません");
                }
                else
                {
                    sum419n = n419 + sum419n;
                    if (n419 == 0)
                    {
                        i = i - 1;
                        break;
                    }
                }
            }
            sum419n = sum419n / i;
            Console.WriteLine("平均：" + sum419n);


            Console.WriteLine("練習問題 4 - 20");
            Console.WriteLine("サイズを示す数値を入力して下さい");
            string s420 = Console.ReadLine();    // 1行分の文字列を入力する
            int n420 = int.Parse(s420);          // 文字列から数値を得る
            for (int i = 1; i <= n420; i++)
            {
                string rst = new string('$', i);
                Console.WriteLine(rst);
            }

            Console.WriteLine("練習問題 4 - 21");
            Console.WriteLine("サイズを示す数値を入力して下さい");
            string s421 = Console.ReadLine();    // 1行分の文字列を入力する
            int n421 = int.Parse(s421);          // 文字列から数値を得る
            for (int i = 1; i <= n421; i++)
            {
                for (int j = 1; j <= n421; j++)
                {
                    if (i == j || i == n421+1-j)
                    {
                        Console.Write("x");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.Write("\n");

            }

            Console.WriteLine("練習問題 4 - 22");
            int[] Fibo = new int[1000];
            Fibo[0] = 0;
            Fibo[1] = 1;
            Console.Write(Fibo[0] + ", " + Fibo[1] );
            //            for (int i = 2; Fibo[i] < 1000; i++)
            int i = 2;
            while (true)
            {
                Fibo[i] = Fibo[i - 2] + Fibo[i - 1];
                if (Fibo[i] > 1000)
                {
                    break;
                }
                Console.Write(", " + Fibo[i]);
                i = i + 1;
            }

            Console.WriteLine("練習問題 5 - 1");
            Console.WriteLine("10個の数値を入力して下さい：");
            string line = Console.ReadLine();
            //配列
            string[] array = line.Split(' ');

            int num1 = int.Parse(array[0]);
            int num2 = int.Parse(array[1]);
            int num3 = int.Parse(array[2]);
            int num4 = int.Parse(array[3]);
            int num5 = int.Parse(array[4]);
            int num6 = int.Parse(array[5]);
            int num7 = int.Parse(array[6]);
            int num8 = int.Parse(array[7]);
            int num9 = int.Parse(array[8]);
            int num10 = int.Parse(array[9]);

            int snum1 = num1 * 2;
            int snum2 = num2 * 2;
            int snum3 = num3 * 2;
            int snum4 = num4 * 2;
            int snum5 = num5 * 2;
            int snum6 = num6 * 2;
            int snum7 = num7 * 2;
            int snum8 = num8 * 2;
            int snum9 = num9 * 2;
            int snum10 = num10 * 2;

            array[0] = snum1.ToString();
            array[1] = snum2.ToString();
            array[2] = snum3.ToString();
            array[3] = snum4.ToString();
            array[4] = snum5.ToString();
            array[5] = snum6.ToString();
            array[6] = snum7.ToString();
            array[7] = snum8.ToString();
            array[8] = snum9.ToString();
            array[9] = snum10.ToString();

            for (int i =0; i < 10; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine("練習問題 5 - 2");
            Console.WriteLine("10個の数値を入力して下さい：");
            string line = Console.ReadLine();
            //配列
            string[] array = line.Split(' ');

            int num1 = int.Parse(array[0]);
            int num2 = int.Parse(array[1]);
            int num3 = int.Parse(array[2]);
            int num4 = int.Parse(array[3]);
            int num5 = int.Parse(array[4]);
            int num6 = int.Parse(array[5]);
            int num7 = int.Parse(array[6]);
            int num8 = int.Parse(array[7]);
            int num9 = int.Parse(array[8]);
            int num10 = int.Parse(array[9]);

            array[0] = num10.ToString();
            array[1] = num9.ToString();
            array[2] = num8.ToString();
            array[3] = num7.ToString();
            array[4] = num6.ToString();
            array[5] = num5.ToString();
            array[6] = num4.ToString();
            array[7] = num3.ToString();
            array[8] = num2.ToString();
            array[9] = num1.ToString();

            for (int i = 0; i < 10; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine("練習問題 5 - 3");
            Console.WriteLine("10個の数値を入力して下さい：");
            string line = Console.ReadLine();
            //配列
            string[] array = line.Split(' ');
            int[] gusuu = new int[10];
            int[] kisuu = new int[10];
            int[] narray = new int[10];
            for (int i = 0; i < 10; i++)
            {
                narray[i] = int.Parse(array[i]);
                int syou53 = DivRem(narray[i], 2, out int amari53);
                if (amari53 == 0)
                {
                    gusuu[i] = narray[i];
                }
                else
                {
                    kisuu[i] = narray[i];
                }
                if (i == 9)
                {
                    Console.Write("\n");
                    Console.Write("偶数：");
                    foreach (int sgusuu in gusuu)
                    {
                        if (sgusuu != 0)
                        {
                            Console.Write(sgusuu + " ");
                        }
                    }
                    Console.Write("\n");
                    Console.Write("奇数：");
                    foreach (int skisuu in kisuu)
                    {
                        if (skisuu != 0)
                        {
                            Console.Write(skisuu + " ");
                        }
                    }
                }
            }

            Console.WriteLine("練習問題 5 - 4");
            int sum54 = 0;
            int[] narray = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("数値を入力して下さい：");
                string s54 = Console.ReadLine();    // 1行分の文字列を入力する
                int n54 = int.Parse(s54);          // 文字列から数値を得る
                sum54 = sum54 + n54;
                narray[i] = n54;
                if (sum54 > 100)
                {
                        break;
                }
            }
            Console.Write("\n");
            Console.Write("入力値：");
            foreach (int ls54 in narray)
            {
                //                if (!(sum54 > 100 && ls54 != 0))
                if (sum54 < 100)
                {
                    Console.Write(ls54 + " ");
                }
                else if (ls54 != 0)
                {
                    Console.Write(ls54 + " ");
                }
            }

            Console.WriteLine("練習問題 5 - 5");
            int num = int.Parse(Console.ReadLine());
            int[] binary = new int[16];

            string nisin = Convert.ToString(num, 2);
            nisin = "0000000000000000" + nisin;
            string bin = SubstringRight(nisin, 16);

            // 配列 binaryに0か1を代入する

            for (int i = 0; i < 16; i++)
            { 
                binary[i] = int.Parse(bin.Substring(i, 1));
                Console.Write(binary[i]);
            }

            Console.WriteLine("練習問題 5 - 6");
            int[,] kuku2 = new int[9, 9];

            // 配列 kuku2 に値を代入する

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    kuku2[i, j] = (j + 1) * (i+1);
                    if (j == 8)
                    {
                        Console.WriteLine(" {0,2}", kuku2[i, j]);
                    }
                    else
                    {
                        Console.Write(" {0,2}   ", kuku2[i, j]);
                    }
                }
            }

            Console.WriteLine("練習問題 5 - 6");
            int n56x = 0;
            int n56y = 0;
            int[,] kuku3 = new int[9, 9]
            {
                { 1,  2,  3,  4,  5,  6,  7,  8,  9 },
                { 2,  4,  6,  8, 10, 12, 14, 16, 18 },
                { 3,  6,  9, 12, 15, 18, 21, 24, 27 },
                { 4,  8, 12, 16, 20, 24, 28, 32, 36 },
                { 5, 10, 15, 20, 25, 30, 35, 40, 45 },
                { 6, 12, 18, 24, 30, 36, 42, 48, 54 },
                { 7, 14, 21, 28, 38, 42, 49, 56, 63 },
                { 8, 16, 24, 32, 40, 48, 56, 64, 72 },
                { 9, 18, 27, 36, 45, 54, 63, 72, 81 }
            };
            Console.WriteLine("2つの数値を入力して下さい：");
            string line56 = Console.ReadLine();
            string[] array56 = line56.Split(' ');
            try
            {
                n56x = int.Parse(array56[0]);
            }
            catch
            {
                n56x = 0;
            }
            try
            {
                n56y = int.Parse(array56[1]);
            }
            catch
            {
                n56y = 0; //エラーのときの数値
            }

            if ((0 >= n56x || 9 < n56x) || (0 >= n56y || 9 < n56y))
            {
                Console.WriteLine("エラー。1 桁の数値（ 1 ～ 9 に限定）を2つ入力して下さい");
            }
            else
            {
                int result = kuku3[n56y-1, n56x-1];
                Console.WriteLine("積は " + result + " です");
            }

            Console.WriteLine("練習問題 5 - 8");
            List<int> intList3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < 10; i++)
            {
                int j = i + 1;
                Console.WriteLine("整数を入力して下さい(" + j + "/10回目)：");
                string s49 = Console.ReadLine();    // 1行分の文字列を入力する
                int n49 = int.Parse(s49);          // 文字列から数値を得る
                intList3[i] = n49;
            }
            // listをソート
            intList3.Sort();
            Console.WriteLine("[{0}]", string.Join(", ", intList3));


            Console.WriteLine("練習問題 6 - 1");
            Console.WriteLine("2乗する整数を入力して下さい");
            string s61 = Console.ReadLine();    // 1行分の文字列を入力する
            int n61 = int.Parse(s61);          // 文字列から数値を得る
            int n61n = Nijyo(n61);
            Console.WriteLine("結果："+ n61n );


            Console.WriteLine("練習問題 6 - 2");
            Console.WriteLine("平均値を求めるます。2つの数値を入力して下さい：");
            string line = Console.ReadLine();
            string[] array = line.Split(' ');
            int num621 = int.Parse(array[0]);
            int num622 = int.Parse(array[1]);
            int n62h = Heikin(num621, num622);
            Console.WriteLine("結果：" + n62h);


            Console.WriteLine("練習問題 6 - 3");
            Console.WriteLine("2つの整数の大きい方を求めます。2つの整数を入力して下さい：");
            string line631 = Console.ReadLine();
            string[] array631 = line631.Split(' ');
            int num6311 = int.Parse(array631[0]);
            int num6312 = int.Parse(array631[1]);
            int num6313 = 0;
            int n631h = Max(num6311, num6312, num6313);
            Console.WriteLine("結果：" + n631h);
            Console.WriteLine("\n");
            Console.WriteLine("3つの整数の大きい方を求めます。3つの整数を入力して下さい：");
            string line632 = Console.ReadLine();
            string[] array632 = line632.Split(' ');
            int num6321 = int.Parse(array632[0]);
            int num6322 = int.Parse(array632[1]);
            int num6323 = int.Parse(array632[2]);
            int n632h = Max(num6321, num6322, num6323);
            Console.WriteLine("結果：" + n632h);

            Console.WriteLine("練習問題 6 - 4");
            Console.WriteLine("サイズを示す数値を入力して下さい");
            string s64 = Console.ReadLine();    // 1行分の文字列を入力する
            int n64 = int.Parse(s64);          // 文字列から数値を得る
            n64 = Sankaku(n64);
            Console.WriteLine("");
            Console.WriteLine("次に、サイズ 3、4、5 の3つの三角形を表示します");
            n64 = Sankaku(3);
            Console.WriteLine("");
            n64 = Sankaku(4);
            Console.WriteLine("");
            n64 = Sankaku(5);

            Console.WriteLine("練習問題 6 - 5");
            Console.WriteLine("サイズを示す数値と、表示する文字を入力して下さい");
            string line65 = Console.ReadLine();
            string[] array65 = line65.Split(' ');
            int    num65 = int.Parse(array65[0]);
            string chr65 =           array65[1];
            num65 = Sankaku2(num65, chr65);
            Console.WriteLine("");
            Console.WriteLine("次に、サイズと文字の異なる3つの三角形を表示します");
            num65 = Sankaku2(3, "@");
            num65 = Sankaku2(5, "?");
            num65 = Sankaku2(7, "*");

            Console.WriteLine("練習問題 6 - 6");
            Console.WriteLine("九九の段を一つ指定して下さい");
            string s66 = Console.ReadLine();    // 1行分の文字列を入力する
            int n66 = int.Parse(s66);          // 文字列から数値を得る
            n66 = Kuku2(n66);
            Console.WriteLine("");
            Console.WriteLine("九九表：");
            n66 = Kuku2(1);
            n66 = Kuku2(2);
            n66 = Kuku2(3);
            n66 = Kuku2(4);
            n66 = Kuku2(5);
            n66 = Kuku2(6);
            n66 = Kuku2(7);
            n66 = Kuku2(8);
            n66 = Kuku2(9);

            Console.WriteLine("練習問題 6 - 7");
            Console.WriteLine("素数を入力して下さい：");
            string s67 = Console.ReadLine();    // 1行分の文字列を入力する
            int n67 = int.Parse(s67);          // 文字列から数値を得る
            Boolean hantei;
            hantei = Sosuu2(n67);
            if (hantei == true)
            {
                Console.WriteLine(n67 + "は素数です");
            }
            else
            {
                Console.WriteLine(n67 + "は素数ではありません");
            }
            Console.WriteLine("");
            Console.WriteLine("1000未満の素数を全て表示します：");
            for (int i=0; i < 1000; i++)
            {
                hantei = Sosuu2(i);
                if (hantei == true)
                {
                    if (i % 10 == 0)
                    {
                        Console.WriteLine("{0,2} ", i);
                    }
                    else
                    {
                        Console.Write("{0,2} ", i);
                    }
                }
            }

            Console.WriteLine("練習問題 7 - 1");
            Dog girl;
            girl = new Dog();
            girl.Name = "akane";
            girl.ShowProfile();

            Console.WriteLine("練習問題 7 - 2");
            Dog boy;                ;
            boy = new Dog();
            boy.Name = "ao";
            boy.Age = 5;
            boy.ShowProfile();

            Console.WriteLine("練習問題 7 - 3");
            Dog girl2, boy2;
            girl2 = new Dog();
            girl2.Name = "akane";
            girl2.Age = 7;
            boy2 = new Dog();
            boy2.Name = "ao";
            boy2.Age = 5;
            girl2.ShowProfile();
            boy2.ShowProfile();

            Console.WriteLine("練習問題 7 - 4");
            Dog boy3;
            boy3 = new Dog("toy poodle")
            {
                Name = "TARO",
                Age = 8
            };
            boy3.ShowProfile();

            Console.WriteLine("練習問題 7 - 5");
            CoinCase MyMoney;
            MyMoney = new CoinCase();
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("コインの種類と枚数を入力して下さい："+ i + "/10回目");
                string line = Console.ReadLine();
                string[] array = line.Split(' ');
                int num751 = int.Parse(array[0]);
                int num752 = int.Parse(array[1]);
                MyMoney.AddCoins(num751, num752);
            }
            int n1= MyMoney.GetCount(1);
            int n5 = MyMoney.GetCount(5);
            int n10 = MyMoney.GetCount(10);
            int n50 = MyMoney.GetCount(50);
            int n100 = MyMoney.GetCount(100);
            int n500 = MyMoney.GetCount(500);
            int nSum = MyMoney.GetAmount();
            Console.Write("\n");
            Console.WriteLine("【枚数】1円玉：" + n1 + "、5円玉：" + n5 + "、10円玉：" + n10 + "、50円玉：" + n50 + "、100円玉：" + n100 + " 、500円玉：" + n500);
            Console.WriteLine("【合計】" + nSum);

            Console.WriteLine("練習問題 7 - 6");
            CoinCase2 MyMoney2;
            MyMoney2 = new CoinCase2();
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("コインの種類と枚数を入力して下さい：" + i + "/10回目");
                string line = Console.ReadLine();
                string[] array = line.Split(' ');
                int num761 = int.Parse(array[0]);
                int num762 = int.Parse(array[1]);
                MyMoney2.AddCoins(num761, num762);
            }
            int n1 = MyMoney2.GetAmount(1);
            int n5 = MyMoney2.GetAmount(5);
            int n10 = MyMoney2.GetAmount(10);
            int n50 = MyMoney2.GetAmount(50);
            int n100 = MyMoney2.GetAmount(100);
            int n500 = MyMoney2.GetAmount(500);
            int nSum = MyMoney2.GetCount();
            Console.Write("\n");
            Console.WriteLine("【各コインの枚数と金額】");
            Console.WriteLine("  1円玉：" + n1/1 + "枚、" + n1+ "円");
            Console.WriteLine("  5円玉：" + n5/ 5 + "枚、" + n5 + "円");
            Console.WriteLine(" 10円玉：" + n10/ 10 + "枚、" + n10 + "円");
            Console.WriteLine(" 50円玉：" + n50/ 50 + "枚、" + n50 + "円"); 
            Console.WriteLine("100円玉：" + n100/ 100 + "枚、" + n100 + "円");
            Console.WriteLine("500円玉：" + n500/ 500 + "枚、" + n500 + "円");
            Console.Write("\n");
            Console.WriteLine("【総枚数】" + nSum);
            int sSumMount = n1 + n5 + n10 + n50 + n100 + n500;
            Console.WriteLine("【総額】" + sSumMount);

            Console.WriteLine("練習問題 8 - 1");
            Cat Asuka;
            Asuka = new Cat();
            Asuka.Name = "あすか";
            Asuka.Age = 10;
            Asuka.ShowProfile();
            Asuka.Sleep();

            Console.WriteLine("練習問題 8 - 2");
            Cat2 Akane;
            Akane = new Cat2("あかね",9);
            Akane.ShowProfile();
            Akane.Sleep();

            Console.WriteLine("練習問題 8 - 3");
            Dog2 Aoi;
            Aoi = new Dog2("あおい", 8);
            Aoi.ShowProfile();
            Aoi.Run();

            Console.WriteLine("練習問題 8 - 4");
            Dog3 Inu;
            Inu = new Dog3("犬", 1);
            Inu.ShowProfile();
            Inu.Speak();
            Cat3 Neko;
            Neko = new Cat3("猫", 2);
            Neko.ShowProfile();
            Neko.Speak();

            Console.WriteLine("練習問題 8 - 5");
            Animal3[] al = new Animal3[4];
            al[0] = new Cat3("猫0", 0);
            al[1] = new Dog3("犬1", 1);
            al[2] = new Cat3("猫2", 2);
            al[3] = new Dog3("犬3", 3);
            for (int i=0; i<4; i++)
            {
                al[i].ShowProfile();
                al[i].Speak();
            }
*/

                        Console.ReadKey();
        }

        /***** 以下 クラス *******/
        class Animal3
        {
            public string Name { get; private set; }    // 名前
            public int Age { get; private set; }        // 年齢

            public Animal3(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public void ShowProfile()
            {
                Console.WriteLine(Name + "," + Age + "歳");
            }

            public virtual void Speak()
            {
                Console.WriteLine("......");
            }
        }

        class Cat3 : Animal3
        {
            public Cat3(string name, int age) : base(name, age)
            {
            }

            public override void Speak()
            {
                Console.WriteLine("ニャー");
            }
        }

        class Dog3 : Animal3
        {
            public Dog3(string name, int age) : base(name, age)
            {
            }

            public override void Speak()
            {
                Console.WriteLine("ワンワン");
            }

        }


        class Animal2
        {
            public string Name { get; private set; }    // 名前
            public int Age { get; private set; }        // 年齢

            public Animal2(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public void ShowProfile()
            {
                Console.WriteLine(Name + "," + Age + "歳");
            }
        }

        class Cat2 : Animal2
        {
            public Cat2(string name, int age) : base(name, age)
            {
            }

            public void Sleep()
            {
                Console.WriteLine("スースー");
            }
        }

        class Dog2 : Animal2
        {
            public Dog2(string name, int age) : base(name, age)
            {
            }

            public void Run()
            {
                Console.WriteLine("トコトコ");
            }
        }

        class Animal
        {
            public string Name = "";    // 名前
            public int Age = 0;         // 年齢

            public void ShowProfile()
            {
                Console.WriteLine(Name + "," + Age + "歳");
            }
        }

        class Cat : Animal
        {
            public void Sleep()
            {
                Console.WriteLine("スースー");
            }
        }

        class CoinCase2
        {
            private int Number1 = 0;    // 1円コインの枚数
            private int Number5 = 0;    // 5円コインの枚数
            private int Number10 = 0;    // 10円コインの枚数
            private int Number50 = 0;    // 50円コインの枚数
            private int Number100 = 0;    // 100円コインの枚数
            private int Number500 = 0;    // 500円コインの枚数

            public void AddCoins(int cType, int cNumber)
            {
                switch (cType)
                {
                    case 1:
                        Number1 = Number1 + 1;
                        break;
                    case 5:
                        Number5 = Number5 + 1;
                        break;
                    case 10:
                        Number10 = Number10 + 1;
                        break;
                    case 50:
                        Number50 = Number50 + 1;
                        break;
                    case 100:
                        Number100 = Number100 + 1;
                        break;
                    case 500:
                        Number500 = Number500 + 1;
                        break;
                    default:
                        break;
                }
            }

            public int GetCount()
            {
                int SumNumber = Number1 + Number5 + Number10 + Number50 + Number100 + Number500;
                return SumNumber;
            }

            public int GetAmount(int cType)
            {
                int SumAmount = 0;
                switch (cType)
                {
                    case 1:
                        SumAmount = Number1 * 1;
                        break;
                    case 5:
                        SumAmount = Number5 * 5;
                        break;
                    case 10:
                        SumAmount = Number10 * 10;
                        break;
                    case 50:
                        SumAmount = Number50 * 50;
                        break;
                    case 100:
                        SumAmount = Number100 * 100;
                        break;
                    case 500:
                        SumAmount = Number500 * 500;
                        break;
                    default:
                        break;
                }
                return SumAmount;
            }
        }

        class CoinCase
        {
            private int Number1 = 0;    // 1円コインの枚数
            private int Number5 = 0;    // 5円コインの枚数
            private int Number10 = 0;    // 10円コインの枚数
            private int Number50 = 0;    // 50円コインの枚数
            private int Number100 = 0;    // 100円コインの枚数
            private int Number500 = 0;    // 500円コインの枚数
            public void AddCoins(int cType, int cNumber)
            {
                switch (cType)
                {
                    case 1:
                        Number1 = Number1 + 1;
                        break;
                    case 5:
                        Number5 = Number5 + 1;
                        break;
                    case 10:
                        Number10 = Number10 + 1;
                        break;
                    case 50:
                        Number50 = Number50 + 1;
                        break;
                    case 100:
                        Number100 = Number100 + 1;
                        break;
                    case 500:
                        Number500 = Number500 + 1;
                        break;
                    default:
                        break;
                }
             }
            public int GetCount(int cType)
            {
                switch (cType)
                {
                    case 1:
                        return Number1;
                    case 5:
                        return Number5;
                    case 10:
                        return Number10;
                    case 50:
                        return Number50;
                    case 100:
                        return Number100;
                    case 500:
                        return Number500;
                    default:
                        return 0;
                }
            }
            public int GetAmount()
            {
                int nAmount = (Number1 * 1) + (Number5 * 5) + (Number10 * 10) + (Number50 * 50) + (Number100 * 100) + (Number500 * 500);
                return nAmount;
            }
         }


        class Dog
        {
            private string mName = "";    // 名前
            private int mAge = 0;    // 年齢
            private string mType = "";    // 種類

            public string Name
            {
                get { return mName; }
                set { mName = value; }
            }

            public int Age
            {
                get { return mAge; }
                set { mAge = value; }
            }

            public Dog(string Type)
            {
                mType = Type;
            }

            public void ShowProfile()
            {
                Console.WriteLine(mName);
                Console.WriteLine(mAge);
                Console.WriteLine(mType);
            }
        }

        /***** 以下 メソッド *******/
        public static Boolean Sosuu2(int a)
        {
            if (a == 2)
            {
                return true;
            }

            if (a < 2 || a % 2 == 0)
            {
                return false;
            }

            double sqrtNum = Math.Sqrt(a);
            for (int i = 3; i <= sqrtNum; i += 2)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static int Nijyo(int a)
        {
            return a * a;
        }

        public static int Heikin(int a, int b)
        {
            return (a + b) / 2;
        }

        public static int Max(int a, int b, int c)
        {
            if (a > b && a > c) 
                return a;

            if (b > a && b > c)
                return b;

            if (c > a && c > b)
                return c;

            return 0;
        }

        public static int Sankaku(int a)
        { 
            for (int i = 1; i <= a; i++)
            { 
                string rst = new string('$', i);
                Console.WriteLine(rst);
            }
            return a;
        }

        public static int Sankaku2(int a, string b)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= a; i++)
            {
                sb.Append(b);
                string result = sb.ToString();
                Console.WriteLine(result);
            }
            return a;
        }

        public static int Kuku2(int a)
        {
            int[,] Kuku_2 = new int[10, 10];
            for (int i = 1; i <= 9; i++)
            {
                for (int j = a; j <= a; j++)
                {
                    Kuku_2[i, j] = j * i;
                    if (i == 9)
                    {
//                        Console.Write(i + " x " + j + " =");
                        Console.WriteLine(" {0,2}", Kuku_2[i, j]);
                    }
                    else
                    {
//                        Console.Write(i + " x " + j + " =");
                        Console.Write(" {0,2}   ", Kuku_2[i, j]);
                    }
                }
            }
            return a;
        }

        public static int DivRem(int a, int b, out int result)
        {
            result = a % b;
            return a / b;
        }

        public static long Factorial(int n)
        {
            if (n == 0)
                return 1L;
            return n * Factorial(n - 1);
        }

        /// <summary>
        /// 文字列からの部分文字列の抽出を右から行います
        /// </summary>
        /// <param name="target">対象の文字列</param>
        /// <param name="length">部分文字列の長さ</param>
        /// <returns>文字列の右から抽出された部分文字列</returns>
        public static string SubstringRight(string target, int length)
        {
            return target.Substring(target.Length - length, length);
        }
    }
}
