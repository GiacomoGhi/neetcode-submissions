/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        if (node is null)
        {
            return null;
        }
    
        Queue<(Node, Node)> q = [];
        HashSet<int> visited = [];
        Dictionary<int, Node> clones = [];

        Node head = new(node.val);
        clones.Add(node.val, head);
        q.Enqueue((node, head));

        while (q.Count > 0)
        {
            int qc = q.Count;
            for (int i = 0; i < qc; i++)
            {
                var (curr, copy) = q.Dequeue();
                if (visited.Contains(curr.val))
                {
                    continue;
                }
                visited.Add(curr.val);

                foreach (var n in curr.neighbors)
                {
                    if (!clones.TryGetValue(n.val, out var ncopy))
                    {
                        ncopy = new(n.val);
                        clones[n.val] = ncopy;
                    }

                    copy.neighbors.Add(ncopy);
                    q.Enqueue((n, ncopy));
                }
            }
        }

        return head;
    }
}
