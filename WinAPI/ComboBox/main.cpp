//ComboBox
#include<Windows.h>
#include"resource.h"

CONST CHAR* g_COMBO_BOX_ITEMS[] = { "This", "is", "my", "First", "Combo", "Box" };

BOOL CALLBACK DlgProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam); // Процедура окна (окно, сообщение, )

INT WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInst, LPSTR lpCmdline, INT mCmdShow)
{
	DialogBoxParam(hInstance, MAKEINTRESOURCE(IDD_DIALOG1), NULL, (DLGPROC)DlgProc, 0);
	return 0;
}
BOOL CALLBACK DlgProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam)
{
	switch (uMsg)
	{
	case WM_INITDIALOG:
	{
		    HICON hIcon = LoadIcon(GetModuleHandle(NULL), MAKEINTRESOURCE(IDI_ICON1));
			SendMessage(hwnd, WM_SETICON, 0, (LPARAM)hIcon);

			HWND hCombo = GetDlgItem(hwnd, IDC_COMBO1);  // получили hwnd дочернего элемента окна
			for (int i = 0; i < sizeof(g_COMBO_BOX_ITEMS) / sizeof(g_COMBO_BOX_ITEMS[0]); i++)
			{
				SendMessage(hCombo, CB_ADDSTRING, 0, (LPARAM)g_COMBO_BOX_ITEMS[i]);
			}
			SendMessage(hCombo, CB_SETCURSEL, 0, 0); // для начального выбора в окне
			//CB_SETCURSEL - ComboBox Set Current Selection
	}
		break;
	case WM_COMMAND:
		//HWND hCombo = GetDlgItem(hwnd, IDC_COMBO1);
		if ((LPARAM)g_COMBO_BOX_ITEMS == 1 && wParam == IDOK)
		{
			MessageBox(hwnd, "Вы выбрали пункт №1", "Info", MB_OK | MB_ICONINFORMATION);
		}
		/*for (int i = 0; i < sizeof(g_COMBO_BOX_ITEMS) / sizeof(g_COMBO_BOX_ITEMS[0]); i++)
		{
			int count = 0; count++;
			SendMessage(hwnd, CB_ADDSTRING, 0, (LPARAM)g_COMBO_BOX_ITEMS[i]);
		}
		SendMessage(hwnd, "Вы выбрали пункт №1", "Info", MB_OK | MB_ICONINFORMATION);*/
		/*if (wParam == 1)
		{
			MessageBox(hwnd, "Вы выбрали пункт №1", "Info", MB_OK | MB_ICONINFORMATION); break;
		}*/
		break;
	case IDCANCEL:
	{
		EndDialog(hwnd, 0);
	}
		break;
	case WM_CLOSE:
		EndDialog(hwnd, 0);
	}
	return FALSE;
}