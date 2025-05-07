using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter URL:");
        string url = Console.ReadLine();

        string protocol = "";
        string server = "";
        string resource = "";

        // Find protocol
        int protocolEnd = url.IndexOf("://");
        if (protocolEnd != -1)
        {
            protocol = url.Substring(0, protocolEnd);
            url = url.Substring(protocolEnd + 3); // Remove protocol and "://"
        }

        // Find server and resource
        int slashIndex = url.IndexOf('/');
        if (slashIndex != -1)
        {
            server = url.Substring(0, slashIndex);
            resource = url.Substring(slashIndex + 1);
        }
        else
        {
            server = url;
            resource = "";
        }

        Console.WriteLine($"[protocol] = \"{protocol}\"");
        Console.WriteLine($"[server] = \"{server}\"");
        Console.WriteLine($"[resource] = \"{resource}\"");
    }
}
