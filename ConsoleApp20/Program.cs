int CalculateTotalMinutes(int hours, int minutes)
{
    int totalMinutes = hours * 60 + minutes;
    return totalMinutes;
}


//Вы можете вызвать эту функцию и передать ей значения для полей 1 и 2, чтобы получить общее количество минут:


int hours = 2;
int minutes = 30;
int totalMinutes = CalculateTotalMinutes(hours, minutes);
Console.WriteLine("Общее количество минут: " + totalMinutes);