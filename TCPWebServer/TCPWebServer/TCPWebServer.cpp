// TCPWebServer.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "socket.h"

#include <fstream>
#include <iostream>


using namespace std;


static const int MAX_PATH_LENGTH = 256;
static const int TCP_PORT = 8080;


void handle(Socket *socket)
{
	char line[(MAX_PATH_LENGTH + 1)];

	cout << "Socket successfully connected!\r\n";

	if (socket->readline(line, MAX_PATH_LENGTH))
	{
		cout << "Get request: " << line << "\r\n";
	}

	delete socket;
}


int _tmain(int argc, _TCHAR* argv[])
{
	ServerSocket serverSocket(TCP_PORT);

	cout << "Server listening...\r\n";
	while (Socket *socket = serverSocket.accept())
	{
		handle(socket);
		cout << "Server listening again...\r\n";
	}

	return 0;
}

