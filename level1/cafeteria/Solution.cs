using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

[TestClass]
public class Solution
{
    long getMaxAdditionalDinersCount(long N, long K, int M, long[] S)
    {
        Debug.Assert(N > 0);
        Debug.Assert(K > 0);
        Debug.Assert(K <= N);
        Debug.Assert(M > 0);
        Debug.Assert(M <= N);
        Debug.Assert(M == S.Length);

        Array.Sort(S);

        long s = S[0] - 1;
        long e = s / (K + 1);
        for (int i = 1; i < M; ++i)
        {
            s = S[i] - 1;
            long p = S[i - 1] - 1;
            // this is wrong ....
            long v = (s - p - 1) / ((K * 2) + 1);
            e += v;
        }

        s = S[M - 1] - 1;
        long m = (N - 1 - s) / (K + 1);
        e += m;

        return e;
    }

    [TestMethod]
    public void TestGetMaxAdditionalDinersCount()
    {
        Assert.AreEqual(3, getMaxAdditionalDinersCount(10, 1, 2, [2, 6]));
        Assert.AreEqual(1, getMaxAdditionalDinersCount(15, 2, 3, [11, 6, 14]));
    }

    [TestMethod]
    public void TestGetMaxAdditionalDinersCountEdge()
    {
        /*
        1 2 3 4 5 6 7 8 9 10
        *   x   x   x     *
        */

        Assert.AreEqual(0, getMaxAdditionalDinersCount(1, 1, 1, [1]));
        Assert.AreEqual(4, getMaxAdditionalDinersCount(10, 1, 1, [1]));
        Assert.AreEqual(4, getMaxAdditionalDinersCount(10, 1, 1, [10]));
        Assert.AreEqual(4, getMaxAdditionalDinersCount(10, 1, 1, [5]));
        Assert.AreEqual(4, getMaxAdditionalDinersCount(10, 1, 1, [6]));
        Assert.AreEqual(3, getMaxAdditionalDinersCount(10, 1, 2, [1, 10]));
    }
}
