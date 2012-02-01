using Vernam_Cipher;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test.Vernam_Cipher
{
    
    
    /// <summary>
    ///This is a test class for VernamKeyTest and is intended
    ///to contain all VernamKeyTest Unit Tests
    ///</summary>
    [TestClass()]
    public class VernamKeyTest
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
        ///A test for ToBytes
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Vernam_Cipher.dll")]
        public void ToBytesTest()
        {
            VernamKey_Accessor target = new VernamKey_Accessor("key");
            string text = "a new";
            byte[] expected = { 0x61, 0x20, 0x6e,0x65, 0x77 };
            byte[] actual;
            actual = target.ToBytes(text);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
