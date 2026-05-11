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
    public bool HasPathSum(TreeNode root, int targetSum) {
        if (root is null)
        {
            return false;
        }

        return HasPathSumImpl(root, targetSum, 0);
    }

    private bool HasPathSumImpl(TreeNode root, int target, int sum)
    {
        if (root is null)
        {
            return false;
        }
        if (root.left is null && root.right is null)
        {
            return sum + root.val == target;
        }

        sum += root.val;
        if (HasPathSumImpl(root.left, target, sum))
        {
            return true;
        }

        if (HasPathSumImpl(root.right, target, sum))
        {
            return true;
        }

        sum -= root.val;
        return false;
    }
}