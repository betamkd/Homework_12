using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12
{
	public class VideoPlayer : IPlayable
	{
		public void Play()
		{
			Console.WriteLine("You can now play the video.");
		}
		public void Stop()
		{
			Console.WriteLine("The video has stopped.");
		}
	}
}
