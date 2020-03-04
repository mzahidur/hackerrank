using System;

namespace Algorithm.Dijkastra.ShortestPath
{
    public interface IDijkstraGraph
    {
        Action<Edge> this[uint node] { get; }
    }
}