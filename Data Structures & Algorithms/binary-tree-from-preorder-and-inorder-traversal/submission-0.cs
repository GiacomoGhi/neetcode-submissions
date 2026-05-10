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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        if (preorder.Length == 0)
        {
            return null;
        }

        var root = new TreeNode(preorder[0]);
        var mid = Array.IndexOf(inorder, root.val);
        root.left = BuildTree([.. preorder.Skip(1).Take(mid)], [.. inorder.Take(mid)]);
        root.right = BuildTree([.. preorder.Skip(mid + 1)], [.. inorder.Skip(mid + 1)]);
        return root;
    }
}
