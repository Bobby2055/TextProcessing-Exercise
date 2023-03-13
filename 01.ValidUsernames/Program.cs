namespace _01.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            
            foreach (string name in names) 
            {
                if (IsUserNameValid(name))
                {
                    Console.WriteLine(name);
                }
            }
        }

        static bool IsUserNameValid(string name)
        {
            if (name.Length < 3 || name.Length > 16)
            {
                return false;
            } 

            foreach (var character in name)
            {
                if (character != '_' && character != '-' && (character < 'a' || character > 'z') && (character < 'A' || character > 'Z') && (character < '0' || character > '9'))
                {
                    return false;
                }
            }
            
            return true;
        }
    }
}