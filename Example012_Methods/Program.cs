//Методы первой группы очень простые и выглядят следующим образом. Допустим:

void Metod1()
{
Console.WriteLine("Автор …");
}

//Следующая группа методов это пусть так и называется Metod2.
void Metod2(string msg) /* — где void ключевое слово, дальше идентификатор, в скобках
                        указаны какие-то аргументы.*/
{
Console.WriteLine(msg); /*— оператор, в скобках указан принятый аргумент.*/
}
Metod2("Текст сообщения"); 

int Metod3() /*- не принимает никакие аргументы*/
{
return DataTime.Now.Year; /* - обязательное использование оператора return,*/
}
int year = Metod3(); /*- вызываем метод, в левой части используем идентификатор
переменной (year) и через оператор присваивания (=) кладём нужное значение */
Console.WriteLine(year);

//Самая важная группа методов, это методы, которые что-то принимают и что-то возвращают.
string Metod4(int count, string text)
{
int i = 0;
string result = String.Empty;
while (i<count)
{
result = result + text;
i++;
}
return result;
}
string res = Metod4(10, "asdf");
Console.WriteLine(res);
