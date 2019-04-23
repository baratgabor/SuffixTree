using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace SuffixTree.Tests
{
    [TestFixture]
    public class UnitTests
    {
        [TestCase("abcdefghijklmnpqrst")]
        [TestCase("aaaaaaaaaaaaaaaaaaaaaaaa")]
        [TestCase("bbefefbbaaaaaaaaaaaabbefefbb")]
        [TestCase("bananasbanananananananananassssss")]
        [TestCase("olbafuynhfcxzqhnebecxjrfwfttwrxvgujqxaxuaukbflddcrptlvyoaxuwzlwmoeljnxgmsleapkyzodhtymxuvlchoomsuodicehnzyebqtgsqeplinthhnalituxrisknsyjszuaatwoulznpjbvjmhytqgaqmctqvwgxailhproehwctldlagpjqaawdbialginqmweqrcopiqfnludmjuxkqlsgrydzyhecoojgmspowoykgghnbudhujnmyhqxbkfggxxprgfhraksfylcveevxvlxpzxkcqtkchasarbusvqzimvvfsvredhjykpqyyysyxbzwsuqahpjcroqvhysaynfheehppinszvwmyqlmymyqngrqzuefojczpoqcgbkvkmfpipdoetqxtdigphjhkxuwzieqirlvapypdysohfydtxzppfuufcreorhpsyydvvvsproofmuucwqqtskzieegstlokqkvjbssfythoenpbhlhnnsgknlapaigdwvrvsnyrhxhuzqkzoakldexmvnuvqscxmrysnuumawqrldjbtbmnhytvmmyykdaxuvqifecczafafzewmuplebvkxseatwsxwatbszboybwzhgfdtsjpxckknalqvgwuwwretocfaphnyuoyvnxbtabosfewkfrlbbeiduuidlogxfdacbplkbkpljvthltjjrlxbtejpdqjddnnsfhsljjfvmsjigyxmhjeqfcmmzzqpsxmnkuwlhhvcrtxskfmyieoctweswpkplcnjiqmtjjdloobapntxqmducnkabjcutinyhhekioybfokektjerdojqfvyalkvpqsznlvqvrswhelvburtkzdcceqehyqndhlcvkbieceazmuanqiauhkyhcbcckeydaevunddkwlntezctepnfrchvquxgtsnupoiwneengszjggwxkmahlbiwzsbyryqasufdsaaigulgwjqepccwesmbcfpoymrsjrbqwzjpjmbexpjloxdtwxqbdmggreurdcohfpgbchhrthdopewrsyfindsvrexpkkooxkmzxklsalyfuxscwthbfdbeghnpowbjxcedzogidsrdnjimcybbxmwpdiwnihhgylpsbukpsjtbkktylouakffurdfmpsnndtjcvjkbviezyqdgvhdcllibfbniafffwebrmyvbryjnomzgiglecxjntcvcrngwrvhefqaswhpynyzqwdpvewmjlpndtihwebjqolymkytrtidajqrdyvqzhcsvlvfvqspskkttqjsotdqkcdwzmdxxuevpvcrsijxskruaajrqaqgcarbxfrwerhddeetidequujlxmyaaoriomkhdmqaitbzbvhmnhmuntueqwueagpomwdhturmpwkyszjiwwlucqbhqbxgibuqmghvlrrbypswfsxkhgwjcndjnqblxargeegkzmhlahbahsfecevnpbxqdbuamjffddctbcedlcptoynjiuypvbgeatatnxztxsxvjrihxmoeeqmghwxxdyzrczljthnteqrfrquhvlssswndmdwxcfzrhcszffqdnjmqyjnywrurbsyavdxcwwtjsttcbsnvrpgiqlswqdcqmxjxwoebxjwlhlxbjuxuacdwktlivrfmncnqosxecfccutmikgwkeprlrkdfcinqgeeeompsmpcvxvnopzmrnuvdljcxjurxmliveisyfqsnpxsokkefgdujosxckvrkgeavugntchvztxkdqeiwyluxxgptyuuligmgfjcwcynffbgysjewlaaglqjuujjxytrphnfwncbkgkwswhcvliseqyifouatvszslptxqnhawzjhgfyorphndgksqdeoqohsqvwctwofrvqqpsnfisbcpluhesurrihkxvpugeitmatignbqqqldkdwqzaggxmitqlzobbuqccoeddmsdtjvywnbiiwkbidkjrofmbxjlnzfryzgxjbwgiaxbahchovroigmraoofyuzqheonmrfpskgciitjtxjzbhlpsohvysrwdwviirlxpvemizykpykhipjwhmqxoiwtevhyddyrigooibzrshqmbypvthubgozvhinzmntadmkfplledvglacrbeghcofvsddhokjhyfcqwwhbwjlkafilmaezpwezzgzgajpxhxcgwmcieilzlfrsxjlagjbjryhbrznmsfushtydgfsizclunncsbzpktmkmhmacicjuqhqaozwtihtcokd")]
        public void Build_ShouldNotThrow(string treeContent)
        {
            Assert.DoesNotThrow(
                () => SuffixTree.Build(treeContent)
            );
        }


        [TestCase]
        public void Contains_OnNonRepeated_ShouldReturnTrue()
        {
            var s = "abcdefghijklmnpqrst";
            var t = s.Substring(3, 6);
            var st = SuffixTree.Build(s);

            Assert.IsTrue(st.Contains(t));
        }


        [TestCase]
        public void Contains_OnNonRepeated_ShouldReturnFalse()
        {
            var s = "abcdefghijklmnpqrst";
            var t = "rstb";
            var st = SuffixTree.Build(s);

            Assert.IsFalse(st.Contains(t));
        }


        [TestCase]
        public void Contains_Simple_OnLongString_ShouldReturnTrue()
        {
            var s = "olbafuynhfcxzqhnebecxjrfwfttwrxvgujqxaxuaukbflddcrptlvyoaxuwzlwmoeljnxgmsleapkyzodhtymxuvlchoomsuodicehnzyebqtgsqeplinthhnalituxrisknsyjszuaatwoulznpjbvjmhytqgaqmctqvwgxailhproehwctldlagpjqaawdbialginqmweqrcopiqfnludmjuxkqlsgrydzyhecoojgmspowoykgghnbudhujnmyhqxbkfggxxprgfhraksfylcveevxvlxpzxkcqtkchasarbusvqzimvvfsvredhjykpqyyysyxbzwsuqahpjcroqvhysaynfheehppinszvwmyqlmymyqngrqzuefojczpoqcgbkvkmfpipdoetqxtdigphjhkxuwzieqirlvapypdysohfydtxzppfuufcreorhpsyydvvvsproofmuucwqqtskzieegstlokqkvjbssfythoenpbhlhnnsgknlapaigdwvrvsnyrhxhuzqkzoakldexmvnuvqscxmrysnuumawqrldjbtbmnhytvmmyykdaxuvqifecczafafzewmuplebvkxseatwsxwatbszboybwzhgfdtsjpxckknalqvgwuwwretocfaphnyuoyvnxbtabosfewkfrlbbeiduuidlogxfdacbplkbkpljvthltjjrlxbtejpdqjddnnsfhsljjfvmsjigyxmhjeqfcmmzzqpsxmnkuwlhhvcrtxskfmyieoctweswpkplcnjiqmtjjdloobapntxqmducnkabjcutinyhhekioybfokektjerdojqfvyalkvpqsznlvqvrswhelvburtkzdcceqehyqndhlcvkbieceazmuanqiauhkyhcbcckeydaevunddkwlntezctepnfrchvquxgtsnupoiwneengszjggwxkmahlbiwzsbyryqasufdsaaigulgwjqepccwesmbcfpoymrsjrbqwzjpjmbexpjloxdtwxqbdmggreurdcohfpgbchhrthdopewrsyfindsvrexpkkooxkmzxklsalyfuxscwthbfdbeghnpowbjxcedzogidsrdnjimcybbxmwpdiwnihhgylpsbukpsjtbkktylouakffurdfmpsnndtjcvjkbviezyqdgvhdcllibfbniafffwebrmyvbryjnomzgiglecxjntcvcrngwrvhefqaswhpynyzqwdpvewmjlpndtihwebjqolymkytrtidajqrdyvqzhcsvlvfvqspskkttqjsotdqkcdwzmdxxuevpvcrsijxskruaajrqaqgcarbxfrwerhddeetidequujlxmyaaoriomkhdmqaitbzbvhmnhmuntueqwueagpomwdhturmpwkyszjiwwlucqbhqbxgibuqmghvlrrbypswfsxkhgwjcndjnqblxargeegkzmhlahbahsfecevnpbxqdbuamjffddctbcedlcptoynjiuypvbgeatatnxztxsxvjrihxmoeeqmghwxxdyzrczljthnteqrfrquhvlssswndmdwxcfzrhcszffqdnjmqyjnywrurbsyavdxcwwtjsttcbsnvrpgiqlswqdcqmxjxwoebxjwlhlxbjuxuacdwktlivrfmncnqosxecfccutmikgwkeprlrkdfcinqgeeeompsmpcvxvnopzmrnuvdljcxjurxmliveisyfqsnpxsokkefgdujosxckvrkgeavugntchvztxkdqeiwyluxxgptyuuligmgfjcwcynffbgysjewlaaglqjuujjxytrphnfwncbkgkwswhcvliseqyifouatvszslptxqnhawzjhgfyorphndgksqdeoqohsqvwctwofrvqqpsnfisbcpluhesurrihkxvpugeitmatignbqqqldkdwqzaggxmitqlzobbuqccoeddmsdtjvywnbiiwkbidkjrofmbxjlnzfryzgxjbwgiaxbahchovroigmraoofyuzqheonmrfpskgciitjtxjzbhlpsohvysrwdwviirlxpvemizykpykhipjwhmqxoiwtevhyddyrigooibzrshqmbypvthubgozvhinzmntadmkfplledvglacrbeghcofvsddhokjhyfcqwwhbwjlkafilmaezpwezzgzgajpxhxcgwmcieilzlfrsxjlagjbjryhbrznmsfushtydgfsizclunncsbzpktmkmhmacicjuqhqaozwtihtcokd";
            var t = s.Substring(s.Length/2, s.Length/50);
            var st = SuffixTree.Build(s);

            Assert.IsTrue(st.Contains(t));
        }


        [TestCase]
        public void Contains_DynamicBarrage_OnLongString_ShouldReturnTrue()
        {
            const int   CYCLES = 200,
                        MAXLEN = 200;

            var s = "olbafuynhfcxzqhnebecxjrfwfttwrxvgujqxaxuaukbflddcrptlvyoaxuwzlwmoeljnxgmsleapkyzodhtymxuvlchoomsuodicehnzyebqtgsqeplinthhnalituxrisknsyjszuaatwoulznpjbvjmhytqgaqmctqvwgxailhproehwctldlagpjqaawdbialginqmweqrcopiqfnludmjuxkqlsgrydzyhecoojgmspowoykgghnbudhujnmyhqxbkfggxxprgfhraksfylcveevxvlxpzxkcqtkchasarbusvqzimvvfsvredhjykpqyyysyxbzwsuqahpjcroqvhysaynfheehppinszvwmyqlmymyqngrqzuefojczpoqcgbkvkmfpipdoetqxtdigphjhkxuwzieqirlvapypdysohfydtxzppfuufcreorhpsyydvvvsproofmuucwqqtskzieegstlokqkvjbssfythoenpbhlhnnsgknlapaigdwvrvsnyrhxhuzqkzoakldexmvnuvqscxmrysnuumawqrldjbtbmnhytvmmyykdaxuvqifecczafafzewmuplebvkxseatwsxwatbszboybwzhgfdtsjpxckknalqvgwuwwretocfaphnyuoyvnxbtabosfewkfrlbbeiduuidlogxfdacbplkbkpljvthltjjrlxbtejpdqjddnnsfhsljjfvmsjigyxmhjeqfcmmzzqpsxmnkuwlhhvcrtxskfmyieoctweswpkplcnjiqmtjjdloobapntxqmducnkabjcutinyhhekioybfokektjerdojqfvyalkvpqsznlvqvrswhelvburtkzdcceqehyqndhlcvkbieceazmuanqiauhkyhcbcckeydaevunddkwlntezctepnfrchvquxgtsnupoiwneengszjggwxkmahlbiwzsbyryqasufdsaaigulgwjqepccwesmbcfpoymrsjrbqwzjpjmbexpjloxdtwxqbdmggreurdcohfpgbchhrthdopewrsyfindsvrexpkkooxkmzxklsalyfuxscwthbfdbeghnpowbjxcedzogidsrdnjimcybbxmwpdiwnihhgylpsbukpsjtbkktylouakffurdfmpsnndtjcvjkbviezyqdgvhdcllibfbniafffwebrmyvbryjnomzgiglecxjntcvcrngwrvhefqaswhpynyzqwdpvewmjlpndtihwebjqolymkytrtidajqrdyvqzhcsvlvfvqspskkttqjsotdqkcdwzmdxxuevpvcrsijxskruaajrqaqgcarbxfrwerhddeetidequujlxmyaaoriomkhdmqaitbzbvhmnhmuntueqwueagpomwdhturmpwkyszjiwwlucqbhqbxgibuqmghvlrrbypswfsxkhgwjcndjnqblxargeegkzmhlahbahsfecevnpbxqdbuamjffddctbcedlcptoynjiuypvbgeatatnxztxsxvjrihxmoeeqmghwxxdyzrczljthnteqrfrquhvlssswndmdwxcfzrhcszffqdnjmqyjnywrurbsyavdxcwwtjsttcbsnvrpgiqlswqdcqmxjxwoebxjwlhlxbjuxuacdwktlivrfmncnqosxecfccutmikgwkeprlrkdfcinqgeeeompsmpcvxvnopzmrnuvdljcxjurxmliveisyfqsnpxsokkefgdujosxckvrkgeavugntchvztxkdqeiwyluxxgptyuuligmgfjcwcynffbgysjewlaaglqjuujjxytrphnfwncbkgkwswhcvliseqyifouatvszslptxqnhawzjhgfyorphndgksqdeoqohsqvwctwofrvqqpsnfisbcpluhesurrihkxvpugeitmatignbqqqldkdwqzaggxmitqlzobbuqccoeddmsdtjvywnbiiwkbidkjrofmbxjlnzfryzgxjbwgiaxbahchovroigmraoofyuzqheonmrfpskgciitjtxjzbhlpsohvysrwdwviirlxpvemizykpykhipjwhmqxoiwtevhyddyrigooibzrshqmbypvthubgozvhinzmntadmkfplledvglacrbeghcofvsddhokjhyfcqwwhbwjlkafilmaezpwezzgzgajpxhxcgwmcieilzlfrsxjlagjbjryhbrznmsfushtydgfsizclunncsbzpktmkmhmacicjuqhqaozwtihtcokd";
            var st = SuffixTree.Build(s);
            var r = new Random();

            for (int i = 0; i < CYCLES; i++)
            {
                var pos = r.Next(0, s.Length - 2);
                var len = r.Next(1, Math.Min(s.Length - pos, MAXLEN));
                var ss = s.Substring(pos, len);

                Assert.IsTrue(st.Contains(ss), ss);
            }
        }


        [TestCase]
        public void Contains_InShortRandomString_ShouldReturnTrue()
        {
            const int   CYCLES = 2000,
                        STRLEN = 200,
                        MATCHLEN = 20;
            
            var r = new Random();

            for (int i = 0; i < CYCLES; i++)
            {
                var s = MakeRandomString(STRLEN);
                var ss = s.Substring(r.Next(0, s.Length - MATCHLEN), MATCHLEN);
                var res = false;

                try
                {
                    res = SuffixTree.Build(s).Contains(ss);
                }
                catch(Exception e)
                {
                    throw new Exception($"\nString: \n{s}, \nSubstring: \n{ss}, Error message: {e.Message}", e);
                }

                Assert.IsTrue(res, $"\nString: \n{s}, \nSubstring: \n{ss}");
            }

            string MakeRandomString(int len)
            {
                const string SET = "abcdefghijklmnopqrstuvwxyz";
                var res = new char[len];
                while (len --> 0)
                    res[len] = SET[r.Next(SET.Length)];

                return new string(res);
            }
        }
    }
}
