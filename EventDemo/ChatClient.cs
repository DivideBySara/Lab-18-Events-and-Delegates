// ChatClient.cs - Step 0

using System;
using static System.Console;

/*
 * Sara Jade
 * 8/30/17
 * 
 * Features added to starter chat room:
 * 1) using static System.Console;
 * 2) event handlers OnJoinChat & OnQuitChat
 * 
 */ 

class ChatClient
{
    // TO DO:
    // Add event handlers for joining and quitting
    // Display the sender and the name of person
    public static void OnJoinChat(object sender, ChatEventArg e) 
    {
        WriteLine($"The sender is {sender}. {e.Name} has joined the chatroom.");
    }

    public static void OnQuitChat(object sender, ChatEventArg e)
    {
        WriteLine($"Then sender is {sender}. {e.Name} has left the chatroom.");
    }

    public static void Main()
	{
		ChatServer chat = new ChatServer();
		// Register to receive event notifications from the server
		// TO DO:
		// Add code to register your event handlers


		// Call methods on the server
		chat.JoinChat("Michael");
		chat.JoinChat("Bob");
		chat.JoinChat("Sam");
		chat.ShowMembers("After 3 have joined");
		chat.QuitChat("Bob");
		chat.ShowMembers("After 1 has quit");

        ReadKey();
	}
}