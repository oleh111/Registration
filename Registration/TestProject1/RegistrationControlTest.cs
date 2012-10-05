using Registration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for RegistrationControlTest and is intended
    ///to contain all RegistrationControlTest Unit Tests
    ///</summary>
	[TestClass()]
	public class RegistrationControlTest
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
		///A test for ComputeStringMD5Hash
		///</summary>
		[TestMethod()]
		public void ComputeStringMD5HashTest()
		{
			Library _libr = null; // TODO: Initialize to an appropriate value
			RegistrationControl target = new RegistrationControl(_libr); // TODO: Initialize to an appropriate value
			string instr = "TEST"; // TODO: Initialize to an appropriate value
			string expected = target.ComputeStringMD5Hash("TEST"); // TODO: Initialize to an appropriate value
			string actual;
			actual = target.ComputeStringMD5Hash(instr);
			Assert.AreEqual(expected, actual);
		}

		/// <summary>
		///A test for checkCaptcha
		///</summary>
		[TestMethod()]
		public void checkCaptchaTest()
		{
			Library _libr = null; // TODO: Initialize to an appropriate value
			RegistrationControl target = new RegistrationControl(_libr); // TODO: Initialize to an appropriate value
			string _text = "TEST"; // TODO: Initialize to an appropriate value
			bool expected = true; // TODO: Initialize to an appropriate value
			bool actual;
			target.setText("TEST");
			actual = target.checkCaptcha(_text);
			Assert.AreEqual(expected, actual);
		}

		/// <summary>
		///A test for createImage
		///</summary>
		[TestMethod()]
		public void createImageTest()
		{
			Library _libr = null; // TODO: Initialize to an appropriate value
			RegistrationControl target = new RegistrationControl(_libr); // TODO: Initialize to an appropriate value
			int Width = 10; // TODO: Initialize to an appropriate value
			int Height = 10; // TODO: Initialize to an appropriate value
			Bitmap expected = target.createImage(Width, Height); ; // TODO: Initialize to an appropriate value
			Bitmap actual;
			actual = target.createImage(Width, Height);
			Assert.AreNotEqual(expected, actual);
		}

		/// <summary>
		///A test for createPerson
		///</summary>
		[TestMethod()]
		public void createPersonTest()
		{
			Library _libr = null; // TODO: Initialize to an appropriate value
			RegistrationControl target = new RegistrationControl(_libr); // TODO: Initialize to an appropriate value
			string p1 = string.Empty; // TODO: Initialize to an appropriate value
			string p2 = string.Empty; // TODO: Initialize to an appropriate value
			string p3 = string.Empty; // TODO: Initialize to an appropriate value
			string p4 = string.Empty; // TODO: Initialize to an appropriate value
			target.createPerson(p1, p2, p3, p4);
			Assert.AreNotEqual(target.getNewPerson(), null);
		}

		/// <summary>
		///A test for registerComplete
		///</summary>
		[TestMethod()]
		public void registerCompleteTest()
		{
			Library _libr = null; // TODO: Initialize to an appropriate value
			RegistrationControl target = new RegistrationControl(_libr); // TODO: Initialize to an appropriate value
			string p1 = "Acceptable"; // TODO: Initialize to an appropriate value
			string p2 = "Acceptable"; // TODO: Initialize to an appropriate value
			string p3 = "Acceptable"; // TODO: Initialize to an appropriate value
			string p4 = "Acceptable"; // TODO: Initialize to an appropriate value
			bool expected = true; // TODO: Initialize to an appropriate value
			bool actual;
			actual = target.registerComplete(p1, p2, p3, p4);
			Assert.AreEqual(expected, actual);
		}

		/// <summary>
		///A test for validateComboBox1
		///</summary>
		[TestMethod()]
		public void validateComboBox1Test()
		{
			Library _libr = null; // TODO: Initialize to an appropriate value
			RegistrationControl target = new RegistrationControl(_libr); // TODO: Initialize to an appropriate value
			string country = string.Empty; // TODO: Initialize to an appropriate value
			bool expected = true; // TODO: Initialize to an appropriate value
			bool actual;
			actual = target.validateComboBox1(country);
			Assert.AreEqual(expected, actual);
		}

		/// <summary>
		///A test for validateTextBox2
		///</summary>
		[TestMethod()]
		public void validateTextBox2Test()
		{
			Library _libr = null; // TODO: Initialize to an appropriate value
			RegistrationControl target = new RegistrationControl(_libr); // TODO: Initialize to an appropriate value
			string _password1 = "abc"; // TODO: Initialize to an appropriate value
			string _password2 = "abc"; // TODO: Initialize to an appropriate value
			bool expected = true; // TODO: Initialize to an appropriate value
			bool actual;
			actual = target.validateTextBox2(_password1, _password2);
			Assert.AreEqual(expected, actual);

		}

		/// <summary>
		///A test for validatecomboBox2
		///</summary>
		[TestMethod()]
		public void validatecomboBox2Test()
		{
			Library _libr = null; // TODO: Initialize to an appropriate value
			RegistrationControl target = new RegistrationControl(_libr); // TODO: Initialize to an appropriate value
			string age = "1990"; // TODO: Initialize to an appropriate value
			bool expected = true; // TODO: Initialize to an appropriate value
			bool actual;
			actual = target.validatecomboBox2(age);
			Assert.AreEqual(expected, actual);
		}
	}
}
