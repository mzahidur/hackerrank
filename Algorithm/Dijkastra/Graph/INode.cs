using System;
using System.Collections.Generic;

namespace Algorithm.Dijkastra.Graph
{
    public interface INode
    {
        uint Key { get; }
    }

    public interface INode<T, TEdgeCustom> : INode, IEnumerable<Edge<T, TEdgeCustom>> where TEdgeCustom : IEquatable<TEdgeCustom>
    {
        T Item { get; }
    }
}