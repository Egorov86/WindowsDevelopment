//ComboBox
#define _CRT_SECURE_NO_WARNINGS
#include<Windows.h>
#include<cstdio>
#include"resource.h"

CONST CHAR* g_COMBO_BOX_ITEMS[] = { "This", "is", "my", "First", "Combo", "Box" };

BOOL CALLBACK DlgProcLB(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam); // ��������� ���� (����, ���������, )

INT WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInst, LPSTR lpCmdline, INT mCmdShow)
{
	DialogBoxParam(hInstance, MAKEINTRESOURCE(IDD_DIALOG1), NULL, (DLGPROC)DlgProcLB, 0);
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

			HWND hCombo = GetDlgItem(hwnd, IDC_COMBO1);  // �������� hwnd ��������� �������� ����
			for (int i = 0; i < sizeof(g_COMBO_BOX_ITEMS) / sizeof(g_COMBO_BOX_ITEMS[0]); i++)
			{
				SendMessage(hCombo, CB_ADDSTRING, 0, (LPARAM)g_COMBO_BOX_ITEMS[i]);
			}
			SendMessage(hCombo, CB_SETCURSEL, 0, 0); // ��� ���������� ������ � ����
			//CB_SETCURSEL - ComboBox Set Current Selection
	}
		break;
	case WM_COMMAND:
		//HWND hCombo = GetDlgItem(hwnd, IDC_COMBO1);
		switch (LOWORD(wParam))
		{
		case IDOK:
		{
			HWND hCombo = GetDlgItem(hwnd, IDC_COMBO1);
			INT i = SendMessage(hCombo, CB_GETCURSEL, 0, 0);
			CONST INT SIZE = 256;
			CHAR sz_buffer[SIZE]{};
			SendMessage(hCombo, CB_GETLBTEXT, i, (LPARAM)sz_buffer);
			MessageBox(hwnd, sz_buffer, "Info", MB_OK | MB_ICONEXCLAMATION);
			CHAR sz_message[SIZE]{};
			sprintf(sz_message, "�� ������� ����� �%i �� ��������� \"%s\".", i, sz_buffer); // �������������, ��������� �������������� �����, �� ���� ��������� �������� � ������ ���������� ��������.
				// %i - ����� �����
				// %s - ������
			MessageBox(hwnd, sz_message, "Info", MB_OK | MB_ICONEXCLAMATION);
		}
			break;
		case IDCANCEL:
			EndDialog(hwnd, 0);
		}

		/*if (HIWORD(wParam) == CBN_SELCHANGE && LOWORD(wParam) == IDC_COMBO1)
		{
			int iCurSel = SendMessageA((HWND)lParam, CB_GETCURSEL, 0, 0);                // ���������� ������� �����
			CHAR szText[100] = {};                   
			SendMessageA((HWND)lParam, CB_GETLBTEXT, iCurSel, (LPARAM)szText);
			MessageBox(hwnd, szText, TEXT("�� ������� �����:", ), MB_OK | MB_ICONINFORMATION);   //������ ��������� � ������
		}

		*/
		/*if ((LPARAM)g_COMBO_BOX_ITEMS == 1 && wParam == IDOK)
		{
			MessageBox(hwnd, "�� �������:", "Info", MB_OK | MB_ICONINFORMATION);
		}*/
		/*for (int i = 0; i < sizeof(g_COMBO_BOX_ITEMS) / sizeof(g_COMBO_BOX_ITEMS[0]); i++)
		{
			int count = 0; count++;
			SendMessage(hwnd, CB_ADDSTRING, 0, (LPARAM)g_COMBO_BOX_ITEMS[i]);
		}
		SendMessage(hwnd, "�� �������:", "Info", MB_OK | MB_ICONINFORMATION);*/
		/*if (wParam == 1)
		{
			MessageBox(hwnd, "�� �������:", "Info", MB_OK | MB_ICONINFORMATION); break;
		}*/
		break;
	    case IDCANCEL:	EndDialog(hwnd, 0); break;
	case WM_CLOSE:  EndDialog(hwnd, 0);
	}
	return FALSE;
}