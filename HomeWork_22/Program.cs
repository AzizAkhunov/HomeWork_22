

/*                    //Ex_1
List<int> numbers = new List<int> { 1, 2, 3 , 4 , 5 , 6 , 7 , 8};

var evenNumbers = numbers
    .Select(x => x)
    .Where(x => x % 2 == 0).ToList();

foreach(var number in evenNumbers)
{
    Console.WriteLine(number);
}
*/

/*                        //Ex_2
List<int> numbers = new List<int> { 0,-1, 2, 3, -4, 5, 6, 7, -8 };

var evenNumbers = numbers
    .Select(x => x)
    .Where(x => x != 0)
    .Where(x => x > 0);

foreach (var number in evenNumbers)
{
    Console.WriteLine(number);
}
*/

/*                   //Ex_3
List<int> numbers = new List<int> {1, 2, 3, 4, 5, 6, 7, 8 , 9};

var evenNumbers = numbers
    .Select(x => x)
    .Where(x => x * x > 20);

foreach (var number in evenNumbers)
{
    Console.WriteLine($"Number = {number}, SqrNo = {number * number}");
}
*/

/*                //Ex_4
int[] numbers = { 5, 5, 9, 1, 5, 9 };

Console.Write("Enter a number: ");
int queryNumber = Convert.ToInt32(Console.ReadLine());

var frequencyQuery = numbers
    .GroupBy(n => n)
    .Select(g => new { Number = g.Key, Frequency = g.Count() })
    .Where(x => x.Number == queryNumber)
    .FirstOrDefault();

if (frequencyQuery != null)
{
    Console.WriteLine("The number and the Frequency are:");
    Console.WriteLine($"Number {frequencyQuery.Number} appears {frequencyQuery.Frequency} times")  ;
}
else
{
    Console.WriteLine("Number {0} does not appear in the array.", queryNumber);
}
*/

/*                //Ex_5

Console.Write("Input the string: ");
string inputString = Console.ReadLine();

var characterFrequencies = inputString
    .GroupBy(c => c)
    .Select(g => new { Character = g.Key, Frequency = g.Count() });

Console.WriteLine("The frequency of the characters are:");
foreach (var cf in characterFrequencies)
{
    Console.WriteLine("Character {0}: {1} times", cf.Character, cf.Frequency);
}
*/

/*                //Ex_6

string[] dayWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

var days = from WeekDay in dayWeek
           select WeekDay;
foreach (var WeekDay in days)
{
    Console.WriteLine(WeekDay);
}
Console.WriteLine();
*/

/*                    //Ex_7

int[] nums = new int[] { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };

var m = from x in nums
        group x by x into y
        select y;
Console.Write("Number" + "\t" + "Number*Frequency" + "\t" + "Frequency" + "\n");
Console.Write("------------------------------------------------\n");

foreach (var arrEle in m)
{
    Console.WriteLine(arrEle.Key + "\t" + arrEle.Sum() + "\t\t\t" + arrEle.Count());
}
*/

/*                //Ex_8

var cities  = new List<string>() {"Tashkent","Kokand","Fergana","Samarqand", "California","Palastine"};

var startWith = Console.ReadLine();
var endWith = Console.ReadLine();

var result = cities
    .Select(x => x)
    .Where(x => x.StartsWith(startWith))
    .Where(x => x.EndsWith(endWith));

foreach (var item in result)
{
    Console.WriteLine(item);
}
*/

/* //Ex_9

var numbers = new List<int>() { 1,15,85,145,78,558,456,89,88,556};

var number = Convert.ToInt32(Console.ReadLine());

var result = numbers.Select(x => x)
    .Where(x => x > number);

foreach (var item in result)
{
    Console.WriteLine(item);
}
*/

