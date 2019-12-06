using System;
using System.Collections.Generic;
using System.Linq;

namespace Common
{
    public static class Graph
    {
        public static int ShortestDistanceBfs<T>(T from, T to, Dictionary<T, T[]> paths)
        {
            var explored = new HashSet<T>();
            var exploreQueue = new List<(T loc, int dist)>() { (from, 0) };

            while (exploreQueue.Count > 0)
            {
                var (loc, dist) = exploreQueue[0];
                exploreQueue.RemoveAt(0);

                if (explored.Add(loc))
                {
                    var newDist = dist + 1;
                    if (paths.TryGetValue(loc, out var reachableFromHere))
                    {
                        var unexploredAndReachable = reachableFromHere.Where(dest => !explored.Contains(dest));

                        if (unexploredAndReachable.Contains(to))
                        {
                            return newDist;
                        }

                        foreach (var newDest in unexploredAndReachable)
                        {
                            exploreQueue.Add((newDest, newDist));
                        }
                    }
                }
            }

            throw new Exception("No path found.");
        }
    }
}
