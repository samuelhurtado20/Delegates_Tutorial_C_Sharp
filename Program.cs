using System;

namespace Delegates_Tutorial_C_Sharp
{
	class Program
	{
		/// <summary>
		/// Simple delegate
		/// </summary>
		/// <param name="txt">text to be writer</param>
		/// <param name="type">type of log</param>
		delegate void WriteLog ( string txt , MessageType type );

		static void Main ()
		{
			// Class for write a log, to file or to console
			SimpleLog simpleLog = new ( );

			// creating two delegates
			WriteLog writeLogConsole, writeLogToFile;
			writeLogConsole = new ( simpleLog.ToConsole );
			writeLogToFile = new ( simpleLog.ToFile );

			// creating a multi delegate
			WriteLog multi = writeLogConsole + writeLogToFile;

			Console.WriteLine ( "Tell me your name please:" );
			string name = Console.ReadLine ( );

			// using multi delegates for write the log
			multi ( name , MessageType.Information );

			Console.WriteLine ( @"Logs have been written successful" );
			Console.ReadKey ( );
		}
	}
}
