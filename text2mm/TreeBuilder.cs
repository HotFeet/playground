using System;
using System.IO;

namespace HotFeet.FunStuff.Text2MindMap {
	public class TreeBuilder {
		TreeNode root, cur;

		public void Add(Node n) {
			if(n == null)
				return;
			
			// FIXME!
			// cur = ...;
			
			if(root == null)
				root = cur;
		}
		
		public TreeNode Root { get { return root; } }
	}
}