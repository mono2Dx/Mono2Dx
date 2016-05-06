using System;
using Microsoft.Xna.Framework.Input;

namespace Mono2Dx
{
	public abstract class BasicGame : GameContainer
	{
		public BasicGame ()
		{
			GameInput.KeyDown += (Keys key) => OnKeyDown(key);
		}

		public virtual void OnKeyDown(Keys key) {}
	}
}

