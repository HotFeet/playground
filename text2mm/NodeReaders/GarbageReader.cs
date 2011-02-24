using System;
using System.IO;

namespace HotFeet.FunStuff.Text2MindMap {
	public class GarbageReader : INodeReader{
		bool Detect(LineReader reader) {
			return true;
		}
		
		Node Process(LineReader reader) {
			Advance(1);
			return new Node(reader.CurrentLine, Category.Garbage); 
		}
	} 
}