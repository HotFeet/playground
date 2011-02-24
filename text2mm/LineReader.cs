using System;
using System.IO;

namespace HotFeet.FunStuff.Text2MindMap {
	public class LineReader {
		string[] lines;
		int pos;

		public LineReader(string[] text) {
			lines = text;
			pos = 0;
		}

		string GetLine(index) {
			if(index >= lines.Length)
				return null;
			
			return lines[index].Trim(' ');
		}

		public string CurrentLine { get { return GetLine(pos); } }
		public string NextLine { get { return GetLine(pos + 1); } }

		public void Advance(int numberOfLines) {
			lines += numberOfLines;
		}
	}
}