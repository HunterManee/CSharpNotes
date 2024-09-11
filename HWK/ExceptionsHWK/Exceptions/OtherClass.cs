using System;
namespace Exceptions
{
	public class OtherClass
	{
		public static void throwException()
		{
			throw new MemberAccessException("No memory");
		}
	}
}

