using System;
using System.IO;

namespace HotFeet.FunStuff.Text2MindMap {
	public class TreeNode {
		TreeNode parent;
		List<TreeNode> children = new List<TreeNode>();

		Node dataNode;

		public class TreeNode(TreeNode parentNode, Node dataNode) {
			this.dataNode = dataNode;
			this.parentNode = parentNode;

			if(parentNode != null)
				parentNode.Children.Add(node);
		}
		
		public TreeNode[] Children {
			get { return children.ToArray(); }
		}

		virtual int Depth {
			get { return (parent == null ? 0 : parent.Depth + 1; } 
		} 
	}
}