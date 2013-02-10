/*
 * Frenzied Game, Copyright (C) 2012 - 2013 Int6 Studios - All Rights Reserved. - http://www.int6.org
 *
 * This file is part of Frenzied Game project. Unauthorized copying of this file, via any medium is strictly prohibited.
 * Frenzied Gam or its components/sources can not be copied and/or distributed without the express permission of Int6 Studios.
 */

using System;
using Microsoft.Xna.Framework;

namespace Frenzied.Platforms.IOS
{
	public class IOSPlatform : PlatformHandler 
	{
		public IOSPlatform()
		{
			this.PlatformConfig = new PlatformConfig()
			{
				IsMouseVisible = false,
				IsFixedTimeStep = false,
			};
		}
		
		public override void PlatformEntrance()
		{
			FrenziedGame game;

			game = new FrenziedGame ();
			game.Run ();
		}
		
		public override void Initialize(GraphicsDeviceManager graphicsDeviceManager)
		{
			this.GraphicsDeviceManager = graphicsDeviceManager;
			
			this.GraphicsDeviceManager.PreferredBackBufferWidth = 1280;
			this.GraphicsDeviceManager.PreferredBackBufferHeight = 720;
			this.GraphicsDeviceManager.ApplyChanges();
		}
	}
}
