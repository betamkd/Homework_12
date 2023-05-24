using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12
{
	public class AudioPlayer : IPlayable
	{
		public void Play() 
		{
			Console.WriteLine("You can now play the audio.");
		}
		public void Stop()
		{
			Console.WriteLine("The audio has stopped.");
		}
	}
}