/*            //Ex_10

var soni = Convert.ToInt32(Console.ReadLine());

var numbers = new List<int>();

int n;
for (var i = 0; i < soni; i++)
{
    Console.Write("Member {0} : ", i);
    n = Convert.ToInt32(Console.ReadLine());
    numbers.Add(n);
}

var trueNumber = Convert.ToInt32(Console.ReadLine());

var result = numbers.Select(x => x)
    .Where(x => x > trueNumber);

Console.WriteLine("Kottaroq raqamlar");
foreach (var number in result)
{
    Console.WriteLine(number);
}
*/

/* //Ex_11

var numbers = new List<int>() { 51,6,555,8,5,95,5,6,5456};

var result = numbers.OrderByDescending(x => x).ToList();

for(int i = 0; i < 3; i++)
{
        Console.WriteLine(result[i]);
}
*/

/*            //Ex_12

string strNew;

Console.Write("Input the string : ");
strNew = Console.ReadLine();

var ucWord = WordFilter(strNew);
Console.Write("\nThe UPPER CASE words are :\n ");
foreach (string strRet in ucWord)
{
    Console.WriteLine(strRet);
}

IEnumerable<string> WordFilter(string mystr)
{
    var upWord = mystr.Split(' ')
                        .Where(x => String.Equals(x, x.ToUpper(),
                        StringComparison.Ordinal));

    return upWord;
}
*/

/*            //Ex_13

string[] arr1;
int n, i;

n = Convert.ToInt32(Console.ReadLine());
arr1 = new string[n];
Console.Write("Input {0} strings for the array  :\n", n);
for (i = 0; i < n; i++)
{
    Console.Write("Element[{0}] : ", i);
    arr1[i] = Console.ReadLine();
}

string newstring = String.Join(", ", arr1
              .Select(s => s.ToString())
              .ToArray());
Console.WriteLine(newstring);
Console.Write("\n");
Console.ReadLine();
*/

/*            //Ex_14

using HomeWork_22;

Students e = new Students();

int grPointRank = Convert.ToInt32(Console.ReadLine());
Console.Write("\n");
var stulist = e.GtStuRec();
var students = (from stuMast in stulist
                group stuMast by stuMast.GrPoint into g
                orderby g.Key descending
                select new
                {
                    StuRecord = g.ToList()
                }).ToList();

students[grPointRank - 1].StuRecord
    .ForEach(i => Console.WriteLine(" Id : {0},  Name : {1},  achieved Point : {2}", i.StuId, i.StuName, i.GrPoint));
*/

/*            //Ex_15

string[] arr1 = { "aaa.frx", "bbb.TXT", "xyz.dbf", "abc.pdf", "aaaa.PDF", "xyz.frt", "abc.xml", "ccc.txt", "zzz.txt" };

var fGrp = arr1.Select(file => Path.GetExtension(file).TrimStart('.').ToLower())
                     .GroupBy(z => z, (fExt, extCtr) => new
                     {
                         Extension = fExt,
                         Count = extCtr.Count()
                     });

foreach (var m in fGrp)
    Console.WriteLine("{0} File(s) with {1} Extension ", m.Count, m.Extension);
Console.ReadLine();
*/

/*            //Ex_16

string[] dirfiles = Directory.GetFiles("/home/w3r/abcd/");

var avgFsize = dirfiles.Select(file => new FileInfo(file).Length).Average();
avgFsize = Math.Round(avgFsize / 10, 1);
Console.WriteLine("The Average file size is {0} MB", avgFsize);
*/

/*            //Ex_17

var listOfString = new List<string>() { "m","n","o","p","q"};
var _result1 = from y in listOfString
               select y;
Console.Write("Here is the list of items : \n");
foreach (var tchar in _result1)
{
    Console.WriteLine("Char: {0} ", tchar);
}

string newstr = listOfString.FirstOrDefault(en => en == "o");
listOfString.Remove(newstr);


var _result = from z in listOfString
              select z;
Console.Write("\nHere is the list after removing the item 'o' from the list : \n");
foreach (var rChar in _result)
{
    Console.WriteLine("Char: {0} ", rChar);
}
*/

