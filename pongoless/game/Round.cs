using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace pongoless.game {
    public class Round {
        private BallThingy ball;
        private Player playerOne;
        private Player playerTwo;

        public PadThingy PadOne {
            get {
                return playerOne.Pad;
            }
        }

        public PadThingy PadTwo {
            get {
                return playerTwo.Pad;
            }
        }

        public Round() {
            ball = new BallThingy(this);
            playerOne = new Player(Color.Coral, Keys.A, Keys.Z, 10);
            playerTwo = new Player(Color.CadetBlue, Keys.Up, Keys.Down, 90);
        }

        internal void Draw(GameTime gameTime) {
            PongolessGame.Instance.SpriteBatch.Begin(SpriteSortMode.Immediate);

            ball.Draw();
            playerOne.Draw();
            playerTwo.Draw();

            PongolessGame.Instance.SpriteBatch.End();
        }

        internal void Update(GameTime gameTime) {
            playerOne.Update(gameTime);
            playerTwo.Update(gameTime);
            ball.Update(gameTime);
        }
    }
}
