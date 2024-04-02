const double НДС_18 = 0.18;
const double НДС_10 = 0.10;

Console.WriteLine("№  Название            Цена   Кол.  Сумма");
Console.WriteLine("1  КОФЕ СТАНДАРТНЫЙ   69.00  1.00  69.00");
Console.WriteLine("   НДС с рассчитанной ставкой 18%: " + (69.00 * НДС_18).ToString("F2").PadLeft(25));
Console.WriteLine("2  РУЛЕТ-СПРИНГ ТВ ИЗ  70.00  1.00  70.00");
Console.WriteLine("   НДС с рассчитанной ставкой 10%: " + (70.00 * НДС_10).ToString("F2").PadLeft(25));
Console.WriteLine("Итого:                139.00");
Console.WriteLine("Электронные средства: 139.00");
Console.WriteLine("НДС итога чека с рассчитанной ставкой 18%: " + (139.00 * НДС_18).ToString("F2").PadLeft(25));
Console.WriteLine("НДС итога чека с рассчитанной ставкой 10%: " + (139.00 * НДС_10).ToString("F2").PadLeft(25));

Console.WriteLine("ВИД НАЛОГООБЛОЖЕНИЯ: ОСН");
Console.WriteLine("РЕГ. НОМЕР ККТ: 0000143873023483");
Console.WriteLine("ЗАВОД. №: ФН №: 8710000100265168 Ф…");