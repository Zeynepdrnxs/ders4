using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        MyDictionary<string, int> myDict = new MyDictionary<string, int>();

        // MyDictionary sınıfını kullanarak anahtar-değer çiftleri ekleyelim
        myDict.Add("Anahtar1", 42);
        myDict.Add("Anahtar2", 123);

        // Belirli anahtarları kullanarak değerlere erişelim ve ekrana yazdıralım
        Console.WriteLine("Anahtar1: " + myDict.Get("Anahtar1"));
        Console.WriteLine("Anahtar2: " + myDict.Get("Anahtar2"));

        Console.ReadLine();
    }
}

class MyDictionary<TKey, TValue>
{
    private Dictionary<TKey, TValue> dictionary = new Dictionary<TKey, TValue>();

    // Yeni anahtar-değer çiftleri eklemek için kullanılır
    public void Add(TKey key, TValue value)
    {
        dictionary[key] = value;
    }

    // Belirli bir anahtarın değerini döndürür
    public TValue Get(TKey key)
    {
        // Eğer anahtar Dictionary içinde varsa, değeri döndürür
        if (dictionary.ContainsKey(key))
        {
            return dictionary[key];
        }
        // Eğer anahtar bulunamazsa, bir hata fırlatır
        throw new KeyNotFoundException("Anahtar bulunamadı");
    }
}
