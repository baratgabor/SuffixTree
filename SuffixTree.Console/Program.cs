using System.Diagnostics;

namespace SuffixTree.Console
{
    class Program
    {
        const string examples1 = @"
            tsqejfoxyvszpuuvetdfluuhxpeopuxmdylaysttenjmcedcumoeeicjtxkkvxcxvkkxtjcifbeutdcsdrviozobdytwsi
            mseetqckeeomucdecmjnettsyalydmxupoepxhuulfdtevuupzsvyynamdjxnsmkiewkwdpzjpkibcbbmzbiwpmjczcehtczqjzl
            bkiimwwkwkbwwkwwmiikbwmikbiiwbkkwimmwiwiwkmkbkm
            hjxhxvluhtdnzgxjfgedtzfxhzeoootvjqeegoysgoppdvvzd
            drouylqobsgemwdoibqvcyedfvqoebvdujgsulahkprfrxco
            xbfzlwcxfvqaavfegpkhalusgjudvbeqzqifuaoubukyp
            tqflceilpmszizfw
            bonxplcyqittpk
            ngoqbpielolgfelgbpofbifnf
            jkhhyhdcjxzymxcddavzkzwyhwtsj
            uoavyovdbielzdobgqcjzn
            jbexalkghywioxzbvx
            chwszhvcdooejlcqvqmhx
            hcwccwchcljeoodcvhzswhcf
            eavwjmgvhuesssaxgmoywdg
            vwvgdwyomgxassseuhvgmjw
            qatxbuzxpstpyggyptsuqmx
            enprpmypxzubxtatesstwhy
            bximeeswyndfh
            omcnwjtfru";

        static void Main(string[] args)
        {
            var s = "bananasbanananananananananassssss";
            var t = "ananasbanana";

            var tree = new SuffixTree();
            tree.AddString(s);

            Debug.WriteLine("");
            Debug.WriteLine(tree.Contains(t));
            Debug.WriteLine("");
            Debug.WriteLine(tree);
        }
    }
}
