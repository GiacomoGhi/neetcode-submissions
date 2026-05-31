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
    public int KthSmallest(TreeNode root, int k) {
        List<int> values = [];
        InorderVisit(root);

        return values.Count >= k ? values[k - 1] : -1;

        void InorderVisit(TreeNode root)
        {
            if (root is null)
            {
                return;
            }

            InorderVisit(root.left);
            values.Add(root.val);
            InorderVisit(root.right);
        }
    }
}
