﻿#include<Windows.h>
#include"resource.h"
#include<string>
#include<sstream>

std::string ToString(int number) // Метод ToСТРИНГ
{
	std::stringstream ss;   // Создаю объект
	ss << number;           // Вставляю значение number в ss оператором вставка <<
	return ss.str();        // Возвращ строку с помощью метода str
}

CONST CHAR g_sz_WINDOW_CLASS[] = "Calc";

CONST INT g_BUTTON_SIZE = 50;
CONST INT g_INTERVAL = 5;
CONST INT g_START_X = 10;
CONST INT g_START_Y = 10;
CONST INT g_DISPLAY_WIDTH = 300;
CONST INT g_DISPLAY_HEIGHT = 25;
CONST INT g_BUTTON_START_X = g_START_X;
CONST INT g_BUTTON_START_Y = g_START_Y + g_DISPLAY_HEIGHT+g_INTERVAL;

BOOL CALLBACK WndProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam);

INT WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInst, LPSTR lpCmdLine, INT nCmdShow) 
{
	//1  Регистр класса окна
	WNDCLASSEX wClass;
	ZeroMemory(&wClass, sizeof(wClass));

	wClass.style = NULL;
	wClass.cbSize = sizeof(wClass);
	wClass.cbWndExtra = 0;
	wClass.cbClsExtra = 0;

	// опред внеш вид
	wClass.hIcon = LoadIcon(hInstance, IDI_APPLICATION);
	wClass.hIconSm = LoadIcon(hInstance, IDI_APPLICATION);
	wClass.hCursor = LoadCursor(hInstance, IDC_ARROW);
	wClass.hbrBackground = (HBRUSH)COLOR_WINDOW;

	wClass.hInstance = hInstance;
	wClass.lpfnWndProc = (WNDPROC)WndProc;
	wClass.lpszMenuName = NULL;
	wClass.lpszClassName = g_sz_WINDOW_CLASS;

	if (RegisterClassEx(&wClass) == NULL)
	{
		MessageBox(NULL, "Class registreation failed", "ERROR", MB_OK | MB_ICONINFORMATION);
		return 0;
	}

	//2  Создание окна
	HWND hwnd  = CreateWindowEx
	    (
		    NULL,	                       //Window ExStyle
		    g_sz_WINDOW_CLASS,	           //Window Class Name
		    g_sz_WINDOW_CLASS,	           //Window Title
		    WS_OVERLAPPEDWINDOW,           //Window Style
		    //WS_OVERLAPPED | WS_THICKFRAME | WS_SYSMENU | WS_MINIMIZEBOX | WS_MAXIMIZEBOX,           //Window Style
		    CW_USEDEFAULT, CW_USEDEFAULT,	//Position
		    CW_USEDEFAULT, CW_USEDEFAULT,	//Window size
		    NULL,	//Parent
		    NULL,	//hMenu: Для главного окна это ResourceID нлавного меню,
	        hInstance,
            NULL
         );
	ShowWindow(hwnd, nCmdShow);
	UpdateWindow(hwnd);

	//3  Запуск цикла сообщений
	MSG msg;
	while (GetMessage(&msg, 0, 0, 0) > 0)
	{
		TranslateMessage(&msg);
		DispatchMessage(&msg);
	}
	return msg.message;
    }

BOOL CALLBACK WndProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam)
{
	switch (uMsg)
	{
	case WM_CREATE:
	{
		HWND hEditDisplay = CreateWindowEx
		(
			NULL, "Edit", "0",
			WS_CHILD | WS_VISIBLE | WS_BORDER | ES_NUMBER | ES_RIGHT,
			g_START_X, g_START_Y,
			g_DISPLAY_WIDTH, g_DISPLAY_HEIGHT,
			hwnd,
			(HMENU)IDC_EDIT_DISPLAY,
			GetModuleHandle(NULL),
			NULL
		);
		for (int i = 6; i >= 0; i -= 3)
		{
			for (int j = 0; j < 3; j++)
			{   
				int count = 1+j;
				if (i<=3)
				{
					count = 4 + j;
				}
				if (i<=0)
				{
					count = 7+j;
				}
				CreateWindowEx(
					NULL, "Button", ToString(count).c_str(), // c_str() - преобразует в LPCSTR
				    WS_CHILD | WS_VISIBLE,
					g_BUTTON_START_X + (g_BUTTON_SIZE+g_INTERVAL )* j, g_BUTTON_START_Y + (g_BUTTON_SIZE+g_INTERVAL) * (i / 3),
					g_BUTTON_SIZE, g_BUTTON_SIZE, 
					hwnd,
					(HMENU)(IDC_BUTTON_0 + i + j),
					GetModuleHandle(NULL),
					NULL
				);
			}
		}
	
	}
	break;
	case WM_COMMAND:
		break;
	case WM_DESTROY:
		PostQuitMessage(0);
		break;
	case WM_CLOSE:
		DestroyWindow(hwnd);
		break;
	default:return DefWindowProc(hwnd, uMsg, wParam, lParam);
	}
	return FALSE;
}