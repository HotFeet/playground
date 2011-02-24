using System;
using System.IO;

namespace HotFeet.FunStuff.Text2MindMap {
	public class EmptyLineReader : INodeReader {
		bool Detect(LineReader reader) {
			return (reader.CurrentLine == String.Empty);
		}

		Node Process(LineReader reader) {
			reader.Advance(1);
			return null;
		}
	} 
}