// принять на вход пятизначное число и проверить является ли оно палиндромом

Console.WriteLine("Введите пятизначное число");
string numbers = Convert.ToString(Console.ReadLine());

bool Cheсk (string n){

 if(n[0]==n[4] && n[1]==n[3]) {
    return true;
}
  else{
    return false;
  }
}
if (numbers.Length <= 5){
bool x = Cheсk(numbers);
if (x == true){
    Console.WriteLine("Это палиндром");
}
else{
    Console.WriteLine("Не палиндром");
}
}
else{
    Console.WriteLine("Ошибка. Введите пятизначное число");
}
