using System;
using Microsoft.Xna.Framework.Input;

namespace Mono2Dx
{
	public class KeyboardEventArgs
	{
		public KeyboardEventArgs (Keys key)
		{
			this.Key = key;
		}

		public Keys Key { get; private set; }
	}
}

