using Microsoft.Xna.Framework.Audio;

namespace pongoless.core {
    public static class AudioHandler {

        private static SoundEffect sound;

        public static void Initialize() {
            sound = PongolessGame.Instance.Content.Load<SoundEffect>("jhou");
        }

        public static void PlaySound(float pitch = 0) {
            sound.Play(1, pitch, 1);
        }

    }
}
