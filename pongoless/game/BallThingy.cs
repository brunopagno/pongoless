using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using pongoless.core;
using System;

namespace pongoless.game {
    public class BallThingy : GameObject {
        private Texture2D _texture;
        private float _speed;
        private int _size;

        private Vector2 _direction;

        public BallThingy() {
            _size = 12;
            _color = Color.White;
            _speed = 30;
            _texture = ImageHandler.CreateTexture(Color.White, _size, _size);

            Reset();
        }

        public void Reset() {
            _position = new Vector2(50, 50);
            _direction = new Vector2(RandomHandler.MinusOneToOne(), RandomHandler.MinusOneToOne());
            _direction.Normalize();
        }

        public override void Draw() {
            DrawHelper.Draw(_texture, _position, _color);
        }

        public override void Update(GameTime gameTime) {
            _position.X += (float)(_direction.X * _speed * gameTime.ElapsedGameTime.TotalSeconds);
            _position.Y += (float)(_direction.Y * _speed * gameTime.ElapsedGameTime.TotalSeconds);
            if (_position.X > WorldCoords.RightLimit || _position.X < WorldCoords.LeftLimit) {
                Reset();
            }
            if (_position.Y > WorldCoords.TopLimit || _position.Y < WorldCoords.BotLimit) {
                _direction.Y *= -1;
            }
        }
    }
}
