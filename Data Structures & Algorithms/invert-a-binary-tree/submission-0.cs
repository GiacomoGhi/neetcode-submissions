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

public class Solution {
    public TreeNode InvertTree(TreeNode root) {
        if (root is null)
        {
            return null;
        }

        Queue<TreeNode> q = new();
        q.Enqueue(root);

        while (q.Count > 0)
        {
            int qc = q.Count;
            for (int i = 0; i < qc; i++)
            {
                var node = q.Dequeue();
                var t = node.left;
                node.left = node.right;
                node.right = t;

                if (node.left is not null)
                {
                    q.Enqueue(node.left);
                }

                if (node.right is not null)
                {
                    q.Enqueue(node.right);
                }
            }
        }

        return root;
    }
}
