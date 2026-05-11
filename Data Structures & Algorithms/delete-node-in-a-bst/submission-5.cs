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
        if (root.val == key)
        {
            return DeleteNodeInternal(root);
        }

        var curr = root;
        while (curr is not null)
        {
            if (curr.val > key)
            {
                if (curr.left?.val == key)
                {
                    curr.left = DeleteNodeInternal(curr.left);
                }
                curr = curr.left;
            }
            else
            {
                if (curr.right?.val == key)
                {
                    curr.right = DeleteNodeInternal(curr.right);
                }
                curr = curr.right;
            }
        }

        return root;

    }
    private TreeNode DeleteNodeInternal(TreeNode node)
    {
        if (node.left is null || node.right is null)
        {
            return node.left ?? node.right;
        }

        node.val = FindMinVal(node.right);
        node.right = DeleteNode(node.right, node.val);

        return node;
    }

    private int FindMinVal(TreeNode node)
    {
        if (node.left is null)
        {
            return node.val;
        }

        return FindMinVal(node.left);
    }
}