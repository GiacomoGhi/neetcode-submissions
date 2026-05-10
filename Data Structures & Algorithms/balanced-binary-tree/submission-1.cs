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
    public bool IsBalanced(TreeNode root) {

        bool isBalanced = true;
        CountHeight(root);

        return isBalanced;
        
        int CountHeight(TreeNode root)
        {
            if (root is null)
            {
                return 0;
            }

            int left = CountHeight(root.left) + 1;
            int right = CountHeight(root.right) + 1;

            if (Math.Abs(right - left) > 1)
            {
                isBalanced = false;
            }

            return left > right ? left : right;
        }
    }
}
