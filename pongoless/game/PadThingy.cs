using pongoless.core;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace pongoless.game {
    public class PadThingy : GameObject {
        private Texture2D _texture;
        private int _width, _height;
        private int _speed;
        private int _movement = 0;

        public PadThingy(Color color, int origin) {
            _width = 16;
            _height = 48;
            _color = color;
            _speed = 50;
            _texture = ImageHandler.CreateTexture(Color.White, _width, _height);
            _position = new Vector2(origin, 40);
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
            DrawHelper.Draw(_texture, _position, _color);
        }

        public override void Update(GameTime gameTime) {
            _position.Y += (float)(_movement * _speed * gameTime.ElapsedGameTime.TotalSeconds);
        }
    }
}
