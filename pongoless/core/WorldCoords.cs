using System;
using Microsoft.Xna.Framework;

namespace pongoless.core {
    public static class WorldCoords {

        private static float _width;
        private static float _height;

        private static float _wRatio;
        private static float _hRatio;

        private static int _originalScreenWidth;
        private static int _originalScreenHeight;

        public static Vector2 Scale;

        public static void Initialize() {
            _width = 100;
            _height = 100;

            UpdateScreenStuff();

            PongolessGame.Instance.Window.ClientSizeChanged += Window_ClientSizeChanged;
            PongolessGame.Instance.Window.AllowUserResizing = true;

            _originalScreenWidth = PongolessGame.Instance.Window.ClientBounds.Width;
            _originalScreenHeight = PongolessGame.Instance.Window.ClientBounds.Height;

            Scale = Vector2.One;
        }

        private static void UpdateScreenStuff() {
            var bounds = PongolessGame.Instance.Window.ClientBounds;
            _wRatio = bounds.Width / _width;
            _hRatio = bounds.Height / _height;

            Scale = new Vector2((float)bounds.Width / _originalScreenWidth, (float)bounds.Height / _originalScreenHeight);
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
