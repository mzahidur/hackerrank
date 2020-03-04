using System;

namespace Algorithm.Dijkastra.Graph
{
    public interface IGraph<T, TEdgeCustom> where TEdgeCustom : IEquatable<TEdgeCustom>
    {
        INode<T, TEdgeCustom> this[uint node] { get; }
    }
}
