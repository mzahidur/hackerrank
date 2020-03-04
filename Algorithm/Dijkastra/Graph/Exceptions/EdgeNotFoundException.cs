using System;

namespace Algorithm.Dijkastra.Graph.Exceptions
{
    public class EdgeNotFoundException: Exception
    {
        internal EdgeNotFoundException(uint node)
            :base($"Edge with {node} node key doesn't exist.")
        {
        }
    }
}