using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructures.LeetCode
{
    internal class _1514_PathWithMaxProbability
    {
        private static double MaxProbability(int n, int[][] edges, double[] probabilities, int start, int end)
        {
            // Create an adjacency list to represent the graph
            var graph = new List<(int, double)>[n];
            for (int i = 0; i < n; i++)
            {
                graph[i] = new List<(int, double)>();
            }

            // Populate the graph with edges and their corresponding probabilities
            for (int i = 0; i < edges.Length; i++)
            {
                int u = edges[i][0];
                int v = edges[i][1];
                double prob = probabilities[i];
                graph[u].Add((v, prob));
                graph[v].Add((u, prob));
            }

            // Max-Heap to store the nodes along with their current best probability to reach those nodes
            var maxHeap = new PriorityQueue<(int, double), double>(Comparer<double>.Create((a, b) => b.CompareTo(a)));
            maxHeap.Enqueue((start, 1), 1);

            // Array to store the maximum probability to reach each node
            var result = new double[n];
            result[start] = 1;

            // Dijkstra's algorithm to find the maximum probability path
            while (maxHeap.Count > 0)
            {
                var (node, prob) = maxHeap.Dequeue();

                //if (node == end)
                //{
                //    return prob;
                //}

                foreach (var (nextNode, edgeProb) in graph[node])
                {
                    double newProb = prob * edgeProb;
                    if (newProb > result[nextNode])
                    {
                        result[nextNode] = newProb;
                        maxHeap.Enqueue((nextNode, newProb), newProb);
                    }
                }
            }

            return result[end];
        }

        public static void Test()
        {
            // Test case - 1
            int n = 3;
            int[][] edges = [[0, 1], [1, 2], [0, 2]];
            double[] probabilities = [0.5, 0.5, 0.2];
            int start = 0;
            int end = 2;
            Console.WriteLine(MaxProbability(n, edges, probabilities, start, end));

            // Test case - 2
            n = 3;
            edges = [[0, 1], [1, 2], [0, 2]];
            probabilities = [0.5, 0.5, 0.3];
            start = 0;
            end = 2;
            Console.WriteLine(MaxProbability(n, edges, probabilities, start, end));

            // Test case - 3
            n = 3;
            edges = [[0, 1]];
            probabilities = [0.5];
            start = 0;
            end = 2;
            Console.WriteLine(MaxProbability(n, edges, probabilities, start, end));

            // Test case - 4
            n = 3;
            edges = [[0, 1]];
            probabilities = [0.5];
            start = 0;
            end = 1;
            Console.WriteLine(MaxProbability(n, edges, probabilities, start, end));
        }
    }
}
