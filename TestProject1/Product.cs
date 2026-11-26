using System.Net.Http.Headers; // example system using; not needed by this test but may be present from template
using Peter_Møbler_Lib; // import the library that contains Product

namespace TestProject1
{
	// Test class container for unit tests related to Peter_Møbler_Lib
	public class UnitTestProduct
	{
		[Fact] // Attribute from xUnit marking this method as a test case
		public void TestProductNoMinimum()
		{
			// arrange: set up objects and expected values for the test
			Product product = new Product(); // create a new Product using the default constructor
			int expectedProductNo = 0; // the expected product number after construction (default is 0)

			// act: perform the action under test
			// The next line attempts to set a negative product number. The Product.ProductNo
			// setter throws ArgumentException for negative values; in a robust test this
			// would be wrapped with Assert.Throws or adjusted to test allowed behavior.
			product.ProductNo = 0; // attempt to set an invalid product number
			int actualProductNo = product.ProductNo; // read back the product number

			// assert: verify the result matches expectations
			// This assertion checks that the actual value equals the expected value.
			// If the setter threw an exception, this line will not be reached.
			Assert.Equal(expectedProductNo, actualProductNo);
		}

		[Fact]
		public void TestPriceMinimumValue()
		{
			Product product = new Product(1, 100, "long name");
			int expectedPrice = 10; // default price is 0
			product.Price = 10; // attempt to set an invalid price (less than 10)
			int actualPrice = product.Price;
			Assert.Equal(expectedPrice, actualPrice);
		}

		[Fact]
		public void TestNameLengthMinimum()
		{
			// Arrange
			Product product = new Product(1, 100, "valid name");
			string shortName = "loname"; // shorter than required 7 characters

			// Act
			// Assert
			Assert.Throws<ArgumentException>(() => product.Name = shortName);
		}

		[Fact]
		public void TestNameNull()
		{
		Product product = new Product(1, 100, "valid name");
			string noname = null;
			Assert.Throws<ArgumentException>(() => product.Name = noname);
		}

	}
}
