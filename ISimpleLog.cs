namespace Delegates_Tutorial_C_Sharp
{
	interface ISimpleLog
	{
		void ToConsole ( string txt , MessageType type );
		void ToFile ( string txt , MessageType type );
	}
}