/*                //Ex_18

var listOfString = new List<string>() { "m", "n", "o", "p", "q" };

var _result1 = from y in listOfString
               select y;
Console.Write("Here is the list of items : \n");
foreach (var tchar in _result1)
{
    Console.WriteLine("Char: {0} ", tchar);
}

listOfString.Remove(listOfString.FirstOrDefault(en => en == "p"));


var _result = from z in listOfString
              select z;
Console.Write("\nHere is the list after removing the item 'p' from the list : \n");
foreach (var rChar in _result)
{
    Console.WriteLine("Char: {0} ", rChar);
}
*/

/*                  //Ex_19

var listOfString = new List<string>() { "m", "n", "o", "p", "q" };

var _result1 = from y in listOfString
               select y;
Console.Write("Here is the list of items : \n");
foreach (var tchar in _result1)
{
    Console.WriteLine("Char: {0} ", tchar);
}

listOfString.RemoveAll(en => en == "q");


var _result = from z in listOfString
              select z;
Console.Write("\nHere is the list after removing item 'q' from the list : \n");
foreach (var rChar in _result)
{
    Console.WriteLine("Char: {0} ", rChar);
}
*/

/*                      //Ex_20

var listOfString = new List<string>() { "m", "n", "o", "p", "q" };

var _result1 = from y in listOfString
               select y;
Console.Write("Here is the list of items : \n");
foreach (var tchar in _result1)
{
    Console.WriteLine("Char: {0} ", tchar);
}

listOfString.RemoveAt(3);

var _result = from z in listOfString
              select z;
Console.Write("\nHere is the list after removing item index 3 from the list : \n");
foreach (var rChar in _result)
{
    Console.WriteLine("Char: {0} ", rChar);
}
*/

/*                //Ex_21

var listOfString = new List<string>() { "m", "n", "o", "p", "q" };

var _result1 = from y in listOfString
               select y;
Console.Write("Here is the list of items : \n");
foreach (var tchar in _result1)
{
    Console.WriteLine("Char: {0} ", tchar);
}

listOfString.RemoveRange(1, 3);

var _result = from z in listOfString
              select z;
Console.Write("\nHere is the list after removing the three items starting from the item index 1 from the list : \n");
foreach (var rChar in _result)
{
    Console.WriteLine("Char: {0} ", rChar);
}
*/

/*                  //Ex_22

string[] arr1;
int n, i, ctr;

Console.Write("Input number of strings to  store in the array :");
n = Convert.ToInt32(Console.ReadLine());
arr1 = new string[n];
Console.Write("\nInput {0} strings for the array  :\n", n);
for (i = 0; i < n; i++)
{
    Console.Write("Element[{0}] : ", i);
    arr1[i] = Console.ReadLine();
}

Console.Write("\nInput the minimum length of the item you want to find : ");
ctr = Convert.ToInt32(Console.ReadLine());

IEnumerable<string> objNew = from m in arr1
                             where m.Length >= ctr
                             orderby m
                             select m;
Console.Write("\nThe items of minimum {0} characters are : \n", ctr);
foreach (string z in objNew)
    Console.WriteLine("Item: {0}", z);
*/

/*              //Ex_23

char[] charset1 = { 'X', 'Y', 'Z' };
int[] numset1 = { 1, 2, 3, 4 };

var cartesianProduct = from letterList in charset1
                       from numberList in numset1
                       select new { letterList, numberList };

Console.Write("The cartesian product are : \n");
foreach (var productItem in cartesianProduct)
{
    Console.WriteLine(productItem);
}
*/

/*              //Ex_24

char[] charset1 = { 'X', 'Y', 'Z' };
int[] numset1 = { 1, 2, 3 };
string[] colorset1 = { "Green", "Orange" };

var cartesianProduct = from letter in charset1
                       from number in numset1
                       from colour in colorset1
                       select new { letter, number, colour };

Console.Write("The Cartesian Product are : \n");
foreach (var ProductList in cartesianProduct)
{
    Console.WriteLine(ProductList);
}
*/

