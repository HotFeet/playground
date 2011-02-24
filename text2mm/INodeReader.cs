using System;
using System.IO;

namespace HotFeet.FunStuff.Text2MindMap {
	public interface INodeReader {
		// pre-condition: (reader != null && reader.Current != null)
		public bool Detect(LineReader reader);
		
		// pre-condition: (reader != null && Detect(reader))
		public Node Process(LineReader reader);
	} 
}