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
    public List<int> InorderTraversal(TreeNode root) {
        List<int> res = [];

        InorderVisit(root);
        return res;

        void InorderVisit(TreeNode root)
        {
            if (root is null)
            {
                return;
            }

            InorderVisit(root.left);
            res.Add(root.val);
            InorderVisit(root.right);
        }
    }
}