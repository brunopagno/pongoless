using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using pongoless.core;
using pongoless.game;

namespace pongoless
{
    public class PongolessGame : Game
    {
        private static PongolessGame _instance;
        public static PongolessGame Instance {
            get {
                return _instance;
            }
        }
        internal static void InitializeInstance() {
            if (_instance == null) {
                _instance = new PongolessGame();
            }
        }

        public GraphicsDeviceManager graphics;
        public SpriteBatch SpriteBatch;

        private Round _round;
        private Color _bgColor;

        private PongolessGame()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            base.Initialize();
            WorldCoords.Initialize();

            _round = new Round();
            _bgColor = new Color(0.1f, 0.1f, 0.1f);
        }

        protected override void LoadContent()
        {
            SpriteBatch = new SpriteBatch(GraphicsDevice);
            AudioHandler.Initialize();
        }

        protected override void Update(GameTime gameTime)
        {
            _round.Update(gameTime);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(_bgColor);
            base.Draw(gameTime);
            _round.Draw(gameTime);
        }
    }
}
