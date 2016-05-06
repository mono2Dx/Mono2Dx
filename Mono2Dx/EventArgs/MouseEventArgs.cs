using System;

namespace Mono2Dx
{
	public class MouseEventArgs
	{
		public MouseEventArgs (int x, int y, MouseButton mouseButton)
		{
			this.X = x;
			this.Y = y;
			this.MouseButton = mouseButton;
		}

		public int X { get; private set; }
		public int Y { get; private set; }
		public MouseButton MouseButton { get; private set; }
	}
}

