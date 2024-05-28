using OriginalHanoiTowers;

var game = new Game();
while (!game.IsSolved())
{
    game.Show();
    var fromIndex = MyConsole.AskForNoAndReturnIndex(7, "Flytte disc fra tårn: ");
    var toIndex = MyConsole.AskForNoAndReturnIndex(8, "Flytte disc til tårn: ");
    game.MoveDisc(fromIndex, toIndex);
}