using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MJNOCR
{
	class Program
	{
		static void Main(string[] args)
		{
			var mainDir = new DirectoryInfo(@"D:\D\Projekty\NEATCODE\MJN\Data\mjn2016\");

			var dirs = mainDir.GetDirectories();

			foreach (var dir in dirs)
			{
				var txtFiles = dir.GetFiles("*.txt").OrderBy(x=>x.Name).ToList();
				var result = "";
				foreach (var f in txtFiles)
				{
					result += File.ReadAllText(f.FullName);
				}
				var s = File.CreateText(Path.Combine(dir.FullName, dir.Name + ".txt"));
				s.Write(result);
				s.Close();
			}

		}
	}
}
