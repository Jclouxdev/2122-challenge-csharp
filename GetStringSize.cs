namespace CSharpDiscovery.Quest01
{
    public class GetStringSize_Exercice
    {
        public static int GetStringSize(string str)
        {
           char[] charArray = str.ToCharArray();
           return(charArray.Length);
        }
    }
}