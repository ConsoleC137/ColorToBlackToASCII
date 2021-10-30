# ColorToBlackToASCII

Это приложение создано для того, чтобы создавать из изображения его чёрно-белую, негативную и ASCII копии. Приложение многопоточное, каждый метод работает в своём потоке и не блокирует UI. Графический интерфейс написан на WinForms.

Я провёл ряд тестов с изображением размером 4К и получил следующее:

Чёрно - белое изображение - 17 секунд

Негативное изображение - 17 секунд

ASCII изображение - 1 секунда

Если вы знаете как можно улучшить производительность или упростить код, свяжитесь со мной.

##########################################################################################

This application was created in order to create black-and-white, negative and ASCII copies of an image. The application is multithreaded, each method works in its own thread and does not block the UI. The graphical interface is written in WinForms.

I ran a series of tests with a 4K image and got the following:

Black and white image - 17 seconds

Negative image - 17 seconds

ASCII image - 1 second

If you know how to improve performance or simplify the code, contact me.
