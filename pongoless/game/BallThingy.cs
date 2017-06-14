using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using pongoless.core;
using System;

namespace pongoless.game {
    public class BallThingy : GameObject {
        private Texture2D _texture;
        private float _speed;
        private int _size;

        public BallThingy() {
            _size = 12;
            _color = Color.White;
            _speed = 10;
            _texture = ImageHandler.CreateTexture(Color.White, _size, _size);
            _position = new Vector2(40, 50);
        }

        public override void Draw() {
            DrawHelper.Draw(_texture, _position, _color);
        }

        public override void Update(GameTime gameTime) {
            _position.X += (float)(_speed * gameTime.ElapsedGameTime.TotalSeconds);
        }
    }
}
