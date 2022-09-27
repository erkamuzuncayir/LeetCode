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
    public TreeNode InvertTree(TreeNode root) 
    {
        // Avoids nullReferenceException
        if( root == null )
            return root;
        
        // Takes each side of nodes
        TreeNode leftNode = root.left;
        TreeNode rightNode = root.right;
        
        // Recurves them until they fully inverted
        root.right = InvertTree( leftNode );
        root.left = InvertTree( rightNode );
        
        return root;
    }
}
