//ListBox
#include<Windows.h>
#include<cstdio>
#include"resource.h"
#include<CommCtrl.h>

CONST CHAR* g_LIST_BOX_ITEMS[] = { "This", "is", "my", "first", "List", "Box" };

BOOL CALLBACK DlgProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam);
BOOL CALLBACK DlgProcAdd(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam); //����� ����

INT WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInst, LPSTR lpCmdLine, INT nCmdShow)
{
	DialogBoxParam(hInstance, MAKEINTRESOURCE(IDD_DIALOG1), NULL, (DLGPROC)DlgProc, 0);
	/*DWORD dwErrorMessageID = GetLastError();
	LPSTR lpszMessageBuffer;
	FormatMessage(FORMAT_MESSAGE_ALLOCATE_BUFFER | FORMAT_MESSAGE_FROM_SYSTEM | FORMAT_MESSAGE_IGNORE_INSERTS,
		NULL,
		dwErrorMessageID,
		MAKELANGID(LANG_NEUTRAL, SUBLANG_RUSSIAN_RUSSIA),
		(LPSTR) & lpszMessageBuffer,
		0,
		NULL
	);
	MessageBox(NULL, lpszMessageBuffer, "Error", MB_OK | MB_ICONINFORMATION);*/
	return 0;
}

