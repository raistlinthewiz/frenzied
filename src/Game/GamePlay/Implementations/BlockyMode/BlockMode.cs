﻿/*
 * Frenzied Game, Copyright (C) 2012 - 2013 Int6 Studios - All Rights Reserved. - http://www.int6.org
 *
 * This file is part of Frenzied Game project. Unauthorized copying of this file, via any medium is strictly prohibited.
 * Frenzied Gam or its components/sources can not be copied and/or distributed without the express permission of Int6 Studios.
 */

using Frenzied.Assets;
using Frenzied.GamePlay.Modes;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Frenzied.GamePlay.Implementations.BlockyMode
{
    /// <summary>
    /// Blocked game mode.
    /// </summary>
    public class BlockMode : GameMode
    {
        public BlockMode()
        {
            this.RuleSet = new BlockRuleSet();
        }

        public override void Initialize()
        {
            var screenCenter = new Vector2(FrenziedGame.Instance.GraphicsDevice.Viewport.Bounds.Width / 2,
                                           FrenziedGame.Instance.GraphicsDevice.Viewport.Bounds.Height / 2);

            // add containers            
            this.ShapeContainers.Add(new BlockContainer(new Vector2(screenCenter.X - BlockContainer.Size.X / 2, screenCenter.Y - BlockContainer.Size.Y * 1.5f))); // top
            this.ShapeContainers.Add(new BlockContainer(new Vector2(screenCenter.X + BlockContainer.Size.X / 2, screenCenter.Y - BlockContainer.Size.Y / 2))); // right
            this.ShapeContainers.Add(new BlockContainer(new Vector2(screenCenter.X - BlockContainer.Size.X / 2, screenCenter.Y + BlockContainer.Size.Y / 2))); // bottom
            this.ShapeContainers.Add(new BlockContainer(new Vector2(screenCenter.X - BlockContainer.Size.X * 1.5f, screenCenter.Y - BlockContainer.Size.Y / 2))); // left

            // add generator
            this.ShapeGenerator = new BlockGenerator(new Vector2(screenCenter.X - BlockContainer.Size.X / 2, screenCenter.Y - BlockContainer.Size.Y / 2), this.ShapeContainers);

            base.Initialize();
        }

        public override Texture2D GetShapeTexture(Shape shape)
        {
            switch (shape.ColorIndex)
            {
                case BlockColors.Orange:
                    return AssetManager.Instance.BlockTextures[Color.Orange];
                case BlockColors.Purple:
                    return AssetManager.Instance.BlockTextures[Color.Purple];
                case BlockColors.Green:
                    return AssetManager.Instance.BlockTextures[Color.Green];
                case BlockColors.Blue:
                    return AssetManager.Instance.BlockTextures[Color.Blue];
                default:
                    return null;
            }
        }
    }
}
