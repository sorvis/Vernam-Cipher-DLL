using Vernam_Cipher;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;

namespace Test.Vernam_Cipher
{
    
    
    /// <summary>
    ///This is a test class for ByteToolsTest and is intended
    ///to contain all ByteToolsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ByteToolsTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for StringToBytes
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Vernam_Cipher.dll")]
        public void StringToBytesTest()
        {
            string text = "a new";
            byte[] expected = { 0x61, 0x20, 0x6e, 0x65, 0x77 };
            byte[] actual;
            actual = ByteTools_Accessor.StringToBytes(text);
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for BytesToString
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Vernam_Cipher.dll")]
        public void BytesToStringTest()
        {
            byte[] bytes = { 0x61, 0x20, 0x6e, 0x65, 0x77 };
            string expected = "a new";
            string actual;
            actual = ByteTools_Accessor.BytesToString(bytes);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for XOR_byteArray
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Vernam_Cipher.dll")]
        public void XOR_byteArrayTest()
        {
            byte[] original = { 0x64, 0x56 };
            byte[] key = { 0x73, 0x49 };
            byte[] expected = { 0x17, 0x1F };
            byte[] actual;
            actual = ByteTools_Accessor.XOR_byteArray(original, key);
            CollectionAssert.AreEqual(expected, actual);

            original = new byte[] {0x64};
            key = new byte[] { 0x73 };
            expected = new byte[] { 0x3A };
            actual = ByteTools_Accessor.XOR_byteArray(original, key);
            CollectionAssert.AreNotEqual(expected,actual);
        }
    }
}
