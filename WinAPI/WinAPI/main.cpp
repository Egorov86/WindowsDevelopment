#include<Windows.h>
#include"resource.h"

CONST CHAR* g_LIST_BOX_ITEMS[] = { "This", "is", "my", "first", "List", "Box", };

        //Процедура окна:   окно сообщение и параметры сообщения
BOOL CALLBACK DlgProcLB(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam);

INT WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInst, LPSTR lpCmdLine, INT nCmdShow)
{
	//hInstance - экземпляр запущенного *.exe-файла нашей программы
	//hPrevInst - НЕ используется
	//LPSTR - Long Pointer To String
	//lpCmdLine - CommandLine (командная строка с параметрами запуска приложения)
	//nCmdShow  - режим отображения окна (развернуто на весь экран, cвернуто на панель задач и т.д.)
	//Префиксы: n..., lp... это Венгерская нотация
	//			n - Number
	//			lp - Long Pointer
	//			h - HINSTANCE

	/*MessageBox
	(
		NULL,
		"Hello Windows!\nThis is MessageBox()",
		"Window title",
		MB_CANCELTRYCONTINUE | MB_HELP | MB_DEFBUTTON3 |
		MB_ICONINFORMATION |
		MB_SERVICE_NOTIFICATION |
		MB_RIGHT
	);*/

	DialogBoxParam(hInstance, MAKEINTRESOURCE(IDD_DIALOG1), 0, (DLGPROC)DlgProcLB, 0);

	return 0;
}

//Процедура окна:
BOOL CALLBACK DlgProcLB(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam)
{
	//hwnd - Handler to Window. Обработчик или дескриптор окна - это число, при помощи которого можно обратиться к окну.
	//uMsg - Message. Сообщение, которое отправляется окну.
	//wParam, lParam - это параметры сообщения, у каждого сообщения свой набор параметров.
	//LOWORD - Младшее слово;
	//HIWORD - Старшее слово;
	//DWORD  - Double Word;

	switch (uMsg)
	{
	case WM_INITDIALOG:	//Это сообшение отправляется 1 раз при инициализации окна
		HWND hCombo = GetDlgItem(hwnd, IDC_LIST1);
		for (int i = 0; i < sizeof(g_LIST_BOX_ITEMS) / sizeof(g_LIST_BOX_ITEMS[0]); i++)
		{
			SendMessage(hCombo, LB_ADDSTRING, 0, (LPARAM)g_LIST_BOX_ITEMS[i]);
		}
		//SendMessage(hCombo, LB_SETCURSEL, 0, 0);
	/* {
		HWND hEdit = GetDlgItem(hwnd, IDC_EDIT_LOGIN);
		SendMessage(hEdit, WM_SETTEXT, 0, (LPARAM)g_sz_LOGIN_INVITATION);
	}
	break;*/
	case WM_COMMAND:	//Обрабатывает нажатие кнопок и другие действия пользователя
		//ResourceID
		/*switch (LOWORD(wParam))
		{
		case IDC_EDIT_LOGIN:
		{
			CONST INT SIZE = 256;
			CHAR sz_buffer[SIZE]{};
			SendMessage((HWND)lParam, WM_GETTEXT, SIZE, (LPARAM)sz_buffer);
			/*
			-----------------
			WM_COMMAND
			LOWORD(wParam) = ResourceID
			HIWORD(wParam) = NotificationCode(EN_SETFOCUS)
			-----------------
			*/
			/*if (HIWORD(wParam) == EN_SETFOCUS && strcmp(sz_buffer, g_sz_LOGIN_INVITATION) == 0)
				SendMessage((HWND)lParam, WM_SETTEXT, 0, (LPARAM)"");
			if (HIWORD(wParam) == EN_KILLFOCUS && strcmp(sz_buffer, "") == 0)
				SendMessage((HWND)lParam, WM_SETTEXT, 0, (LPARAM)g_sz_LOGIN_INVITATION);
			//EN_ - Edit Notofocation
	
			-----------------------------
			/*Функция strcmp(const char* str1, const char* str2) сравнивает строки и возвращает значение типа 'int':
				0  - строки идентичны;
				!0 - строки отличаются;
			-----------------------------
			//https://legacy.cplusplus.com/reference/cstring/strcmp/
			
		}
		break;
		case IDC_BUTTON_COPY:
		{
			//1) Создаем буфер:
			CONST INT SIZE = 256;
			CHAR sz_buffer[SIZE] = {};	//sz_ - String Zero (NULL Terminated Line - C-string)

			//2) Получаем обработчики текстовых полей:
			HWND hEditLogin = GetDlgItem(hwnd, IDC_EDIT_LOGIN);
			HWND hEditPassword = GetDlgItem(hwnd, IDC_EDIT_PASSWORD);

			//3) Считываем содержимое поля 'Login' в буфер:
			SendMessage(hEditLogin, WM_GETTEXT, SIZE, (LPARAM)sz_buffer);

			//4) Записываем полученный текст в текстовое поле 'Password':
			SendMessage(hEditPassword, WM_SETTEXT, 0, (LPARAM)sz_buffer);
		}
		break;
		case IDOK:		MessageBox(hwnd, "Была нажата кнопка OK", "Info", MB_OK | MB_ICONINFORMATION); break;
		case IDCANCEL:	EndDialog(hwnd, 0); break;
		}
		break;*/
		switch(LOWORD(wParam))
		{
		case IDOK: break;
		case IDCANCEL: EndDialog(hwnd, 0);
		
		}
		break;
	    case WM_CLOSE:		//Отправляется при нажатии кнопки 'Закрыть' X
		EndDialog(hwnd, 0);
		//break;
	}
	return FALSE;
}