//1) Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın.


//int n = 8;

//if (n%3==0 && n%7==0)
//{
//    Console.WriteLine("Bölünür");
//}
//else
//{
//    Console.WriteLine("Bölünmür");
//}


//2) n və m ədədləri verilir. Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.

//int n = 6;
//int m = 18;
//int sum = 0;

//if (n%2==0 && m%2==0)
//{
//    sum = n + m;
//}

//Console.WriteLine(sum);

//3) Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin.

//int n = 6;
//int m = 13;

//int sum = 0;

//for (int i = n; i < m; i++)
//{
//    if (i%2!=0)
//    {
//        sum += i;
//    }
//}

//Console.WriteLine(sum);


//4) Verilmish arrayin icindeki tek ededlerin cemini tapin.

//int[] arrays = { 2, 3,7,15,65,63,78,46,5,9 };
//int sum = 0;

//for (int i = 0; i < arrays.Length; i++)
//{
//    if (arrays[i]%2!=0)
//    {
//        sum += arrays[i];
//    }

//}

//Console.WriteLine(sum);

//5) Verilmish arrayin icindeki cut ededlerin sayini tapin.

//int[] arrays = { 2, 3,7,15,65,63,78,46,5,9 };

//int count = 0;

//for (int i = 0; i < arrays.Length; i++)
//{
//    if (arrays[i]%2==0)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);

//6) Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapin.

//int n = 13;
//int m = 24;
//int count = 0;

//for (int i = n; i < m; i++)
//{
//    if (i%2!=0)
//    {
//        count++;
//    }
//}

//Console.WriteLine(count);

//7) Verilmis n ve m (n<m) ededleri arasindaki cut ededlerin cemini tapin.

//int n = 6;
//int m = 18;
//int sum = 0;

//for (int i = n; i < m; i++)
//{
//    if (i%2==0)
//    {
//        sum += i;
//    }
//}

//Console.WriteLine(sum);


//8) Verilmis n ve m (n<m) ededleri arasindaki cut ededlerin sayini tapin.

//int n = 8;
//int m = 23;
//int count = 0;

//for (int i = n; i < m; i++)
//{
//    if (i%2==0)
//    {
//        count++;
//    }

//}
//Console.WriteLine(count);



//9) Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.

//int n = 68;
//int count = 0;

//if (n!=1)
//{
//    for (int i = 2; i <= n; i++)
//    {
//        if (n%i==0)
//        {
//            count++;
//        }
//    }

//}

//if (count>2)
//{
//    Console.WriteLine("Mürəkkəb ədəddir");
//}
//else
//{
//    Console.WriteLine("Sadə ədəddir");
//}



//Dersde Yazdiqlarimiz


//int age = 30;

//int n = 10;
//int m = 100;

//int sum = 0;

// sum = n + m;

//Console.WriteLine(sum);

//bool isMarried = true;

//if (isMarried==true)
//{
//    Console.WriteLine("Yes");
//}
//else
//{
//    Console.WriteLine("No");
//}

//int[] arr = {1,2,3,4,5 };

//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine(i);
//}

//for (int i = 0; i < arr.Length; i++)
//{
//    Console.WriteLine(arr[i]);
//}

//int a = 1;
//int b = 100;


//for (int i = a; i <= b; i+=2)
//{
//    Console.WriteLine(i);
//}

//int a = 1;
//int b = 100;

//for (int i = a; i <= b; i++)
//{
//    if (i%2==0)
//    {
//        Console.WriteLine(i);
//    }
//}

//int a = 1;
//int b = 100;
//int sum = 0;

//for (int i = a; i <=b; i++)
//{
//    if (i%2==0)
//    {
//        sum += i;
//    }
//}

//Console.WriteLine(sum);

string[] arrays = { "salam", "Hello", "Fatya", "Hey", "count", "salam", "Salam" };

int count = 0;

for (int i = 0; i < arrays.Length; i++)
{
    if (arrays[i] == "salam")
    {
        count++;
    }
}

Console.WriteLine(count);

