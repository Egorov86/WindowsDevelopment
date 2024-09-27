#include<Windows.h>
#include"resource.h"

BOOL CALLBACK DlgProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam);

INT WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInst, LPSTR lpCmdLine, INT nCmdShow)
{
	//hInstance - ��������� ����������� *.exe-����� ����� ���������
	//hPrevInst - �� ������������
	//LPSTR - LongPointer To String
	//lpCmdLine - CommandLine (��������� ������ � ����������� ������� ����������) 
	//nCmdShow - ����� ����������� ���� (���������� �� ���� �����, c������� �� ������ �����)
	//           n - Number
	//          lp - Long Pointer
	//           h - HINSTANCE

	/*MessageBox(NULL, "Hello Windows!\nThis is MessageBox()", "Window title", MB_CANCELTRYCONTINUE | MB_HELP | MB_DEFBUTTON2 | MB_ICONINFORMATION | MB_RIGHT);*/

	DialogBoxParam(hInstance, MAKEINTRESOURCE(IDD_DIALOG1), 0, (DLGPROC)DlgProc, 0);

	return 0;
}

	BOOL CALLBACK DlgProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam)
	{
		//hwnd - Handler to Window. ���������� ��� ���������� ���� - ��� ����� ��� ������ �������� ����� ���������� � ����.
		//uNsg - Message. ���������, ������ ������������ ����
		//wParam, lParam - ��� ��������� ���������, � ������� ��������� ���� ����� ����������.
		switch (uMsg)
		{
		case WM_INITDIALOG:  // ��������� ������������  ��� ��� ������������� ����.
			break;
		case WM_COMMAND:   // ������������ ������� ������ � ���� �������� ������������
			switch (LOWORD(wParam))
			{
			case IDC_BUTTON_COPY:
			{
				// 1) ������� �����
				CONST INT SIZE = 256;
				CHAR sz_buffer[SIZE] = {}; //sz - String Zero (NULL terminated Line - C-string)

				// 2) �������� ���������� ��������� �����:
				HWND heditLogin = GetDlgItem(hwnd, IDC_EDIT_LOGIN);
				HWND heditPassword = GetDlgItem(hwnd, IDC_EDIT_PASSWORD);
				
				// 3) ��������� ���������� ���� 'Login' � �����:
				SendMessage(heditLogin, WM_GETTEXT, SIZE, (LPARAM)sz_buffer);

				// 4) ���������� ���������� ����� � ��������� ���� 'Password':
				SendMessage(heditPassword, WM_SETTEXT, 0, (LPARAM)sz_buffer);

			}
			break;
			case IDOK:MessageBox(hwnd, "���� ������ ������ ��", "Info", MB_OK | MB_ICONINFORMATION);
				break;
			case IDCANCEL: EndDialog(hwnd, 0); break;
			}
			break;
		case WM_CLOSE:   // ���������� ��� ������� ������ �������, �������, "X"
			EndDialog(hwnd, 0); 
			break;
		}
		return FALSE;
	}