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
    public TreeNode DeleteNode(TreeNode root, int key) {
        if (root is null)
        {
            return null;
        }

        if (root.val > key)
        {
            root.left = DeleteNode(root.left, key);
        }
        else if (root.val < key)
        {
            root.right = DeleteNode(root.right, key);
        }
        else
        {
            if (root.left is null)
            {
                return root.right;
            }
            else if (root.right is null)
            {
                return root.left;
            }

            var minNode = FindMinNode(root.right);
            root.val = minNode.val;
            root.right = DeleteNode(root.right, minNode.val);
        }

        return root;
    }

    private TreeNode FindMinNode(TreeNode root)
    {
        while (root is not null && root.left is not null)
        {
            root = root.left;
        }

        return root;
    }
}