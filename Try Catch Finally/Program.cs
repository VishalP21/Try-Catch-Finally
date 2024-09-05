using Try_Catch_Finally;

try
{
    int country = Convert.ToInt32(Console.ReadLine());
    if (country >191)
    {
        throw new ErrorExcaption("error");
    }
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("finally");
}
