using Pinger;
using System.Net.NetworkInformation;
using System.Text;

//Pinging google DNS Server 4.2.2.2

PingService pingService = new PingService();
pingService.SendPing();
Console.WriteLine();