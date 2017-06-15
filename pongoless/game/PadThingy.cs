using pongoless.core;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace pongoless.game {
    public class PadThingy : GameObject {
        private Texture2D _texture;
        private float _width;
        public float Width {
            get { return _width; }
        }
        private float _height;
        public float Height {
            get { return _height; }
        }
        private int _speed;
        private int _movement = 0;

        public PadThingy(Color color, int origin) {
            _width = 2f;
            _height = 12;
            _color = color;
            _speed = 50;
            _texture = ImageHandler.CreateTexture(Color.White, (int)_width, (int)_height);
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
            DrawHelper.Draw(_texture, _position, _width, _height, _color);
        }

        public override void Update(GameTime gameTime) {
            _position.Y += (float)(_movement * _speed * gameTime.ElapsedGameTime.TotalSeconds);

            if (_position.Y < WorldCoords.TopLimit) {
                _position.Y = WorldCoords.TopLimit;
            }

            if (_position.Y + _height > WorldCoords.BotLimit) {
                _position.Y = WorldCoords.BotLimit - _height;
            }
        }
    }
}
