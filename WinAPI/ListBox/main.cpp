//ListBox
#include<Windows.h>
#include"resource.h"

CONST CHAR* g_LIST_BOX_ITEMS[] = { "One", "Two", "Three", "Four", "Five", "Six" };

BOOL CALLBACK DlgProcLB(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam);

INT WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInst, LPSTR lpCmdLine, INT nCmdShow)
{
	DialogBoxParam(hInstance, MAKEINTRESOURCE(IDD_DIALOG1), NULL, (DLGPROC)DlgProcLB, 0);
	DWORD dwErrorMessageID = GetLastError();
	LPSTR lpszMessageBuffer;
	FormatMessage(FORMAT_MESSAGE_ALLOCATE_BUFFER | FORMAT_MESSAGE_FROM_SYSTEM | FORMAT_MESSAGE_IGNORE_INSERTS,
		NULL,
		dwErrorMessageID,
		MAKELANGID(LANG_NEUTRAL, SUBLANG_RUSSIAN_RUSSIA),
		(LPSTR) & lpszMessageBuffer,
		0,
		NULL
	);
	MessageBox(NULL, lpszMessageBuffer, "Error", MB_OK | MB_ICONERROR);
	return 0;
}

BOOL CALLBACK DlgProcLB(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam)
{
	switch (uMsg)
	{
	case WM_INITDIALOG:
	{
		HICON hIcon = LoadIcon(GetModuleHandle(NULL), MAKEINTRESOURCE(IDI_ICON1));
		SendMessage(hwnd, WM_SETICON, 0, (LPARAM)hIcon);
		HWND hList = GetDlgItem(hwnd, IDC_LIST1); // получили элемент дочернего элемента окна 
		for (int i = 0; i < sizeof(g_LIST_BOX_ITEMS) / sizeof(g_LIST_BOX_ITEMS[0]); i++)
		{
			SendMessage(hList, LB_ADDSTRING, 0, (LPARAM)g_LIST_BOX_ITEMS[i]);
		}
		SendMessage(hList, LB_SETCURSEL, 0, 0); // для изначального выбьора в окне
		
	}
	break;
	case WM_COMMAND:
        switch (LOWORD(wParam))
        {
		case IDOK:
		{
			HWND hCombo = GetDlgItem(hwnd, IDC_LIST1);
			INT i = SendMessage(hCombo, CB_GETCURSEL, 0, 0);
			CONST INT SIZE = 256;
			CHAR sz_buffer[SIZE]{};
			SendMessage(hCombo, CB_GETLBTEXT, i, (LPARAM)sz_buffer);
			MessageBox(hwnd, sz_buffer, "Info", MB_OK | MB_ICONEXCLAMATION);
			CHAR sz_message[SIZE]{};
			wsprintf(sz_message, "Вы выбрали пункт №%i со значением \"%s\".", i, sz_buffer);
			/*sprintf(sz_message, "Вы выбрали пункт №%i со значением \"%s\".", i, sz_buffer); // спецификаторы, выполняет форматирование строк, то есть позволяет вставить в строку переменные значения.
			// %i - целое число
			// %s - строка*/
			MessageBox(hwnd, sz_message, "Info", MB_OK | MB_ICONEXCLAMATION);
		}
		break;
		case IDCANCEL:
			EndDialog(hwnd, 0);
		}
		break;
	case WM_CLOSE:
		EndDialog(hwnd, 0);
	}
	return FALSE;
}