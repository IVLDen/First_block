
string [] arr = new string[4]; ;

// Заполняем массив с клавиатуры
    Console.WriteLine ("Заполните массив 10 строками символов");
    string s;
    
     for (int i = 0; i < arr.Length; i++){
     
     s = Console.ReadLine();
     
     arr[i] = s;
     }

  
     

// Отобразим полученные строки
void ShowArr (string [] arr2) {
 
 for (int i = 0; i < arr2.Length; i++){

    Console.WriteLine (arr2[i]);

}
}

//выводим строки из условия задачи (кол-во символов меньше или равно 3)

void ShowStrings (string [] arr3) {

 Console.WriteLine ("Строки содержащие 3 или мнее символов");
     for (int i = 0; i < arr3.Length; i++){

        if (arr3[i].Length == 3 || arr3[i].Length < 3)
        Console.WriteLine ($"{arr3[i]} - элемент № {i} в массиве ");
        }
}



Console.WriteLine();
Console.WriteLine();
ShowArr(arr);
Console.WriteLine();
Console.WriteLine();
ShowStrings(arr);