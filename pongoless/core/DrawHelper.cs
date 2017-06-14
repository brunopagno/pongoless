using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace pongoless.core {
    public static class DrawHelper {

        private static Vector2 _screenPosition;

        public static void Draw(Texture2D texture, Vector2 position, Color color) {
            WorldCoords.WorldToScreen(position, out _screenPosition);
            PongolessGame.Instance.SpriteBatch.Draw(texture, _screenPosition, color);
        }

    }
}
