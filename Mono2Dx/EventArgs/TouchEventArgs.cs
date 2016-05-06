using System;

namespace Mono2Dx
{
	public class TouchEventArgs
	{
		public TouchEventArgs (int x, int y)
		{
			this.X = x;
			this.Y = y;
		}

		public int X { get; private set; }
		public int Y { get; private set; }
	}
}

