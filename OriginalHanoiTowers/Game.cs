namespace OriginalHanoiTowers
{
    internal class Game
    {
        private readonly Tower[] _towers;

        public Game()
        {
            _towers = new Tower[]
            {
                new Tower(1, 3, 5, 7),
                new Tower(2),
                new Tower(3)
            };
        }

        public void MoveDisc(int fromTowerIndex, int toTowerIndex)
        {
            var fromTower = _towers[fromTowerIndex];
            var disc = fromTower.GetDisc();
            var toTower = _towers[toTowerIndex];
            toTower.ReceiveDisc(disc);
        }

        public bool IsSolved()
        {
            return false;
        }

        public void Show()
        {
            foreach (var tower in _towers)
            {
                tower.Show();
            }
        }
    }
}
