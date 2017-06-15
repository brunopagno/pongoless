using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pongoless.game {
    public class Player {
        private PadThingy _pad;
        public PadThingy Pad {
            get { return _pad; }
        }

        private Keys _moveUp;
        private Keys _moveDown;

        public Player(Color color, Keys moveUp, Keys moveDown, int position) {
            _pad = new PadThingy(color, position);
            _moveUp = moveUp;
            _moveDown = moveDown;
        }

        public void Draw() {
            _pad.Draw();
        }

        public void Update(GameTime gameTime) {
            bool moveUp = Keyboard.GetState().IsKeyDown(_moveUp);
            bool moveDown = Keyboard.GetState().IsKeyDown(_moveDown);

            if (moveUp) {
                _pad.MoveUp();
            }
            if (moveDown) {
                _pad.MoveDown();
            }

            if (!moveUp && !moveDown) {
                _pad.Halt();
            }

            _pad.Update(gameTime);
        }

    }
}
