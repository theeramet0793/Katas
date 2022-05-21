using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculatorNamespace;
using System.Collections.Generic;

namespace StringCalculatorTest
{
    [TestClass]
    public class StringCalculatorTest
    {
        [TestMethod]
        public void Add_neg1_neg2_1000_SetNeg1Neg2()
        {
            var strcal = new StringCalculator();
            var list = new List<int>() { -1,-2};

            int num = strcal.Add("-1//-2,1000");
            CollectionAssert.AreEqual(list, strcal.negIntList);
        }

        [TestMethod]
        public void Add_1_2_1000_return1003()
        {
            var strcal = new StringCalculator();
            int num = strcal.Add("1//2,1000");
            Assert.AreEqual(1003, num);
        }

        [TestMethod]
        public void Add_1_2_3_return6()
        {
            var strcal = new StringCalculator();
            int num = strcal.Add("1\n2,3");
            Assert.AreEqual(6, num);
        }

        [TestMethod]
        public void Add_1_2__return3()
        {
            var strcal = new StringCalculator();
            int num = strcal.Add("//;\n1;2");
            Assert.AreEqual(3, num);
        }

        [TestMethod]
        public void Add_Neg1_2__returnNeg1()
        {
            var strcal = new StringCalculator();
            int num = strcal.Add("-1,2");
            Assert.AreEqual(-1, num);
        }

        [TestMethod]
        public void Add_2_neg4_3_neg5__returnNeg1()
        {
            var strcal = new StringCalculator();
            int num = strcal.Add("2,-4,3,-5");
            Assert.AreEqual(-1, num);
        }

        [TestMethod]
        public void Add_2_1000_return2()
        {
            var strcal = new StringCalculator();
            int num = strcal.Add("2,1001");
            Assert.AreEqual(2, num);
        }

        [TestMethod]
        public void Add_1_2_3__return6()
        {
            var strcal = new StringCalculator();
            int num = strcal.Add("//[|||]1|||2|||3");
            Assert.AreEqual(6, num);
        }

        [TestMethod]
        public void Add__1_2_3_return6()
        {
            var strcal = new StringCalculator();
            int num = strcal.Add("//[|][%]\n1|2%3");
            Assert.AreEqual(6, num);
        }

        [TestMethod]
        public void PickNumOut_3number_return_1_2_1000()
        {
            var strcal = new StringCalculator();
            List<int> list2 = new List<int> { 1, 2, 1000 };

            List<int> list1 = strcal.PickNumOut("1//2,1000");
            CollectionAssert.AreEqual(list1, list2);
        }

        [TestMethod]
        public void HasNewLine_HasNewlineInString_returnTrue()
        {
            var strcal = new StringCalculator();

            var result = strcal.HasNewLine("rdsfgdfsgdfg\nsdfgd");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void HasNewLine_NoNewlineInString_returnFalse()
        {
            var strcal = new StringCalculator();

            var result = strcal.HasNewLine("rdsfgdfsgdfgsdfgd");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void UnknownNumberHandle_NoParam_return0()
        {
            var strcal = new StringCalculator();

            var result = strcal.UnknownNumberHandle();

            Assert.AreEqual(result,0);
        }

        [TestMethod]
        public void sumOf2Num_ArgIs1n2_return3()
        {
            var strcal = new StringCalculator();

            var result = strcal.SumOf2Num("1,2");

            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        public void sumOf2Num_ArgIs0n43_return43()
        {
            var strcal = new StringCalculator();

            var result = strcal.SumOf2Num("0,43");

            Assert.AreEqual(result, 43);
        }

        [TestMethod]
        public void sumOf2Num_ArgIs1nNeg2_returnNeg1()
        {
            var strcal = new StringCalculator();

            var result = strcal.SumOf2Num("1,-2");

            Assert.AreEqual(result, -1);
        }

        [TestMethod]
        public void convert2Int_ArgIs2_return2()
        {
            var strcal = new StringCalculator();

            var result = strcal.CovertToInt("2");

            Assert.AreEqual(result, 2);
        }

        [TestMethod]
        public void convert2Int_ArgIsNeg2_returnNeg2()
        {
            var strcal = new StringCalculator();

            var result = strcal.CovertToInt("-2");

            Assert.AreEqual(result, -2);
        }

        [TestMethod]
        public void IsEmptyString_ArgIsEmpty_returnTrue()
        {
            var strcal = new StringCalculator();

            var result = strcal.IsEmptyString("");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsEmptyString_ArgIsNotEmpty_returnFalse()
        {
            var strcal = new StringCalculator();

            var result = strcal.IsEmptyString("srdfd");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void HasOneNumber_ArgIsOneNum_returnTrue()
        {
            var strcal = new StringCalculator();

            var result = strcal.HasOneNumber("1");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void HasOneNumber_ArgIsTwoNum_returnFalse()
        {
            var strcal = new StringCalculator();

            var result = strcal.HasOneNumber("1,2");

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void HasTwoNumber_ArgIsTwoNum_returnTrue()
        {
            var strcal = new StringCalculator();

            var result = strcal.HasTwoNumber("1,2");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void HasTwoNumber_ArgIsThreeNum_returnFalse()
        {
            var strcal = new StringCalculator();

            var result = strcal.HasTwoNumber("1,2,3");

            Assert.IsFalse(result);
        }
    }
}