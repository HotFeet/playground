using System;
using System.IO;

namespace HotFeet.FunStuff.Text2MindMap {
	public class ListItemReader : INodeReader{
		bool Detect(LineReader reader) {
			return reader.CurrentLine.StartsWith("-");
		}
		
		Node Process(LineReader reader) {
			string text = reader.CurrentLine.Substring(1).Trim();
			Advance(1);
			return new Node(text, Category.Item); 
		}
	} 
}