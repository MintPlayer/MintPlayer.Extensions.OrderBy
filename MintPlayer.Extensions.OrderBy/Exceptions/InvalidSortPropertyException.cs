namespace MintPlayer.Extensions.OrderBy
{
    public class InvalidSortPropertyException : Exception
    {
        public InvalidSortPropertyException() : base("The specified sorting property does not exist.")
        {
        }
    }
}
