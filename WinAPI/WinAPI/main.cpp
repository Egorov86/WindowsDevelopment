#include<Windows.h>
#include"resource.h"

BOOL CALLBACK DlgProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam);

INT WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInst, LPSTR lpCmdLine, INT nCmdShow)
{
	//hInstance - Экземпляр запущенного *.exe-файла нашей программы
	//hPrevInst - не используется
	//LPSTR - LongPointer To String
	//lpCmdLine - CommandLine (командная строка с параметрами запуска приложения) 
	//nCmdShow - режим отображения окна (развернуто на весь экран, cвернуто на панель задач)
	//           n - Number
	//          lp - Long Pointer
	//           h - HINSTANCE

	/*MessageBox(NULL, "Hello Windows!\nThis is MessageBox()", "Window title", MB_CANCELTRYCONTINUE | MB_HELP | MB_DEFBUTTON2 | MB_ICONINFORMATION | MB_RIGHT);*/

	DialogBoxParam(hInstance, MAKEINTRESOURCE(IDD_DIALOG1), 0, (DLGPROC)DlgProc, 0);

	return 0;
}

	BOOL CALLBACK DlgProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam)
	{
		//hwnd - Handler to Window. Обработчик или дескриптор окна - это число при помощи которого можно обратиться к окну.
		//uNsg - Message. Сообшение, кторое отправляется окну
		//wParam, lParam - это параметры сообщения, у каждого сообщения свои набор парамтеров.
		switch (uMsg)
		{
		case WM_INITDIALOG:  // сообщение отправляется  раз при инициализации окна.
			break;
		case WM_COMMAND:   // обрабатывает нажатие кнопок и друг действия пользователя
			switch (LOWORD(wParam))
			{
			case IDC_BUTTON_COPY:
			{
				// 1) Создаем буфер
				CONST INT SIZE = 256;
				CHAR sz_buffer[SIZE] = {}; //sz - String Zero (NULL terminated Line - C-string)

				// 2) Получаем обработчик текстовых полей:
				HWND heditLogin = GetDlgItem(hwnd, IDC_EDIT_LOGIN);
				HWND heditPassword = GetDlgItem(hwnd, IDC_EDIT_PASSWORD);
				
				// 3) Считываем содержимое поля 'Login' в буфер:
				SendMessage(heditLogin, WM_GETTEXT, SIZE, (LPARAM)sz_buffer);

				// 4) Записываем полученный текст в текстовое поле 'Password':
				SendMessage(heditPassword, WM_SETTEXT, 0, (LPARAM)sz_buffer);

			}
			break;
			case IDOK:MessageBox(hwnd, "Была нажата кнопка ОК", "Info", MB_OK | MB_ICONINFORMATION);
				break;
			case IDCANCEL: EndDialog(hwnd, 0); break;
			}
			break;
		case WM_CLOSE:   // отправляет при нажатии кнопки закрыть, ЗАКРЫТЬ, "X"
			EndDialog(hwnd, 0); 
			break;
		}
		return FALSE;
	}