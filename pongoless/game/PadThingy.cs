using pongoless.core;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace pongoless.game {
    public class PadThingy : GameObject {
        private Texture2D _texture;
        private int _width, _height;
        private float _speed;
        private int _movement = 0;

        public PadThingy(Color color, int origin) {
            _width = 16;
            _height = 48;
            _color = color;
            _speed = 8;
            _texture = ImageHandler.CreateTexture(Color.White, _width, _height);
            _position = new Vector2(origin, 250);
        }

        public void MoveUp() {
            _movement = -1;
        }

        public void MoveDown() {
           _movement = 1;
        }

        public void Halt() {
            _movement = 0;
        }

        public override void Draw() {
            PongolessGame.Instance.SpriteBatch.Draw(_texture, _position, _color);
        }

        public override void Update(GameTime gameTime) {
            _position.Y += _movement * _speed;
        }
    }
}
