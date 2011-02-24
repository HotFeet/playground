using System;
using System.IO;

namespace HotFeet.FunStuff.Text2MindMap {
	public static class Parser {
		INodeReader[] nodeReaders;
		
		/// NOTE: order of readers sets precedence
		public Parser(INodeReader[] readers) {
			nodeReaders = readers;
		}

		public List<Node> Parse(string[] lines) {
			var nodes = new List<Node>();
			var lineReader = new LineReader(lines);
			
			do {
				foreach(var nr in nodeReaders) {
					if(nr.Detect(lineReader)) {
						nodes.Add(nr.Process(lineReadear));
						break;
					}
				}
				
			} while(lineReader.CurrentLine != null);
			
			return nodes;
		}
	} 
}