using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SRWE
{
	static class Program
	{
		public static string[] Args;

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			Args = args;

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
