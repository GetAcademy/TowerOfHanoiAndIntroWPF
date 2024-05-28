namespace OriginalHanoiTowers
{
    internal class Tower
    {
        private Disc[] _discs;
        private int _position;

        public Tower(int position, params int[] discSizes)
        {
            _position = position;
            _discs = new Disc[3];
            for (var index = 0; index < discSizes.Length; index++)
            {
                var size = discSizes[index];
                _discs[index] = new Disc(size);
            }
        }

        public Disc GetDisc()
        {
            return _discs[0];
        }

        public void ReceiveDisc(Disc disc)
        {
            _discs[0] = disc;
        }

        public void Show()
        {
            var row = 4;
            foreach (var disc in _discs.Reverse())
            {
                disc?.Show(row, _position);
                row--;
            }
            MyConsole.Write(5, 2 + (_position - 1) * 15, "OOOOOOOOO");
        }
    }
}
