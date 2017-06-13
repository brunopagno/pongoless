using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace pongoless.game {
    public class Round {
        private BallThingy ball;
        private Player playerOne;
        private Player playerTwo;

        public Round() {
            ball = new BallThingy();
            playerOne = new Player(Color.Coral, Keys.A, Keys.Z, 10);
            playerTwo = new Player(Color.CadetBlue, Keys.Up, Keys.Down, 300);
        }

        internal void Draw(GameTime gameTime) {
            PongolessGame.Instance.SpriteBatch.Begin(SpriteSortMode.Immediate);

            ball.Draw();
            playerOne.Draw();
            playerTwo.Draw();

            PongolessGame.Instance.SpriteBatch.End();
        }

        internal void Update(GameTime gameTime) {
            ball.Update(gameTime);
            playerOne.Update(gameTime);
            playerTwo.Update(gameTime);
        }
    }
}
