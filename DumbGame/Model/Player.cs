using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
namespace DumbGame.Model
{
	public class Player
	{

		private int score;
		private bool active;
		private int health;
		private int width;
		private int height;

		private Texture2D playerTexture;
		private Vector2 position;

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
			get{ return width; }
		}

		public int Height 
		{
			get{ return height; }
		}

		public void Initialize(Texture2D texture, Vector2 position)
		{
			this.active = true;
			this.health = 100;
			this.score = 0;
			this.playerTexture = texture;
			this.position = position;
		}

		public void Update()
		{

		}

		public void Draw(SpriteBatch spriteBatch)
		{
			spriteBatch.Draw (playerTexture, position, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
		}
			
	}

}