/*                  //Ex_25

using HomeWork_22;

List<Item_mast> itemlist = new List<Item_mast>
            {
           new Item_mast { ItemId = 1, ItemDes = "Biscuit  " },
           new Item_mast { ItemId = 2, ItemDes = "Chocolate" },
           new Item_mast { ItemId = 3, ItemDes = "Butter   " },
           new Item_mast { ItemId = 4, ItemDes = "Brade    " },
           new Item_mast { ItemId = 5, ItemDes = "Honey    " }
            };

List<Purchase> purchlist = new List<Purchase>
            {
           new Purchase { InvNo=100, ItemId = 3,  PurQty = 800 },
           new Purchase { InvNo=101, ItemId = 2,  PurQty = 650 },
           new Purchase { InvNo=102, ItemId = 3,  PurQty = 900 },
           new Purchase { InvNo=103, ItemId = 4,  PurQty = 700 },
           new Purchase { InvNo=104, ItemId = 3,  PurQty = 900 },
           new Purchase { InvNo=105, ItemId = 4,  PurQty = 650 },
           new Purchase { InvNo=106, ItemId = 1,  PurQty = 458 }
            };

foreach (var item in itemlist)
{
    Console.WriteLine(
    "Item Id: {0}, Description: {1}",
    item.ItemId,
    item.ItemDes);
}

Console.Write("\nHere is the Purchase List : ");
Console.Write("\n--------------------------\n");

foreach (var item in purchlist)
{
    Console.WriteLine(
    "Invoice No: {0}, Item Id : {1},  Quantity : {2}",
    item.InvNo,
    item.ItemId,
    item.PurQty);
}

Console.Write("\nHere is the list after joining  : \n\n");

var innerJoin = from e in itemlist
                join d in purchlist on e.ItemId equals d.ItemId
                select new
                {
                    itid = e.ItemId,
                    itdes = e.ItemDes,
                    prqty = d.PurQty
                };
Console.WriteLine("Item ID\t\tItem Name\tPurchase Quantity");
Console.WriteLine("-------------------------------------------------------");
foreach (var data in innerJoin)
{
    Console.WriteLine(data.itid + "\t\t" + data.itdes + "\t\t" + data.prqty);
}
*/

/*                  //Ex_26

using HomeWork_22;

List<Item_mast> itemlist = new List<Item_mast>
            {
           new Item_mast { ItemId = 1, ItemDes = "Biscuit  " },
           new Item_mast { ItemId = 2, ItemDes = "Chocolate" },
           new Item_mast { ItemId = 3, ItemDes = "Butter   " },
           new Item_mast { ItemId = 4, ItemDes = "Brade    " },
           new Item_mast { ItemId = 5, ItemDes = "Honey    " }
            };

List<Purchase> purchlist = new List<Purchase>
            {
           new Purchase { InvNo=100, ItemId = 3,  PurQty = 800 },
           new Purchase { InvNo=101, ItemId = 2,  PurQty = 650 },
           new Purchase { InvNo=102, ItemId = 3,  PurQty = 900 },
           new Purchase { InvNo=103, ItemId = 4,  PurQty = 700 },
           new Purchase { InvNo=104, ItemId = 3,  PurQty = 900 },
           new Purchase { InvNo=105, ItemId = 4,  PurQty = 650 },
           new Purchase { InvNo=106, ItemId = 1,  PurQty = 458 }
            };

foreach (var item in itemlist)
{
    Console.WriteLine(
    "Item Id: {0}, Description: {1}",
    item.ItemId,
    item.ItemDes);
}

Console.Write("\nHere is the Purchase List : ");

foreach (var item in purchlist)
{
    Console.WriteLine(
    "Invoice No: {0}, Item Id : {1},  Quantity : {2}",
    item.InvNo,
    item.ItemId,
    item.PurQty);
}

var leftOuterJoin = from itm in itemlist
                    join prch in purchlist
                    on itm.ItemId equals prch.ItemId
                    into a
                    from b in a.DefaultIfEmpty(new Purchase())
                    select new
                    {
                        itid = itm.ItemId,
                        itdes = itm.ItemDes,
                        prqty = b.PurQty
                    };
foreach (var data in leftOuterJoin)
{
    Console.WriteLine(data.itid + "\t\t" + data.itdes + "\t\t" + data.prqty);
}
*/

