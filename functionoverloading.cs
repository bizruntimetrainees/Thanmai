class Projector
{
  public static void Display( string str )
  {
    System.Console.WriteLine( str );
  } 
  public static void Display( int number )
  {
    System.Console.WriteLine( number);
  } 
  public static void Display( char c )
  {
    System.Console.WriteLine( c );
  } 
  public static void Main()
  {
    Display( "Hello" );
    Display( 1234 );
    Display( 'A' );
  }
}