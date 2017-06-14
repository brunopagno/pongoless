
using System;

namespace pongoless.core {
    public static class RandomHandler {

        private static Random random = new Random();

        public static float Next() {
            return (float)random.NextDouble();
        }

        public static float MinusOneToOne() {
            return (float)(random.NextDouble() - 0.5f) * 2;
        }

    }
}
