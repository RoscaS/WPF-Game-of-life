using System;
using System.Collections.Generic;

namespace GOL_Sol
{
    public class Cell : Point2D
    {
        public static int Count { get; private set; }
        public bool IsSet { get; private set; }
        public List<Cell> Neighbors { get; private set; }

        public Cell(int x, int y) : base(x, y) { }

        public void UpdateState() {
            Count += IsSet ? -1 : 1;
            IsSet = !IsSet;
        }

        public void SetNeighbors() {
            Cell C(int x, int y) => new Cell(x, y);
            Neighbors = new List<Cell> {
                C(X - 1, Y - 1), C(X, Y - 1), C(X + 1, Y - 1),
                C(X - 1, Y), C(X + 1, Y),
                C(X - 1, Y + 1), C(X, Y + 1), C(X + 1, Y + 1)
            };
        }

        public override string ToString() {
            var alive = IsSet ? "alive" : "dead";
            return $"Cell ({X},{Y}): {alive}";
        }
    }
}