/*              //Ex_27


using HomeWork_22;

List<Item_mast> itemlist = new List<Item_mast>
            {
           new Item_mast { ItemId = 1, ItemDes = "Biscuit  " },
           new Item_mast { ItemId = 2, ItemDes = "Chocolate" },
           new Item_mast { ItemId = 3, ItemDes = "Butter   " },
           new Item_mast { ItemId = 4, ItemDes = "Brade    " },
           new Item_mast { ItemId = 5, ItemDes = "Honey    " }
            };

List<Purchase> purchlist = new List<Purchase>
            {
           new Purchase { InvNo=100, ItemId = 3,  PurQty = 800 },
           new Purchase { InvNo=101, ItemId = 5,  PurQty = 650 },
           new Purchase { InvNo=102, ItemId = 3,  PurQty = 900 },
           new Purchase { InvNo=103, ItemId = 4,  PurQty = 700 },
           new Purchase { InvNo=104, ItemId = 3,  PurQty = 900 },
           new Purchase { InvNo=105, ItemId = 4,  PurQty = 650 },
           new Purchase { InvNo=106, ItemId = 1,  PurQty = 458 }
            };

foreach (var item in itemlist)
{
    Console.WriteLine(
    "Item Id: {0}, Description: {1}",
    item.ItemId,
    item.ItemDes);
}

Console.Write("\nHere is the Purchase List : ");

foreach (var item in purchlist)
{
    Console.WriteLine(
    "Invoice No: {0}, Item Id : {1},  Quantity : {2}",
    item.InvNo,
    item.ItemId,
    item.PurQty);
}

var rightOuterJoin = from p in purchlist
                     join i in itemlist
                     on p.ItemId equals i.ItemId
                     into a
                     from b in a.DefaultIfEmpty()
                     select new
                     {
                         itid = b.ItemId,
                         itdes = b.ItemDes,
                         prqty = p.PurQty
                     };
foreach (var data in rightOuterJoin)
{
    Console.WriteLine(data.itid + "\t\t" + data.itdes + "\t\t" + data.prqty);
}
*/

/*                      //Ex_28

string[] cities =
           {
                "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS"
            };

IEnumerable<string> cityOrder =
            cities.OrderBy(str => str.Length)
                            .ThenBy(str => str);
foreach (string city in cityOrder)
    Console.WriteLine(city);
*/

/*                      //Ex_29

string[] cities =
            {
                "ROME","LONDON","NAIROBI","CALIFORNIA",
                "ZURICH","NEW DELHI","AMSTERDAM",
                "ABU DHABI", "PARIS","NEW YORK"
            };

var citySplit = from i in Enumerable.Range(0, cities.Length)
                group cities[i] by i / 3;

foreach (var city in citySplit)
    cityView(string.Join(";  ", city.ToArray()));

void cityView(string cityMetro)
{
    Console.WriteLine(cityMetro);
    Console.WriteLine("-- here is a group of cities --\n");
}

*/

/*                  //Ex_30

using HomeWork_22;

var itemlist = (from c in Item_Mas.GetItemMast()
                select c.ItemDes)
                    .Distinct()
                    .OrderBy(x => x);

foreach (var item in itemlist)
    Console.WriteLine(item);
Console.ReadLine();
*/