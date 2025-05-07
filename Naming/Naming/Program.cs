// See https://aka.ms/new-console-template for more information
using System.Data;

Console.WriteLine("Hello, World!");
int d = 0; //Bu değişken, müşterinin kaydından itibaren geçen gün sayısını tutar.

var x = 5;
int i = 1;
int ii = 8;

//1. İsimler anlamlı olmalı.
int daysSinceCustomerCreated = 150;
int musteriGunSayisi = 365;

bool banuAlkan = false;

//2. kısaltma kullanmak risklidir.
int hpPrinters = 0;
int hitPoint = 0;

DateTime dayMonthYearFormat = DateTime.Now;

//3. Değişkenin tipine göre isimlendirme yapın:
bool isApproved = false;
bool hasData = true;

int currentMonth = 5;
double taxRate = 0.20;

int intDay = 7;
double doubleRate = 1.8;

//4. Kompleks tiplerde, tip ismi nesne isminde geçebilir (geçmeli)
Random randomNumberGenerator = new Random();
DataTable customersDataTable = new DataTable();

//Aşağıdaki iki isim de doğru. Hangisinin kullanılacağına ortak karar verilmeli ve code guideline oluşturulmalı.
List<string> emails = new List<string>();
List<string> emailList = new List<string>();



//var o = 0;
//var l = 1;

//if (o==1)
//{
//    o = l;
//}
//bunu okuyan yazılımcı kör olur!

string password = "Pa_55w0rd";
bool isIncludeLetter = false;
bool isIncludeNumber = false;
bool isIncludeSymbol = false;

bool isPasswordValid = isIncludeLetter && isIncludeNumber && isIncludeSymbol;

if (isPasswordValid)
{

}

int number = 5;
bool smallThanSix = number < 6;
bool isModuleByThreeZero = number % 3 == 0;


List<int[]> cellsOnBoard = new List<int[]>();

List<int[]> getFlaggedCells()
{
    List<int[]> flaggedCells = new List<int[]>();
    foreach (var cell in flaggedCells)
    {
		if (cell[0] == CellStates.Flagged)
		{
            flaggedCells.Add(cellsOnBoard[i]);
        }
    }
   
	return flaggedCells;
}

public enum CellState
{
    Empty = 1,
    Exploded = 2,
    Flagged = 4,
    Opened = 8
}
public class CellStates
{
    public const int Empty = 1;
    public const int Exploded = 2;
    public const int Flagged = 4;
    public const int Opened = 8;
}
