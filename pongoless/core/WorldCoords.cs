﻿using System;
using Microsoft.Xna.Framework;

namespace pongoless.core {
    public static class WorldCoords {

        private static float _width;
        private static float _height;

        private static float _wRatio;
        private static float _hRatio;

        private static int _originalScreenWidth;
        private static int _originalScreenHeight;

        public static float RightLimit { get { return _width; } }
        public static float LeftLimit { get { return 0; } }
        public static float TopLimit { get { return 0; } }
        public static float BotLimit { get { return _height; } }

        public static void Initialize() {
            _width = 100;
            _height = 100;

            UpdateScreenStuff();

            PongolessGame.Instance.Window.ClientSizeChanged += Window_ClientSizeChanged;
            PongolessGame.Instance.Window.AllowUserResizing = true;

            _originalScreenWidth = PongolessGame.Instance.Window.ClientBounds.Width;
            _originalScreenHeight = PongolessGame.Instance.Window.ClientBounds.Height;
        }

        private static void UpdateScreenStuff() {
            var bounds = PongolessGame.Instance.Window.ClientBounds;
            _wRatio = bounds.Width / _width;
            _hRatio = bounds.Height / _height;
        }

        public static void WorldToScreen(Vector2 position, float width, float height, out Rectangle screenRect) {
            screenRect.X = (int)(position.X * _wRatio);
            screenRect.Y = (int)(position.Y * _hRatio);
            screenRect.Width = (int)(width * _wRatio);
            screenRect.Height = (int)(height * _hRatio);
        }

        private static void Window_ClientSizeChanged(object sender, EventArgs e) {
            UpdateScreenStuff();
        }
    }
}
