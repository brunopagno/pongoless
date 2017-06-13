using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace pongoless.core {
    public class ImageHandler {

        public static Texture2D CreateTexture(Color color, int width, int height) {
            var texture = new Texture2D(PongolessGame.Instance.GraphicsDevice, width, height, false, SurfaceFormat.Color);
            Color[] textureData = new Color[width * height];
            for (int i = 0; i < textureData.Length; i++) {
                textureData[i] = Color.White;
            }
            texture.SetData<Color>(textureData);
            return texture;
        }

    }
}
