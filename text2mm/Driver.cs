using System;
using System.IO;

namespace HotFeet.FunStuff.Text2MindMap {
	static class Driver {
		static INodeReader[] nodeReaders = {
			new TitleReader(),
			new TistItemReader(),
			new EmptyLineReader(),
			new GarbageReader()
		};

		static void Main(string[] args) {
			string input = args[0];
			string output = args[1];
			
			Parser p = new Parser(nodeReaders);
			List<Node> nodes = p.Parse(FIXME.ReadAllLines());
			
			TreeBuilder tb = new TreeBuilder();
			foreach(var n in nodes)
				tb.Add(n);
			
			RootNode root = tb.RootNode;
			var mmw = new MindMapWriter();
			 
		}
	} 
}