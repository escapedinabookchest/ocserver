#include "stdafx.h"
#include "socket.h"

#pragma comment(lib, "wsock32.lib")

class WSA
{
private:
	WSADATA data;

public:
	WSA()
	{
		WORD version = MAKEWORD(1, 1);
		WSAStartup(version, &data);
	}

	~WSA()
	{
		WSACleanup();
	}
} wsa;

size_t Socket::read(char *buffer, size_t maxlength)
{
	size_t length = 0;
	while (size_t n = recv(m_socket, (buffer + length), int(maxlength - length), 0))
	{
		if (n == 0) break;

		length += n;
		if (length >= maxlength) break;
	}

	return length;
}


size_t Socket::readline(char *buffer, size_t maxlength)
{
	char c;
	size_t length = 0;
	while (size_t n = recv(m_socket, &c, 1, 0))
	{
		if (n == 0) break;
		if (c == '\n') break;
		
		if (c != '\r')
			buffer[length++] = c;

		if (length >= maxlength) break;
	}

	buffer[length] = 0;

	return length;
}

size_t Socket::readline(wchar_t *buffer, size_t maxlength)
{
	wchar_t c;
	size_t length = 0;
	while (size_t n = recv(m_socket, (char*)&c, 2, 0))
	{
		if (n == 0) break;
		if (c == '\n') break;

		if (c != '\r')
			buffer[length++] = c;

		if (length >= maxlength) break;
	}

	buffer[length] = 0;

	return length;
}


void Socket::write(const char *buffer, size_t length)
{
	send(m_socket, buffer, (int) length, 0);
}

void Socket::write(const char *buffer)
{
	send(m_socket, buffer, (int)strlen(buffer), 0);
}

void Socket::write(const wchar_t *buffer)
{
	send(m_socket, (const char*)buffer, (int)(sizeof(wchar_t)*wcslen(buffer)), 0);
}

void Socket::writeline(const char *buffer)
{
	send(m_socket, (const char*)buffer, (int)(sizeof(char)*strlen(buffer)), 0);
	send(m_socket, (const char*)"\r\n", (int)(sizeof(char)*2), 0);
}

void Socket::writeline(const wchar_t *buffer)
{
	send(m_socket, (const char*)buffer, (int)(sizeof(wchar_t)*wcslen(buffer)), 0);
	send(m_socket, (const char*)L"\r\n", (int)(sizeof(wchar_t)*2), 0);
}


ServerSocket::ServerSocket(int port)
{
	m_socket = socket(AF_INET, SOCK_STREAM, 0);
	if (m_socket == INVALID_SOCKET) throw("Error while creating the socket!");

	SOCKADDR_IN socketAddress;
	socketAddress.sin_family = AF_INET;
	socketAddress.sin_addr.s_addr = INADDR_ANY;
	socketAddress.sin_port = htons(port);

	int socketState = bind(m_socket, (LPSOCKADDR) &socketAddress, sizeof(struct sockaddr));
	if (socketState == SOCKET_ERROR) throw("Error binding the socket!");

	socketState = listen(m_socket, 100);
	if (socketState == SOCKET_ERROR) throw("Error while listening!");
}

Socket *ServerSocket::accept()
{
	SOCKET s = ::accept(m_socket, 0, 0);
	if (s == INVALID_SOCKET) throw("Error while accepting the socket!");

	return new Socket(s);
}

ClientSocket::ClientSocket(const char *host, int port)
{
	m_socket = socket(AF_INET, SOCK_STREAM, IPPROTO_TCP);
	if (m_socket == INVALID_SOCKET) throw ("Error while creating the client-socket!");

	struct sockaddr_in socketDestination;
	memset(&socketDestination, 0, sizeof(socketDestination));
	socketDestination.sin_family = AF_INET;

	hostent *h;
	h = gethostbyname(host);
	memcpy(&socketDestination.sin_addr, h->h_addr, h->h_length);

	if (socketDestination.sin_addr.s_addr == -1) throw("Cannot find the client-socket's address!");

	socketDestination.sin_port = htons(port);
	int socketResult = ::connect(m_socket, (sockaddr *) &socketDestination, sizeof(sockaddr));
	if (socketResult == -1) throw("Error connecting to the socket!");
}