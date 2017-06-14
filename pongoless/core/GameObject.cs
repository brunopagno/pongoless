using Microsoft.Xna.Framework;

namespace pongoless.core {
    public abstract class GameObject {
        protected Vector2 _position;
        protected Color _color;

        public abstract void Draw();

        public abstract void Update(GameTime gameTime);
    }
}
