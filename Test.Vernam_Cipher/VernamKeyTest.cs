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
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            VernamKey_Accessor target = new VernamKey_Accessor(param0); // TODO: Initialize to an appropriate value
            string text = string.Empty; // TODO: Initialize to an appropriate value
            byte[] expected = null; // TODO: Initialize to an appropriate value
            byte[] actual;
            actual = target.ToBytes(text);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
