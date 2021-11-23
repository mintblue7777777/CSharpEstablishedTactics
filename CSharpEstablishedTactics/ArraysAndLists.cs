using CSharpEstablishedTactics.components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEstablishedTactics
{
    /// <summary>
    /// 配列とList<T>の操作
    /// </summary>
    internal static class ArraysAndLists
    {
        internal static void SettingTheElement()
        {
            //連続した値をセット
            //List<int> numbers = new List<int>();
            //for (int i = 0; i < 20; i++)
            //{
            //    numbers.Add(i+1);
            //}
            var array = Enumerable.Range(1, 20).ToArray();
        }

        internal static void CollectionAggregation()
        {
            //平均
            List<int> list = new List<int>() {9,4,81,6,7,7,5,7,6,8,7,46,0,4, };
            //int sum = 0;
            //foreach (var n in list)
            //{
            //    sum += n;
            //}
            //double average = (double)sum / list.Count;
            var agerage = list.Average();
            var agerage2 = Book.Books().Average(x => x.Price);

            //合計
            var sum = list.Sum();
            var totalPrice = Book.Books().Sum(x => x.Price);
        }

        internal static void MaximumAndMinimumValues()
        {
            //最小
            List<int> numbers = new List<int>() { 1, 2, 3, -4, 0, 2, 6, 5, -8, 3, 0, 2, 96, };
            //int min = int.MaxValue;
            //foreach (var number in numbers)
            //{
            //    if (number <= 0)
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        min = number;
            //    }
            //}
            var min = numbers.Where(x => x > 0).Min();

            //条件一致カウント
            //var count = numbers.Where(x => x == 0).Count();
            var count = numbers.Count(x => x == 0);
            var count2 = Book.Books().Count(x => x.Title.Contains("物語"));
        }

        internal static void DeterminingCollection()
        {
            //すべての要素が条件を満たしているか
            List<int> numbers = new List<int>() { 1, 2, 3, 0, 2, 6, 5, 3, 0, 2, 96, };
            //bool isAllPositive = true;
            //foreach (var number in numbers)
            //{
            //    if (number < 0)
            //    {
            //        isAllPositive = false;
            //        break;
            //    }
            //}
            bool isAllPositive = numbers.All(n => n > -1);
            bool is1000OrLess = Book.Books().All(x => x.Price >= 1000);

            //２つのコレクションが等しいか
            List<int> numbers2 = new List<int>() { 1, 2, 3, 0, 2, 6, 5, 3, 0, 2, 96, };
            //bool equal = true;
            //if (numbers.Count != numbers2.Count)
            //{
            //    equal = false;
            //}
            //else
            //{
            //    for (int i = 0; i < numbers.Count; i++)
            //    {
            //        if (numbers[1] != numbers2[i])
            //        {
            //            equal = false;
            //            break;
            //        }
            //    }
            //}
            bool equal = numbers.SequenceEqual(numbers2);
        }
        internal static void RetrievingSingleElement()
        {
            //条件に一致する最初のインデックス
            var numbers = new List<int>() { 1, 2, 3, 0, 2, 6, 5, 3, 0, -2, 96, };
            //var item = numbers.Select((n, ix) => new { Value = n, Index = ix }).FirstOrDefault(o => o.Value < 0);
            //var index = item == null ? -1 : item.Index;
            //Console.WriteLine(index);
            var index = numbers.FindIndex(n => n < 0);
        }

        internal static void RetrievingMultiElement()
        {
            //受験を満たす要素をn個取り出す
            var numbers = new List<int>() { 1, 2, 3, 0, 2, 6, 5, 3, 0, -2, 96, };
            //var results = new List<int>();
            //foreach (var number in numbers)
            //{
            //    if (number > 0)
            //    {
            //        results.Add(number);
            //        if (results.Count() >= 5)
            //            break;
            //    }
            //}
            var results = numbers.Where(n => n > 0).Take(5);
            var selected = Book.Books().TakeWhile(x => x.Price < 600);
            foreach (var book in selected)
                Console.WriteLine("{0}{1}", book.Title, book.Price);
        }
        
        internal static void OtherProcessing()
        {
            //コレクションから別のコレクションを生成する
            List<string> words = new List<string>() {
            "Microsoft",
            "Apple",
            "Google",
            "Facebook",
            "Amazon",
            "Oracle,"
            };
            //List<string> lowers = new List<string>();
            //foreach(string name in words)
            //{
            //    lowers.Add(name.ToLower());
            //}
            var lowers = words.Select(s => s.ToLower()).ToArray();
            var title = Book.Books().Select(x => x.Title);
        }



    }
}
