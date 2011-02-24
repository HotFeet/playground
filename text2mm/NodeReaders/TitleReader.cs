using System;
using System.IO;

namespace HotFeet.FunStuff.Text2MindMap {
	public class TitleReader : INodeReader {
		char[] levelChars = {'=', '-'}; 

		bool IsFilledWith(string line, char levelChar) {
			if(line == String.Empty)
				return false;			
		}	
		
		public bool Detect(LineReader reader) {
			if(reader.NextLine == null)
				return false;
			
			foreach(char c in levelChars) {
				if(IsFilledWith(reader.NextLine, c))
					return true;
			}
			return false;
		}
		
		int DetectTitleLevel(LineReader reader) {
			for(int i = 0; i < levelChars.Length; i++) {
				if(IsFilledWith(reader.NextLine, i))
					return i;
			}
			throw new ApplicationException("Detect and Process methods give different results.");
		}

		public Node Process(LineReader reader) {
			return new Node(reader.CurrentLine, Category.Title) {
				Level = DetectTitleLevel(reader.NextLine)
			};
		}
	}
}