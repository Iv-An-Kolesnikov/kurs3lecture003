//Вид 1: ничего не принимает и ничего не возвращает;
// void Method1()
// {
//     Console.WriteLine("Автор: Иван Колесников");
// }
// //Method1();  //Вызов метода

// //Вид 2: что-то принимает, ничего не возвращают;
// //Пример 1
// void Method21(string msg)
// {
//     Console.WriteLine(msg);
// }
// //Method21("Текст сообщения");
// //Пример 2
// void Method22(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// //Method22("Текст", 4);
// //Method22(count: 4, msg: "Новый текст");


// //Вид 3: ничего не принимает, что-то возвращает;
// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// //Console.WriteLine(year);

//Вид 4: что-то принимают, что-то возвращают.
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

// while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }
// string res = Method4(8, "zlkj");
// // Console.WriteLine(res);
// //------------------------------------------
// string Method4(int count, string text)
// {
//     string result = String.Empty;
//     for(int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(8, "zlkj");
// Console.WriteLine(res);