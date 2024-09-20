namespace Abstraction_Interfaces3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var player = new Player();
            player.Draw();
            player.Move(10, 20);

        }
    }

    public interface IDrawable
    {
        void Draw();
    }

    public interface IMovable
    {
        void Move(int x, int y);
    }

    public class Player : IDrawable, IMovable
    {
        public void Draw() => Console.WriteLine("Drawing Player");
        public void Move(int x, int y) => Console.WriteLine($"Player moved to position ({x}, {y})");
    }

}
