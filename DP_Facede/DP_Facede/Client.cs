using System;


namespace DP_Facede
{
    class Client
    {
        public static void ClientCode(Absher absher)
        {
            string userId = "0000007701";
            foreach (var line in absher.HomePage(userId))
            {
                Console.WriteLine(line);

            }
        }
    }
}
