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
        ///A test for buildKey
        ///</summary>
        [TestMethod()]
        [DeploymentItem("Vernam_Cipher.dll")]
        public void buildKeyTest()
        {
            // test shorter key
            VernamKey_Accessor target = new VernamKey_Accessor("key");
            string expected = "ke";
            string actual;
            actual = target.buildKey(2);
            Assert.AreEqual(expected, actual);

            // test equal key
            expected = "key";
            actual = target.buildKey(3);
            Assert.AreEqual(expected, actual);

            // test bigger key
            expected = "keyke";
            actual = target.buildKey(5);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for encrypt
        ///</summary>
        [TestMethod()]
        public void encryptTest()
        {
            string Key = "something";
            VernamKey target = new VernamKey(Key);
            string text = "this is a hidden text";
            string expected = "\a\aTNS\a\r\aN";
            string actual;
            actual = target.encrypt(text);
            Assert.AreEqual(expected, actual);

            // test that there is a difference between keys
            Key = "a different key";
            target = new VernamKey(Key);
            text = "this is a hidden text";
            expected = "\a\aTNS\a\r\aN";
            actual = target.encrypt(text);
            Assert.AreNotEqual(expected, actual);
        }

        /// <summary>
        ///A test for decode
        ///</summary>
        [TestMethod()]
        public void decodeTest()
        {
            string Key = "something";
            VernamKey target = new VernamKey(Key);
            string text = "\a\aTNS\a\r\aN";
            string expected = "this is a hidden text";
            string actual;
            actual = target.decode(text);
            Assert.AreEqual(expected, actual);
        }
    }
}
