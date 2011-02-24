using System;
using System.IO;

namespace HotFeet.FunStuff.Text2MindMap {
	enum Category {
		Title,
		Item,
		Garbage
	}

	public class Node {
		public Node(string text, Category category) {
			Text = text;
			Category = category; 
		}

		public string Text { get; private set; }
		public Category Category { get; private set; }
		public int? Level { get; set; }
	}
}