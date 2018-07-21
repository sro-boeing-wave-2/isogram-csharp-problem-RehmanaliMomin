using System;
using Xunit;

namespace Isogram.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Sentence_empty()
        {
            Isogram.IsIsogram("").Equals(true);
        }

        [Fact]
        public void Sentence1()
        {
            Isogram.IsIsogram("qwertyuiop").Equals(true);
        }

        [Fact]
        public void Sentence2()
        {
            Isogram.IsIsogram("qwerty asdfg werty dfg").Equals(false);
        }

        [Fact]
        public void Sentence3()
        {
            Isogram.IsIsogram("qwertyuiop asdfghjkl zxcvbnm,").Equals(true);
        }

        [Fact]
        public void Sentence4()
        {
            Isogram.IsIsogram("heyohkklkl").Equals(false);
        }

        [Fact]
        public void Sentence5()
        {
            Isogram.IsIsogram("dfghj-cvbn-poiuy").Equals(true);
        }

        [Fact]
        public void Sentence6()
        {
            Isogram.IsIsogram("Sharath tatti hain").Equals(false);
        }
    }
}
