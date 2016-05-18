using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using DumbGame.View;

namespace DumbGame.Model
{
	public class Player
	{

		private int score;
		private bool active;
		private int health;

		private Animation PlayerAnimation;
		public Vector2 Position;

		public int Score
		{
			get { return score; }
			set { score = value; }

		}

		public bool Active
		{
			get{ return active; }
			set{ active = value; }
		}

		public int Health
		{
			get{ return health; }
			set{ health = value; }
		}

		public int Width
		{
			get { return PlayerAnimation.FrameWidth; }
		}

		public int Height
		{
			get { return PlayerAnimation.FrameHeight; }
		}

		public void Initialize(Animation animation, Vector2 position)
		{
			this.active = true;
			this.health = 100;
			this.score = 0;
			this.PlayerAnimation = animation;
			this.Position = position;
		}

		// Update the player animation
		public void Update(GameTime gameTime)
		{
			PlayerAnimation.Position = Position;
			PlayerAnimation.Update(gameTime);
		}

		// Draw the player
		public void Draw(SpriteBatch spriteBatch)
		{
			PlayerAnimation.Draw(spriteBatch);
		}


			
	}

}

