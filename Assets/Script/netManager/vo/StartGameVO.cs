﻿using System;
using System.Collections.Generic;

namespace AssemblyCSharp
{
	[Serializable]
	public class StartGameVO
	{
		public List<List<int>> paiArray;
		public int bankerId;
        public int gui;
        public int touzi;

		public StartGameVO ()
		{
		}
	}
}

