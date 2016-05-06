using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Mono2Dx
{
	public abstract class GameContainer
	{
		public static double MAXIMUM_DELTA = (1.0 / 60.0);

		public delegate void ResizeEventHandler (object sender, GameResizeEventArgs e);

		public event ResizeEventHandler GameResized;

		protected int width;
		protected int height;
		protected SpriteBatch spriteBatch;
		protected Graphics graphics;

		private bool initialised = false;

		/// <summary>
		/// Initialise this instance.
		/// </summary>
		public abstract void Initialise ();

		/// <summary>
		/// Update the game
		/// </summary>
		/// <param name="delta">The time in seconds since the last update</param>
		public abstract void Update (double delta);

		/// <summary>
		/// Interpolate the game state
		/// </summary>
		/// <param name="alpha">The alpha value to use during interpolation</param>
		public abstract void Interpolate (double alpha);

		/// <summary>
		/// Render the game
		/// </summary>
		/// <param name="g">The Graphics context available for rendering</param>
		public abstract void Render (Graphics g);

		public void Render ()
		{
			graphics.PreRender (Width, Height);
			Render (graphics);
			graphics.PostRender ();
		}

		protected void PreInit (GraphicsDeviceManager graphicsDeviceManager)
		{
			spriteBatch = new SpriteBatch (graphicsDeviceManager.GraphicsDevice);
		}

		protected void PostInit (GraphicsDeviceManager graphicsDeviceManager)
		{
		}

		public void Start (GraphicsDeviceManager graphicsDeviceManager)
		{
			this.width = graphicsDeviceManager.GraphicsDevice.Viewport.Width;
			this.height = graphicsDeviceManager.GraphicsDevice.Viewport.Height;

			if (!initialised) {
				PreInit (graphicsDeviceManager);
				Initialise ();
				PostInit (graphicsDeviceManager);
				initialised = true;
			}
		}

		public int Width {
			get { return width; }
		}

		public int Height {
			get { return height; }
		}
	}
}

