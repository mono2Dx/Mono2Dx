using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Mono2Dx
{
	public class GameInput
	{
		public delegate void KeyboardEventHandler(Keys key);
		public delegate void MouseEventHandler(MouseEventArgs e);
		public delegate void TouchEventHandler(TouchEventArgs e);
		public delegate void GamePadConnectionEventHandler(PlayerIndex playerIndex);
		public delegate void GamePadButtonEventHandler(Buttons buttons);

		public static event KeyboardEventHandler KeyDown;
		public static event KeyboardEventHandler KeyUp;

		public static event MouseEventHandler MouseDown;
		public static event MouseEventHandler MouseUp;
		public static event MouseEventHandler MouseMoved;

		public static event TouchEventHandler TouchDown;
		public static event TouchEventHandler TouchUp;
		public static event TouchEventHandler TouchDragged;

		public static event GamePadConnectionEventHandler GamePadConnected;
		public static event GamePadConnectionEventHandler GamePadDisconnected;
		public static event GamePadButtonEventHandler GamePadButtonDown;
		public static event GamePadButtonEventHandler GamePadButtonUp;
	}
}

