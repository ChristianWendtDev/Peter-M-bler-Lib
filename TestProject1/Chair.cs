using System;
using System.Collections.Generic;
using System.Text;
using Peter_Møbler_Lib;
using Xunit;
namespace TestProject1
{
	public class ChairTest
	{
		[Theory]
		[InlineData(50)] // valid dimensions
		[InlineData(140)]
		public void TestChairLegalWidth(int width)
		{
			Chair chair = new Chair(90, 45, 60, new List<string> { "Wood" }, 101, 299, "Wooden Chair");
		}
	}
}
