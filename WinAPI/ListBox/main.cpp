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
		//HICON hIcon = LoadIcon(GetModuleHandle(NULL), MAKEINTRESOURCE(IDI_ICON1));
		//SendMessage(hwnd, WM_SETICON, 0, (LPARAM)hIcon);

		//HWND hList = GetDlgItem(hwnd, IDC_LIST1); // получили hwnd дочернего элемента окна
		//for (int i = 0; i < sizeof(g_LIST_BOX_ITEMS) / sizeof(g_LIST_BOX_ITEMS[0]); i++)
		//{
		//	SendMessage(hList, CB_ADDSTRING, 0, (LPARAM)g_LIST_BOX_ITEMS[i]);
		//}
		//SendMessage(hList, CB_SETCURSEL, 0, 0); // для начального выбора в окне
		//CB_SETCURSEL - ListBox Set Current Selection
	}
	break;
	case WM_COMMAND:
		break;
	case WM_CLOSE:
		EndDialog(hwnd, 0);
	}
	return FALSE;
}