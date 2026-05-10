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

    q = [4, 5]

    res = 
    [
        0,
        3,
    ];

    level = 2;

 */

public class Solution {
    public List<int> RightSideView(TreeNode root) {
        if (root is null)
        {
            return [];
        }

        Queue<TreeNode> queue = new();
        queue.Enqueue(root);

        int level = 0;
        List<int> res = [];
        while (queue.Count > 0)
        {
            int nodesCount = queue.Count;
            for (int i = 0; i < nodesCount; i++)
            {
                var node = queue.Dequeue();
                if (res.Count == level)
                {
                    res.Add(node.val);
                }
                else
                {
                    res[level] = node.val;
                }

                if (node.left is not null)
                {
                    queue.Enqueue(node.left);
                }

                if (node.right is not null)
                {
                    queue.Enqueue(node.right);
                }
            }

            level++;
        }

        return res;
    }
}
