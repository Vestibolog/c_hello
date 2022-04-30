Console.WriteLine( "Введите имя пользователя" );
string userName = Console.ReadLine();

if ( userName.ToLower() == "рома" )
{
    Console.WriteLine( "Ура это же Рома !!!" );
} else
{
    Console.Write( "Привет,  " );
    Console.WriteLine( userName );
}