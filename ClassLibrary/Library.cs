using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary {
	public class Library {
		public static void Foo(IEnumerable<string> enumerable) {
			enumerable.Append("Appended");
		}
	}
}
