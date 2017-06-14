using System;
using Microsoft.Xna.Framework;

namespace pongoless.core {
    public static class WorldCoords {

        private static float _width;
        private static float _height;

        private static float _wRatio;
        private static float _hRatio;

        public static float Scale;

        public static void Initialize() {
            _width = 100;
            _height = 100;

            UpdateScreenStuff();

            PongolessGame.Instance.Window.ClientSizeChanged += Window_ClientSizeChanged;
            PongolessGame.Instance.Window.AllowUserResizing = true;

            
        }

        private static void UpdateScreenStuff() {
            _wRatio = PongolessGame.Instance.Window.ClientBounds.Width / _width;
            _hRatio = PongolessGame.Instance.Window.ClientBounds.Height / _height;
        }

        public static void WorldToScreen(Vector2 position, out Vector2 screenPosition) {
            screenPosition.X = position.X * _wRatio;
            screenPosition.Y = position.Y * _hRatio;
        }

        private static void Window_ClientSizeChanged(object sender, EventArgs e) {
            UpdateScreenStuff();
        }
    }
}
