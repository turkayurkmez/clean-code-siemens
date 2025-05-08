// See https://aka.ms/new-console-template for more information

using Functions;

string getRandomWord(List<string> words)
{
    return "test";
}
string convertToPuzzle(string word)
{
    return "****";
}
void showPuzzle(string puzzle)
{
    Console.WriteLine(puzzle);
}
string getLetterFromUser()
{
    return "t";
}

bool isWordIncludeLetter(string word, string letter)
{
    return true;
}

string replacePuzzleToLetter(string word, string letter)
{
    return "t**t";
}

int reduceHeart()
{
    return 5;
}

string getSuggestion()
{
    return "test";
}

bool compare(string puzzle, string word)
{
    return true;
}

Console.WriteLine("Hello, World!");
/*
 * 1. Bir kelime koleksiyonu içinden rastgele kelime seç.
 * 2. Seçilen kelimeyi harf sayısı kadar * 'a çevir.
 * 3. Bu bulunacak kelimeyi ekranda göster.
 * 4. Kullanıcıdan harf iste
 * 5. Harfin seçilen kelimede olup olmadığına bak.
 *    - Eğer varsa;
 *           O harfin pozisyonundaki '*' sembolünü harf ile değiştir
 *    - Yoksa
 *           Hakkını bir azalt
 * 6. 4. Adıma dön.
 * 7. Tahmin etmesini iste. 
 * 8. Tahmin kelime ile seçilen kelimeyi karşılaştır.
 * 9. Bildiyse; tamamla
 *    Bilemediyse 4. Adıma dön.
 *    
 *    
 */
string word = getRandomWord(new List<string>());

string puzzled = convertToPuzzle(word);
showPuzzle(puzzled);
string letter = getLetterFromUser();
bool isIncludeLetter = isWordIncludeLetter(word, letter);
if (isIncludeLetter)
{
    puzzled = replacePuzzleToLetter(word, letter);
    showPuzzle(puzzled);

}
else
{
    reduceHeart();
}

string suggestedWord = getSuggestion();
bool isSuccessed = compare(word, suggestedWord);
if (isSuccessed)
{
    Console.WriteLine("Bildiniz");
}

bool isEven(int number)
{
    return number % 2 == 0;
}

/*
 * 1. fonksiyonlar mümkün olduğu kadar az satır içermeli - evet tek satır ideal olanı.
 * 2. fonksiyon parametreleri mümkün olduğunca az olmalı - evet parametresiz en ideali.
 */

ReportGenerator reportGenerator = new ReportGenerator("C:\\Users\\turka\\OneDrive\\Book.xlsx");
reportGenerator.CreateReport("HTML");