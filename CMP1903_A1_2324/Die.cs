
    {
        private Random randomGenerator;

        public Die()
        {
            randomGenerator = new Random();
        }

        public int RollDie()
        {
            return randomGenerator.Next(1, 7);
        }
    }
}
