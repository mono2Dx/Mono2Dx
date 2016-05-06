using System;

namespace Mono2Dx
{
	public class GameResizeEventArgs
	{
		public GameResizeEventArgs (int width, int height)
		{
			this.Width = width;
			this.Height = height;
		}

		public int Width { get; private set; }
		public int Height { get; private set; }
	}
}

