using System;
using System.IO;

namespace Delegates_Tutorial_C_Sharp
{
	/// <summary>
	/// Class for write a log, to file or to console
	/// </summary>
	internal class SimpleLog : ISimpleLog
	{
		private DateTime _date;

		/// <summary>
		/// Write a log to console
		/// </summary>
		/// <param name="txt">text to be writer</param>
		/// <param name="type">type of log</param>
		public void ToConsole ( string txt , MessageType type )
		{
			_date = DateTime.Now;
			Console.WriteLine ( $"{type} - {txt} - {_date}" );
		}

		/// <summary>
		/// Write a log to file
		/// </summary>
		/// <param name="txt">text to be writer</param>
		/// <param name="type">type of log</param>
		public void ToFile ( string txt , MessageType type )
		{
			_date = DateTime.Now;
			using StreamWriter stringWriter = new ( Path.Combine ( AppDomain.CurrentDomain.BaseDirectory , @"MySimpleLog.txt" ) , true );
			stringWriter.WriteLine ( $"{type} - {txt} - {_date}" );
		}
	}
}
