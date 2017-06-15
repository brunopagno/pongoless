using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace pongoless.core {
    public static class DrawHelper {

        private static Rectangle _screenRect;

        public static void Draw(Texture2D texture, Vector2 position, float width, float height, Color color) {
            WorldCoords.WorldToScreen(position, width, height, out _screenRect);
            PongolessGame.Instance.SpriteBatch.Draw(texture, _screenRect, color);
        }

    }
}
