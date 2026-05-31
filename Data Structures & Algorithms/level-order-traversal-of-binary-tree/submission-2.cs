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

    q = [5, 6, 7];

    res = 
    [
        [1],
        [2, 3],
        [ , , , ]
    ]

 */
 

public class Solution {
    public List<List<int>> LevelOrder(TreeNode root) {
        if (root is null)
        {
            return [];
        }

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        List<List<int>> res = [];

        while (queue.Count > 0)
        {
            int nodesCount = queue.Count;
            List<int> valuesAtLevel = new(nodesCount);
            res.Add(valuesAtLevel);

            for (int i = 0; i < nodesCount; i++)
            {
                var node = queue.Dequeue();
                valuesAtLevel.Add(node.val);

                if (node.left is not null)
                {
                    queue.Enqueue(node.left);
                }
                
                if (node.right is not null)
                {
                    queue.Enqueue(node.right);
                }
            }
        }

        return res;
    }
}
