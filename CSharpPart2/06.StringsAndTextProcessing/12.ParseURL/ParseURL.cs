namespace ParseURL
{
    using System;

    class ParseURL
    {
        static void Main()
        {
            var input = Console.ReadLine();

            var indexOfProtocol = input.IndexOf("://");

            var protocol = input.Substring(0, indexOfProtocol);

            var indexOfServer = input.IndexOf("/", indexOfProtocol + 3);

            var server = input.Substring(indexOfProtocol + 3, indexOfServer - indexOfProtocol - 3);

            var resource = input.Substring(indexOfServer);

            Console.WriteLine("[protocol] = {0}", protocol);
            Console.WriteLine("[server] = {0}", server);
            Console.WriteLine("[resource] = {0}", resource);
        }
    }
}
