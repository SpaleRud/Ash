using System;
using NUnit.Framework;
using Atbash;

namespace testAsh
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void EncryptR()
        {
            var test1 = new Atbash.Atbash("Привет Мир!");
            Assert.AreEqual(test1.Code(),"рпчэън учп!");
        }
        [Test]
        public void EncryptRDifference()
        {
            var test1 = new Atbash.Atbash("ПрИвЕт, МиР!");
            Assert.AreEqual(test1.Code(),"рпчэън, учп!");
        }
        [Test]
        public void EncryptRLong()
        {
            var test1 = new Atbash.Atbash("попробуй ещё этих сладких пирожных.");
            Assert.AreEqual(test1.Code(),"рсрпсюмц ъжъ внчк офяыхчк рчпсщтдк.");
        }
        [Test]
        public void EncryptE()
        {
            var test1 = new Atbash.Atbash("Hello World!");
            Assert.AreEqual(test1.Code(),"svool dliow!");
        }
        [Test]
        public void EncryptELong()
        {
            var test1 = new Atbash.Atbash("try some more of these sweet cakes.");
            Assert.AreEqual(test1.Code(),"gib hlnv nliv lu gsvhv hdvvg xzpvh.");
        }
        [Test]
        public void DecryptE()
        {
            var test1 = new Atbash.Atbash("yzhrx kiltiznnrmt");
            Assert.AreEqual(test1.Code(),"basic programming");
        }
        [Test]
        public void DecryptR()
        {
            var test1 = new Atbash.Atbash("охспсьсэспхя");
            Assert.AreEqual(test1.Code(),"скороговорка");
        }
        [Test]
        public void EncryptEShort()
        {
            var test1 = new Atbash.Atbash("sea");
            Assert.AreEqual(test1.Code(),"hvz");
        }
        [Test]
        public void EncryptRShort()
        {
            var test1 = new Atbash.Atbash("зал");
            Assert.AreEqual(test1.Code(),"шяф");
        }
    }
}