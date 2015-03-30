﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sprint4
{
    class RightCrouchingFireMS : IMarioState
    {
        Mario mario;
        IAnimatedSprite sprite;
        
        public RightCrouchingFireMS(Mario mario)
        {
            ISpriteFactory factory = new SpriteFactory();
            sprite = factory.build(SpriteFactory.sprites.rightCrouchingMarioFire);
            this.mario = mario;
        }
        public Rectangle GetBoundingBox(Vector2 location)
        {
            return sprite.GetBoundingBox(location);
        }

        public void TakeDamage()
        {
            Game1.GetInstance().gameState = new TransitionGameState(mario.state, new RightCrouchingSmallMS(mario));
        }
        public void Up()
        {
            mario.state = new RightIdleFireMS(mario);
        }
        public void Down()
        {
           mario.position.Y++;
        }
        public void GoLeft()
        {
            mario.state = new LeftCrouchingFireMS(mario);
        }
        public void GoRight()
        {
        }
        public void Idle()
        {
            mario.state = new RightIdleFireMS(mario);
        }
        public void Land()
        {

        }
        public void MakeBigMario()
        {
            mario.state = new RightCrouchingBigMS(mario);
        }
        public void MakeSmallMario()
        {
            mario.state = new RightCrouchingSmallMS(mario);
        }
        public void MakeFireMario()
        {
            // null
        }
        public void MakeFireballMario()
        {
            // null
        }
        public void MakeDeadMario()
        {
            mario.state = new DeadMS(mario);
        }
        public void Update(GameTime gameTime)
        {
            sprite.Update(gameTime);
        }
        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            sprite.Draw(spriteBatch, location);
        }
    }
}
