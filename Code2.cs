

//表面上，这两段代码没任何关系。但假如Do1刚好执行完lock(str1)准备执行lock(stra)而另一线程
//Do2刚好执行完lock(strB)正准备执行lock(str2)，那么这两个线程将永远等待对方造成线程死锁。

static string str1 = "";
static string strA = "good";
void Do1()
{
    lock (str1)
    {
        lock (strA)
        {
            System.Threading.Thread.Sleep(1000 * 10);
        }
    }
}

static string str2 = "";
static string strB = "good";
void Do2()
{
    lock (strB)
    {
        lock (str2)
        {
            System.Threading.Thread.Sleep(1000 * 10);
        }
    }
}
