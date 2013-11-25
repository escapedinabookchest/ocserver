#pragma once

#include <iostream>
#include <WinSock2.h>

using namespace std;

class Socket
{
protected:
	SOCKET m_socket;

public:
	Socket() : m_socket(0) {}
	Socket(SOCKET m_socket) : m_socket(m_socket) {}
	~Socket() {if (m_socket > 0) closesocket(m_socket); };

	void set(SOCKET socket) { this->m_socket = socket; }
	void close() { closesocket(m_socket); m_socket = 0; };

	size_t read(char *buffer, size_t maxlength);
	size_t read(wchar_t *buffer, size_t maxlength);

	size_t readline(char *buffer, size_t maxlength);
	size_t readline(wchar_t *buffer, size_t maxlength);

	void write(const char *buffer, size_t length);
	void write(const char *buffer);
	void write(const wchar_t *buffer);
	
	void Socket::writeline(const wchar_t *buffer);
	void Socket::writeline(const char *buffer);
};

class ServerSocket : public Socket
{
public:
	ServerSocket(int port);
	Socket *accept();
};

class ClientSocket : public Socket
{
public:
	ClientSocket(const char *host, int port);
};