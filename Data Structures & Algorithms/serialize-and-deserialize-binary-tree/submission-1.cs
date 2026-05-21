/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Codec {
    private const char _separator = '-';
    private const string _nan = "n";

    // Encodes a tree to a single string.
    public string Serialize(TreeNode root) {
        if (root is null)
        {
            return "";
        }

        var builder = new StringBuilder();
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        while (q.Count > 0)
        {
            int qc = q.Count;
            for (int i = 0; i < qc; i++)
            {
                var node = q.Dequeue();
                builder
                    .Append($"{(node?.val.ToString() ?? _nan)}")
                    .Append(_separator);

                if (node is not null)
                {
                    q.Enqueue(node.left);
                    q.Enqueue(node.right);
                }
            }
        }

        builder.Length--;
        return builder.ToString();
    }

    // Decodes your encoded data to tree.
    public TreeNode Deserialize(string data) {
        if (string.IsNullOrWhiteSpace(data))
        {
            return null;
        }

        string[] nodes = data.Split(_separator);
        var root = new TreeNode(int.Parse(nodes[0]));
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        int i = 1;

        while (q.Count > 0)
        {
            int qc = q.Count;
            for (int j = 0; j < qc; j++)
            {
                var node = q.Dequeue();
                if (i < nodes.Length && nodes[i] != _nan)
                {
                    node.left = new TreeNode(int.Parse(nodes[i]));
                    q.Enqueue(node.left);
                }
                i++;

                if (i < nodes.Length && nodes[i] != _nan)
                {
                    node.right = new TreeNode(int.Parse(nodes[i]));
                    q.Enqueue(node.right);
                }
                i++;
            }
        }

        return root;
    }
}
