using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main (string[] args)
        {
            int result = 0;
            int result2 = 0;

            for (int i = 1; i <= 1000; i++)
            {
                result += i;
            }

            result2 = (1 + 1000) * (1000 / 2);


            Console.WriteLine (result);
            Console.WriteLine (result2);
            Calc calc = new Calc ();
            Calc2 calc2 = new Calc2 ();
            Console.WriteLine (calc.test ().ToString ());
            Console.WriteLine (calc2.test ().ToString ());
        }
    }

    public class Calc
    {
	　　public int test ()
        {
            bool result = true;
            int calcresult = 0;

            if (testmethod ())
            {
                if (result)
                {
                    for (int i = 0; i < 1000; i++)
                    {
                        if (i >= 10)
                        {
                            calcresult += i;
                        }
                        else
                        {
                            //処理なし
                        }
                    }
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
            return calcresult;
        }

        public bool testmethod ()
        {
            return true;
        }
    }

    public class Calc2
    {
        public int test ()
        {
            bool result = true;
            int calcresult = 0;

            if (testmethod ())
            {
                //処理続行	
            }
            else
            {
                return 0;
            }

            if (result)
            {
                //処理続行
            }
            else
            {
                return 0;
            }

            for (int i = 0; i < 1000; i++)
            {
                if (i >= 10)
                {
                    calcresult += i;
                }
                else
                {
                    //処理なし
                }
            }
            return calcresult;
        }

        public bool testmethod ()
        {
            return true;
        }
    }

}