BOOL CALLBACK DlgProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam)
{
	switch (uMsg)
	{
	case WM_INITDIALOG:
	{
		/*HICON hIcon = LoadIcon(GetModuleHandle(NULL), MAKEINTRESOURCE(IDI_ICON1));
		SendMessage(hwnd, WM_SETICON, 0, (LPARAM)hIcon);*/
		HWND hCombo = GetDlgItem(hwnd, IDC_LIST1); // �������� ������� ��������� �������� ���� 
		for (int i = 0; i < sizeof(g_LIST_BOX_ITEMS) / sizeof(g_LIST_BOX_ITEMS[0]); i++)
		{
			SendMessage(hCombo, LB_ADDSTRING, 0, (LPARAM)g_LIST_BOX_ITEMS[i]);
		}
		SendMessage(hCombo, LB_SETCURSEL, 0, 0); // ��� ������������ ������� � ����
		
	}
	break;
	case WM_COMMAND:
        switch (LOWORD(wParam))
        {
		case IDC_BUTTON_ADD:
			//GetModuleHandle(NULL) - ���������� hInstance ���������� ����������
			DialogBoxParam(GetModuleHandle(NULL), MAKEINTRESOURCE (IDD_DIALOG_ADD_ITEM), hwnd, DlgProcAdd, 0); // ��� ��������� ������� ����
				break;
		case IDC_BUTTON_DELETE:  // ������ ����� �� ������
		{
			HWND hList = GetDlgItem(hwnd, IDC_LIST1);
			INT iSelectedItem = SendMessage(hList, LB_GETCURSEL, 0, 0);
			if (iSelectedItem != LB_ERR)
			{
				SendMessage(hList, LB_DELETESTRING, iSelectedItem, 0);
			}
		}
		break;
		case IDC_BUTTON_EDIT:  // ������ ����� �� ������
		{
			HWND hList = GetDlgItem(hwnd, IDC_LIST1);
			INT iSelectedItem = SendMessage(hList, LB_GETCURSEL, 0, 0);
			if (iSelectedItem != LB_ERR)
			{
				SendMessage(hList, LB_DELETESTRING, iSelectedItem, 0);
			}
		}
		case IDOK:
		{
			//HWND hList1 = GetDlgItem(hwnd, IDC_LIST1);
			CONST INT SIZE = 256;
			CHAR sz_buffer[SIZE]{};
			CHAR sz_message[SIZE] = "�� ������ �� �������.";
			HWND hCombo = GetDlgItem(hwnd, IDC_LIST1);
			INT i = SendMessage(hCombo, LB_GETCURSEL, 0, 0);
			SendMessage(hCombo, LB_GETTEXT, i, (LPARAM)sz_buffer);

			if (i != LB_ERR)
				sprintf(sz_message, "�� ������� ������� �%i �� ��������� %s.", i, sz_buffer);
			MessageBox(hwnd, sz_message, "Info", MB_OK | MB_ICONINFORMATION);

			/*CONST INT SIZE = 256;
			CHAR sz_buffer[SIZE]{};
			CHAR sz_message[SIZE] = "�� ������ �� �������.";
			HWND hCombo = GetDlgItem(hwnd, IDC_LIST1);
			INT i = SendMessage(hCombo, LB_GETCURSEL, 0, 0);
			SendMessage(hCombo, LB_GETTEXT, i, (LPARAM)sz_buffer);

			if (i != LB_ERR)
				sprintf(sz_message, "�� ������� ������� �%i �� ��������� %s.", i, sz_buffer);

			MessageBox(hwnd, sz_message, "Info", MB_OK | MB_ICONINFORMATION);*/

			/*HWND hCombo = GetDlgItem(hwnd, IDC_LIST1);
			INT i = SendMessage(hCombo, CB_GETCURSEL, 0, 0);
			CONST INT SIZE = 256;
			CHAR sz_buffer[SIZE]{};
			SendMessage(hCombo, CB_GETLBTEXT, i, (LPARAM)sz_buffer);
			MessageBox(hwnd, sz_buffer, "Info", MB_OK | MB_ICONINFORMATION);
			CHAR sz_message[SIZE]{};
			wsprintf(sz_message, "�� ������� ����� �%i �� ��������� \"%s\".", i, sz_buffer);*/
			/*sprintf(sz_message, "�� ������� ����� �%i �� ��������� \"%s\".", i, sz_buffer); // �������������, ��������� �������������� �����, �� ���� ��������� �������� � ������ ���������� ��������.
			// %i - ����� �����
			// %s - ������
			MessageBox(hwnd, sz_message, "Info", MB_OK | MB_ICONINFORMATION);*/
		}
		break;
	case IDCANCEL:	MessageBox(hwnd, "���� ������ ������ O�����", "Info", MB_OK | MB_ICONINFORMATION); EndDialog(hwnd, 0);
		}
		break;
	    case WM_CLOSE:
		EndDialog(hwnd, 0);
	}
	return FALSE;
}
BOOL CALLBACK DlgProcAdd(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam)
{
	switch (uMsg)
	{
	case WM_INITDIALOG:
		break;
	case WM_COMMAND:
		switch (LOWORD(wParam))
		{
		case IDOK:
		{
			CONST INT SIZE = 256;
			CHAR sz_buffer[SIZE]{};
			GetWindowText(GetDlgItem(hwnd, IDC_EDIT_NAME), sz_buffer, SIZE); // (����� ��� ���� ����� ��������� ����� �� �������)
			if (sz_buffer[0] != '\0') //���� ���� �� ����� ���������������� ����, �� �������� ������ �� ����������
			{
				HWND hParent = GetParent(hwnd);
				HWND hListBox = GetDlgItem(hParent, IDC_LIST1);
				if (SendMessage(hListBox, LB_FINDSTRING, -1, (LPARAM)sz_buffer) == LB_ERR)
					SendMessage(hListBox, LB_ADDSTRING, 0, (LPARAM)sz_buffer);
				else
					MessageBox(hwnd, "����� ��������� ��� ���������� ", "Info", MB_OK | MB_ICONINFORMATION);
			}
			else   //���� ���� ����������-> ����� � �����.
				MessageBox(hwnd, "�� ������ �� ����� ", "Info", MB_OK | MB_ICONHAND);
			EndDialog(hwnd, IDOK);
		}
			break;
		case IDCANCEL:MessageBox(hwnd, "���� ������ ������ O�����", "Info", MB_OK | MB_ICONINFORMATION); EndDialog(hwnd, 0);
		}
		break;
	case WM_CLOSE:
		EndDialog(hwnd, 0);
	}
	return FALSE;
}