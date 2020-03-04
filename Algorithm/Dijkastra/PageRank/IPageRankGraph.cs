using System.Collections.Generic;

namespace Algorithm.Dijkastra.PageRank
{
    public interface IPageRankGraph : IEnumerable<uint>
    {
        int NodesCount { get; }

        int EdgesCount(uint node);

        IEnumerable<uint> Parents(uint node);
    }
}