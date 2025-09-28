using DataStructuresAndAlgorithms.DataStructures.Linear.Queues;

namespace DataStructuresAndAlgorithms.DataStructures.NonLinear.Graphs
{
    public class Graph
    {
        private int verticesCount;
        int[,] AdjMatrix;
        List<int>[] AdjacencyList;
        int[] visited;
        public Graph(int n)
        {
            verticesCount = n;
            AdjMatrix = new int[n, n];
            AdjacencyList = new List<int>[n];
            visited = new int[verticesCount];
            for (int i = 0; i < n; i++)
            {
                AdjacencyList[i] = new List<int>();
            }
        }
        public void InsertEdge(int u, int v, int w = 0)
        {
            AdjMatrix[u, v] = w;
        }

        public void RemoveEdge(int u, int v)
        {
            AdjMatrix[u, v] = 0;
        }

        public bool ExistEdge(int u, int v)
        {
            return AdjMatrix[u, v] != 0;
        }

        public int VertexCount() => verticesCount;
        public int EdgeCount()
        {
            int count = 0;
            for (int i = 0; i < verticesCount; i++)
            {
                for (int j = 0; j < verticesCount; j++)
                {
                    if (AdjMatrix[i, j] != 0)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public void Edges()
        {
            for (int i = 0; i < verticesCount; i++)
            {
                for (int j = 0; j < verticesCount; j++)
                {
                    if (AdjMatrix[i, j] != 0)
                    {
                        Console.WriteLine(i + "---" + j);
                    }
                }
            }
        }

        public int OutDegreeCount(int v)
        {
            int count = 0;
            for (int i = 0; i < verticesCount; i++)
            {
                if (AdjMatrix[v, i] != 0)
                {
                    count++;
                }
            }
            return count;
        }


        public int InDegreeCount(int v)
        {
            int count = 0;
            for (int i = 0; i < verticesCount; i++)
            {
                if (AdjMatrix[i, v] != 0)
                {
                    count++;
                }
            }
            return count;
        }

        public void Display()
        {
            for (int i = 0; i < verticesCount; i++)
            {
                for (int j = 0; j < verticesCount; j++)
                {
                    if (AdjMatrix[i, j] != 0)
                    {
                        Console.Write(AdjMatrix[i, j] + "\t");
                    }
                    else
                    {
                        Console.Write("0" + "\t");
                    }
                }
                Console.WriteLine();
            }
        }

        public void AddEdgeForAdjacencyList(int u, int v, bool isUnDirected = false)
        {
            AdjacencyList[u].Add(v);
            if (isUnDirected)
            {
                AdjacencyList[v].Add(u);
            }
        }

        public void BreadthFirstSearch(int startVertex)
        {
            ArrayBaseQueue<int> gaphQueue = new ArrayBaseQueue<int>();
            int[] visitedCheckArray = new int[verticesCount];
            int currentVertexIndex = startVertex;

            Console.Write(startVertex+ "\t");

            gaphQueue.Enqueue(startVertex);
            visitedCheckArray[currentVertexIndex] = 1;

            while (!gaphQueue.IsEmpty())
            {
                currentVertexIndex=gaphQueue.Dequeue();
                for (int j = 0; j < verticesCount; j++)
                {
                    if (AdjMatrix[currentVertexIndex, j] != 0 && visitedCheckArray[j]==0) {
                        Console.Write(j+ "\t");
                        visitedCheckArray[j] = 1;
                        gaphQueue.Enqueue(j);
                    }
                }
            }
            Console.WriteLine();
        }

        public void DepthFirstSearch(int startVertex)
        {

            if (visited[startVertex] == 0)
            {
                Console.Write(startVertex + " ");
                visited[startVertex] = 1;
                for (int j = 0; j < verticesCount; j++)
                    if (AdjMatrix[startVertex, j] == 1 && visited[j] == 0)
                        DepthFirstSearch(j);
            }


        }
    }
}
