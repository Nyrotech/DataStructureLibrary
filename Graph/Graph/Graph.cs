namespace Graph
{
	public class Graph
	{
		//Declare the basic core variables
		private int V;
		private bool Direction;
		LinkedList<int>[] adjacent;
		private int count;


		//Constructor
		public Graph(int V, bool Direction)
		{
			adjacent = new LinkedList<int>[V];
			for (int i = 0; i < adjacent.Length; i++)
			{
				adjacent[i] = new LinkedList<int>();
			}
			this.V = V;
			this.Direction = Direction;
		}

		//Function to add edges to graph
		public void AddEdge(int V, int w)
		{
			adjacent[V].AddLast(w);
			if (!Direction)
			{
				adjacent[w].AddLast(V);
			}
		}

		//Function to find all vetricies in a graph
		public List<string> FindV(string[] lines)
		{
			var VList = new List<string>();
			for (int i = 0; i < lines.Length; i++)
			{
				lines[i] = lines[i].Split(' ')[0];
				VList.Add(lines[i]);
			}

			for (int j = 0; j < VList.Count; j++)
			{
				Console.Write(VList[j]);
			}

			return VList;
		}
	}
}
