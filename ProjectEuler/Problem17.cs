using System;


namespace ProjectEuler
{
    class Problem17
    {/// <summary>
     /// If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.
     /// If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?
     /// NOTE: Do not count spaces or hyphens. For example, 342 (three hundred and forty-two) contains 23 letters and 115 (one hundred and fifteen) 
     /// contains 20 letters. The use of "and" when writing out numbers is in compliance with British usage.
     /// </summary>
        static void Main(string[] args)
        {
            int answer = 0;
            for (int number = 1; number <= 1000; number++)
            {
                string letters = "";

                if (number >= 100)
                {
                    //if (number % 100 >= 20 || number % 100 < 10)
                    //{
                    // 100s & thousands
                    int test = (int)Math.Floor(number / 100.0);
                    switch (test)
                    {

                        case 1:
                            letters += "onehundred";
                            break;
                        case 2:
                            letters += "twohundred";
                            break;
                        case 3:
                            letters += "threehundred";
                            break;
                        case 4:
                            letters += "fourhundred";
                            break;
                        case 5:
                            letters += "fivehundred";
                            break;
                        case 6:
                            letters += "sixhundred";
                            break;
                        case 7:
                            letters += "sevenhundred";
                            break;
                        case 8:
                            letters += "eighthundred";
                            break;
                        case 9:
                            letters += "ninehundred";
                            break;
                        case 10:
                            letters += "onethousand";
                            break;
                    }

                    if (number - (test * 100) != 0)
                        letters += "and";
                    //}

                }
                int result = number % 100;
                if (result < 20 && result >= 10)
                {
                    switch (result)
                    {
                        case 10:
                            letters += "ten";
                            break;
                        case 11:
                            letters += "eleven";
                            break;
                        case 12:
                            letters += "twelve";
                            break;
                        case 13:
                            letters += "thirteen";
                            break;
                        case 14:
                            letters += "fourteen";
                            break;
                        case 15:
                            letters += "fifteen";
                            break;
                        case 16:
                            letters += "sixteen";
                            break;
                        case 17:
                            letters += "seventeen";
                            break;
                        case 18:
                            letters += "eighteen";
                            break;
                        case 19:
                            letters += "nineteen";
                            break;

                    }
                }
                else
                {
                    int tentest = (int)Math.Floor(number / 10.0);
                    if (number > 119)
                    {
                        tentest %= 10;
                    }
                    switch (tentest)
                    {
                        case 1:
                            throw new Exception("WTF");
                        case 2:
                            letters += "twenty";
                            break;
                        case 3:
                            letters += "thirty";
                            break;
                        case 4:
                            letters += "forty";
                            break;
                        case 5:
                            letters += "fifty";
                            break;
                        case 6:
                            letters += "sixty";
                            break;
                        case 7:
                            letters += "seventy";
                            break;
                        case 8:
                            letters += "eighty";
                            break;
                        case 9:
                            letters += "ninety";
                            break;


                    }
                    switch (number % 10)
                    {
                        case 1:
                            letters += "one";
                            break;
                        case 2:
                            letters += "two";
                            break;
                        case 3:
                            letters += "three";
                            break;
                        case 4:
                            letters += "four";
                            break;
                        case 5:
                            letters += "five";
                            break;
                        case 6:
                            letters += "six";
                            break;
                        case 7:
                            letters += "seven";
                            break;
                        case 8:
                            letters += "eight";
                            break;
                        case 9:
                            letters += "nine";
                            break;

                    }
                }
                // count the letters
                answer += letters.Length;


            }
            Console.WriteLine(answer);
            Console.ReadKey();
        }
    }
}