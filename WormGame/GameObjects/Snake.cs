
namespace GameObjects
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Snake
    {
        private readonly List<Segment> segments;

        public Snake(int x, int y, uint size)
        {
            if (size == 0)
                throw new ArgumentException("Размер змеи не может быть равным 0", "size");
            segments = new List<Segment>();
            for (var i = 0; i < size; i++)
                segments.Add(new Segment(x, y + i));
            Direction = Direction.Up;
        }

        public Direction Direction { get; set; }

        public int Size
        {
            get { return segments.Count; }
        }

        public Segment this[int index]
        {
            get { return segments[index]; }
        }

        public void Move(int speed)
        {
            int x = 0, y = 0;
            switch (Direction)
            {
                case Direction.Up:
                    y = -speed;
                    break;
                case Direction.Down:
                    y = speed;
                    break;
                case Direction.Left:
                    x = -speed;
                    break;
                case Direction.Right:
                    x = speed;
                    break;
            }
            for (var i = Size - 1; i >= 1; i--)
            {
                segments[i].X = segments[i - 1].X;
                segments[i].Y = segments[i - 1].Y;
            }
            segments[0].X += x;
            segments[0].Y += y;
        }
    }
}
