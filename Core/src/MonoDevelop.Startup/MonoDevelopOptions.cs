using System;
using Mono.GetOptions;

namespace MonoDevelop.Startup
{
	public class MonoDevelopOptions : Options
	{
		public MonoDevelopOptions ()
		{
			base.ParsingMode = OptionsParsingMode.Both;
		}

		[Option ("Do not display splash screen.")]
		public bool nologo;
	}
}

