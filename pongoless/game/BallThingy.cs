using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using pongoless.core;

namespace pongoless.game {
    public class BallThingy : GameObject {
        private Texture2D _texture;
        private int _size;
        private float _speed;

        public BallThingy() {
            _size = 16;
            _color = Color.White;
            _speed = 10;
            _texture = ImageHandler.CreateTexture(Color.White, _size, _size);
            _position = new Vector2(40, 50);
        }

        public override void Draw() {
            PongolessGame.Instance.SpriteBatch.Draw(_texture, _position, _color);
        }

        public override void Update(GameTime gameTime) {
            _position.X += (float) (_speed * gameTime.ElapsedGameTime.TotalSeconds);
        }
    }
}
