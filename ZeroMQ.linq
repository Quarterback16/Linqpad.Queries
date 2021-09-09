<Query Kind="Statements">
  <Reference>&lt;ProgramFilesX86&gt;\LINQPad5\libsodium.dll</Reference>
  <Reference>&lt;ProgramFilesX86&gt;\LINQPad5\libzmq.dll</Reference>
  <Reference>&lt;ProgramFilesX86&gt;\LINQPad5\ZeroMQ.dll</Reference>
  <NuGetReference>ZeroMQ</NuGetReference>
  <Namespace>ZeroMQ</Namespace>
</Query>

var context = new ZContext();
var socket = new ZSocket(context, ZSocketType.PUSH);
socket.Connect("tcp://localhost:5555");
var stopwatch = Stopwatch.StartNew();
for (int i = 0; i < 1000; i++)
{
   var message = new ZFrame("Message: " + i);
   socket.Send( message );
}
stopwatch.ElapsedMilliseconds.Dump("ZeroMQ PUSH");
