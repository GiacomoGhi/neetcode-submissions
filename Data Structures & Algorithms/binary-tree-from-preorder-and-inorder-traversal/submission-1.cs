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

        var inorderIndexesByValue = new Dictionary<int, int>(inorder.Length);
        for (int i = 0; i < inorder.Length; i++)
        {
            inorderIndexesByValue.Add(inorder[i], i);
        }
        var preorderIx = 0;

        return Dfs(0, inorder.Length - 1);

        TreeNode Dfs(int s, int e)
        {
            if (s > e)
            {
                return null;
            }

            var rootVal = preorder[preorderIx++];
            var root = new TreeNode(rootVal);

            var rootIx = inorderIndexesByValue[rootVal];
            root.left = Dfs(s, rootIx - 1);
            root.right = Dfs(rootIx + 1, e);

            return root;
        }
    }
}
