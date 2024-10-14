#include<Windows.h>
#include<cstdio>

#define IDC_STATIC 1000   // 1 Создаём ResourseID для дочернего элемента
#define IDC_EDIT   1002
#define IDC_BUTTON 1003

//MDI - Multi Document Interface

CONST CHAR g_sz_WINDOW_CLASS[] = "Main Windows";	//Имя класса окна.
CONST CHAR Information[] = "Main Window Размер: %ix%i, Позиция: ось X: %i ось Y: %i";

INT CALLBACK WndProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam);

INT WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInst, LPSTR lpCmdLine, INT nCmdShow)
{
	//1) Регистрация класса окна:
	//1.1 Создать и проинициализировать структуру WNDCLASSEX
	WNDCLASSEX wClass;
	ZeroMemory(&wClass, sizeof(wClass));

	wClass.style = NULL;
	wClass.cbSize = sizeof(wClass);	 //cb - Count Bytes
	wClass.cbClsExtra = 0;	         //Class Extra Bytes
	wClass.cbWndExtra = 0;	         //Window Extra Bytes

	//Appearance:
	//wClass.hIcon = LoadIcon(NULL, IDI_APPLICATION);
	//wClass.hIconSm = LoadIcon(NULL, IDI_APPLICATION);	//Small Icon
	wClass.hIcon = (HICON)LoadImage(hInstance, "ICO\\Insta.ico", IMAGE_ICON, LR_DEFAULTSIZE, LR_DEFAULTSIZE, LR_LOADFROMFILE);
	wClass.hIcon = (HICON)LoadImage(hInstance, "ICO\\netflix.ico", IMAGE_ICON, LR_DEFAULTSIZE, LR_DEFAULTSIZE, LR_LOADFROMFILE);

	//wClass.hCursor = LoadCursor(NULL, IDC_ARROW);
	wClass.hCursor = (HCURSOR)LoadImage
	(
		hInstance,
		"CUR\\Busy.cur",   /* если есть ещё папка то прописать через\\ */
		IMAGE_CURSOR,
		LR_DEFAULTSIZE,
		LR_DEFAULTSIZE,
		LR_LOADFROMFILE
	);
	wClass.hbrBackground = (HBRUSH)COLOR_WINDOW;

	//
	wClass.hInstance = hInstance;
	wClass.lpfnWndProc = (WNDPROC)WndProc;
	wClass.lpszClassName = g_sz_WINDOW_CLASS;
	wClass.lpszMenuName = NULL;

	//	1.2 Вызвать функцию RegisterClassEx(...)
	if (RegisterClassEx(&wClass) == NULL)
	{
		MessageBox(NULL, "Class registration failed", "Error", MB_OK | MB_ICONERROR);
		return 0;
	}

	//2) Создание окна
	HWND hwnd = CreateWindowEx
	(
		NULL,	                       //Window ExStyle
		g_sz_WINDOW_CLASS,	           //Window Class Name
		g_sz_WINDOW_CLASS,	           //Window Title
		//WS_OVERLAPPEDWINDOW,           //Window Style
		WS_OVERLAPPED |WS_THICKFRAME | WS_SYSMENU | WS_MINIMIZEBOX | WS_MAXIMIZEBOX,           //Window Style
		CW_USEDEFAULT, CW_USEDEFAULT,	//Coordinates
		CW_USEDEFAULT, CW_USEDEFAULT,	//Window size
		NULL,	//Parent
		NULL,	//hMenu: Для главного окна это ResourceID нлавного меню,
		        //для дочернего окна (кнопки и друние элементы) - 
		//это ResourceID соответствующего элемента (кнопки, такстового пол, и т.д.)
		//По этому RousourceID мы находим дочерний элемент окна при помощи функции GetDlgItem()
		hInstance,
		NULL
	);
	if (hwnd == NULL)
	{
		MessageBox(NULL, "Window creation failed", "Error", MB_OK | MB_ICONERROR);
		return 0;
	}
	ShowWindow(hwnd, nCmdShow);	//Задает режим отображения окна (развернуто на весь экран, свернуто в окно, свернуто в панель задач)
	UpdateWindow(hwnd);	//Прорисовывает окно

	//3) Запуск цикла сообщений
	MSG msg;
	while (GetMessage(&msg, 0, 0, 0) > 0)
	{
		TranslateMessage(&msg);
		DispatchMessage(&msg);
	}
	return msg.message;
}

INT CALLBACK WndProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam)
{
	switch (uMsg)
	{
	case WM_CREATE:
	{
		CreateWindowEx
		(
			NULL,
			"Static",
			"Это static_text, детка",
			WS_CHILD | WS_VISIBLE, //Для всех дочер окон стиль обязательно булет  WS_CHILD и WS_VISIBLE (это как минимум)
			100, 10,
			200, 20,
			hwnd,
			(HMENU)IDC_STATIC,
			GetModuleHandle(NULL),
			NULL
		);
		CreateWindowEx(
			NULL, "Edit", "",
			WS_CHILD | WS_VISIBLE | WS_BORDER,
			100, 30,
			200, 20,
			hwnd,
			(HMENU)IDC_EDIT,
			GetModuleHandle(NULL),
			NULL
		);
		CreateWindowEx(
			NULL, "Button", "Применить",
			WS_CHILD | WS_VISIBLE,
			200, 55,
			100, 32,
			hwnd,
			(HMENU)IDC_BUTTON,
			GetModuleHandle(NULL),
			NULL);
	}  	break;
	case WM_SIZE:     //  Сообщение, которое отправляется окну, когда будет изменяться его размер
	{
		CHAR windowSize[256]{};
		RECT rect;
		GetWindowRect(hwnd, &rect);
		int width = rect.right - rect.left;
		int height = rect.bottom - rect.top;
		sprintf_s(windowSize, Information, height, width, rect.left, rect.top);
		SetWindowText(hwnd, windowSize);
		break;
	}
	case WM_MOVE:     //  Сообщение, которое отправляется окну, когда оно будет перемещаться
	{
		CHAR windowsMoving[256]{};
		RECT rect;
		GetWindowRect(hwnd, &rect);
		int x = rect.right - rect.left;;
		int y = rect.bottom- rect.top;
		sprintf_s(windowsMoving, Information, x, y, rect.left, rect.top );
		SetWindowText(hwnd, windowsMoving);
		break;
	}
	case WM_COMMAND:
	{
		switch (LOWORD(wParam))
		{
		case IDC_BUTTON:
		{
			CONST INT SIZE = 256;
			CHAR sz_buffer[SIZE]{};
			HWND hedit = GetDlgItem(hwnd, IDC_EDIT);
			SendMessage(hedit, WM_GETTEXT, SIZE, (LPARAM)sz_buffer);

			HWND hStatic = GetDlgItem(hwnd, IDC_STATIC);
			SendMessage(hStatic, WM_SETTEXT, 0, (LPARAM)sz_buffer);
			SendMessage(hwnd, WM_SETTEXT, 0, (LPARAM)sz_buffer);
		}
		break;
		}
	}break;
	case WM_DESTROY:
		PostQuitMessage(0);
	case WM_CLOSE:DestroyWindow(hwnd); break;
	default:	return DefWindowProc(hwnd, uMsg, wParam, lParam);
	}
	return FALSE;
}