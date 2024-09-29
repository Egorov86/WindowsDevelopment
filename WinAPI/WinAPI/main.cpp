#include<Windows.h>
#include"resource.h"
#include<CommCtrl.h>
//#define UNICODE
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
    {

        /*// плейсхолдер для поля 'Login'
        HWND heditLogin = GetDlgItem(hwnd, IDC_EDIT_LOGIN);
        SendMessage(heditLogin, EM_SETCUEBANNER, 0, (LPARAM)TEXT("Введите имя пользователя"));*/
    }
    return TRUE;
        /*// Создаем буфер
        CONST INT SIZE = 256;
        CHAR sz_buffer[SIZE] = "Введите имя пользователя";
        //CHAR sz_buffer[SIZE] = {}; //sz - String Zero (NULL terminated Line - C-string)
        //TCHAR Messege = CHAR("Введите имя пользователя");
        // Устанавливаем плейсхолдер для поля 'Login'
        HWND heditLogin = GetDlgItem(hwnd, IDC_EDIT_LOGIN);
        SendMessage(heditLogin, WM_GETTEXT, SIZE, (LPARAM)Messege);
        // Записываем полученный текст в текстовое поле 'Login':
        SendMessage(heditLogin, WM_SETTEXT, SIZE, (LPARAM)Messege);
    }
        break;*/
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
        case IDCANCEL:MessageBox(hwnd, "Была нажата кнопка ОТМЕНА", "Info", MB_OK | MB_ICONMASK); EndDialog(hwnd, 0); break;
        }
        break;
    case WM_CLOSE:   // отправляет при нажатии кнопки закрыть, ЗАКРЫТЬ, "X"
        EndDialog(hwnd, 0);
        break;
    }
    return FALSE;
}
LRESULT CALLBACK LoginEditProc(HWND hwnd, UINT uMsg, WPARAM wParam, LPARAM lParam)
{
    switch (uMsg)
    {
    case WM_SETTEXT:
        if (LOWORD(wParam) == 0)
        {
            SetWindowText(hwnd, "Введите имя пользовттеля");
        }
        else
        {
            SetWindowText(hwnd, NULL);
        }
        break;
    }
    return CallWindowProc((WNDPROC)GetWindowLongPtr(hwnd, GWLP_WNDPROC), hwnd, uMsg, wParam, lParam);    // обработка родит-ого окна
}