﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sprint4
{
    public class RightIdleBigMS : IMarioState
    {
        Mario mario;
        IAnimatedSprite sprite;
        
        public RightIdleBigMS(Mario mario)
        {
            ISpriteFactory factory = new SpriteFactory();
            sprite = factory.build(SpriteFactory.sprites.rightIdleMarioBig);
            this.mario = mario;
        }
        public Rectangle GetBoundingBox(Vector2 location)
        {
            return sprite.GetBoundingBox(location);
        }

        public void TakeDamage()
        {
            Game1.GetInstance().gameState = new TransitionGameState(mario.state, new RightIdleSmallMS(mario));
        }
        public void Up()
        {
            mario.state = new RightJumpingBigMS(mario);
        }
        public void Down()
        {
            mario.state = new RightCrouchingBigMS(mario);
        }
        public void GoLeft()
        {
            mario.state = new LeftMovingBigMS(mario);
        }
        public void GoRight()
        {
            mario.state = new RightMovingBigMS(mario);
        }
        public void Idle()
        {

        }
        public void Land()
        {

        }
        public void MakeBigMario()
        {
            // null
        }
        public void MakeSmallMario()
        {
            Game1.GetInstance().gameState = new TransitionGameState(mario.state, new RightIdleSmallMS(mario));
        }
        public void MakeFireMario()
        {
            Game1.GetInstance().gameState = new TransitionGameState(mario.state, new RightIdleFireMS(mario));
        }
        public void MakeFireballMario()
        {
            
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
