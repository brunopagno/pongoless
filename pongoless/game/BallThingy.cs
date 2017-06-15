using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using pongoless.core;
using System;

namespace pongoless.game {
    public class BallThingy : GameObject {
        private Texture2D _texture;
        private float _speed;
        private float _size;

        private Vector2 _direction;
        private Round _round;

        public BallThingy(Round round) {
            _round = round;
            _size = 2f;
            _color = Color.White;
            _speed = 50;
            _texture = ImageHandler.CreateTexture(Color.White, (int)_size, (int)_size);

            Reset();
        }

        public void Reset() {
            _position = new Vector2(50 - _size / 2, 50 - _size / 2);
            _direction = new Vector2(RandomHandler.MinusOneToOne(), RandomHandler.MinusOneToOne());
            _direction.Normalize();
        }

        public override void Draw() {
            DrawHelper.Draw(_texture, _position, _size, _size, _color);
        }

        public override void Update(GameTime gameTime) {
            if (Keyboard.GetState().IsKeyDown(Keys.R)) {
                Reset();
            }

            _position.X += (float)(_direction.X * _speed * gameTime.ElapsedGameTime.TotalSeconds);
            _position.Y += (float)(_direction.Y * _speed * gameTime.ElapsedGameTime.TotalSeconds);
            if (_position.X + _size > WorldCoords.RightLimit || _position.X < WorldCoords.LeftLimit) {
                Reset();
            }
            if (_position.Y + _size > WorldCoords.BotLimit || _position.Y < WorldCoords.TopLimit) {
                _direction.Y *= -1;
            }

            if (_round.PadOne.Position.X + _round.PadOne.Width > _position.X && _round.PadOne.Position.X < _position.X &&
                (_round.PadOne.Position.Y < _position.Y && _round.PadOne.Position.Y + _round.PadOne.Height > _position.Y ||
                _round.PadOne.Position.Y < _position.Y + _size && _round.PadOne.Position.Y + _round.PadOne.Height > _position.Y + _size)) {
                _direction.X = Math.Abs(_direction.X);
            }

            if (_round.PadTwo.Position.X < _position.X + _size && _round.PadTwo.Position.X + _round.PadTwo.Width > _position.X + _size &&
                (_round.PadTwo.Position.Y < _position.Y && _round.PadTwo.Position.Y + _round.PadTwo.Height > _position.Y ||
                _round.PadTwo.Position.Y < _position.Y + _size && _round.PadTwo.Position.Y + _round.PadTwo.Height > _position.Y + _size)) {
                _direction.X = -Math.Abs(_direction.X);
            }
        }
    }
}
