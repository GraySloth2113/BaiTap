using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable] // Để hỗ trợ Serialization
public class Account
{
    public string AccountID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Balance { get; set; }

    public Account(string accountID, string firstName, string lastName, double balance)
    {
        AccountID = accountID;
        FirstName = firstName;
        LastName = lastName;
        Balance = balance;
    }

    public void Show()
    {
        Console.WriteLine($"ID: {AccountID}, Name: {FirstName} {LastName}, Balance: {Balance:C}");
    }
}

// ✅ **Bổ sung lớp so sánh theo AccountID (dùng cho BinarySearch)**
class AccountIDComparer : IComparer
{
    public int Compare(object x, object y)
    {
        return ((Account)x).AccountID.CompareTo(((Account)y).AccountID);
    }
}

class AccountList
{
    private ArrayList accounts = new ArrayList();

    public void NewAccount(Account acc)
    {
        accounts.Add(acc);
    }

    // ✅ **Xóa account bằng BinarySearch**
    public bool Remove(string accountID)
    {
        accounts.Sort(new AccountIDComparer()); // Sắp xếp trước khi tìm kiếm
        int index = accounts.BinarySearch(new Account(accountID, "", "", 0), new AccountIDComparer());

        if (index >= 0)
        {
            accounts.RemoveAt(index);
            Console.WriteLine($"Đã xóa tài khoản {accountID}.");
            return true;
        }
        else
        {
            Console.WriteLine($"Không tìm thấy tài khoản {accountID}.");
            return false;
        }
    }

    // ✅ **Sắp xếp danh sách theo ID, FirstName, Balance**
    public void SortByID() => accounts.Sort(new AccountIDComparer());
    public void SortByFirstName() => accounts.Sort(new AccountFirstNameComparer());
    public void SortByBalance() => accounts.Sort(new AccountBalanceComparer());

    public void ShowAll()
    {
        foreach (Account acc in accounts)
            acc.Show();
    }

    // ✅ **Lưu file bằng Serialization**
    public void SaveFile(string filename)
    {
        using (FileStream fs = new FileStream(filename, FileMode.Create))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, accounts);
        }
        Console.WriteLine("Đã lưu danh sách tài khoản.");
    }

    // ✅ **Tải file bằng Serialization**
    public void LoadFile(string filename)
    {
        if (File.Exists(filename))
        {
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                accounts = (ArrayList)formatter.Deserialize(fs);
            }
            Console.WriteLine("Đã tải danh sách tài khoản.");
        }
        else
        {
            Console.WriteLine("File không tồn tại.");
        }
    }
}

// ✅ **Các lớp so sánh khác**
class AccountFirstNameComparer : IComparer
{
    public int Compare(object x, object y)
    {
        return ((Account)x).FirstName.CompareTo(((Account)y).FirstName);
    }
}

class AccountBalanceComparer : IComparer
{
    public int Compare(object x, object y)
    {
        return ((Account)x).Balance.CompareTo(((Account)y).Balance);
    }
}
class Program
{
    static void Main()
    {
        AccountList accList = new AccountList();

        // ✅ Thêm account mới
        accList.NewAccount(new Account("A003", "John", "Doe", 5000));
        accList.NewAccount(new Account("A001", "Alice", "Smith", 3000));
        accList.NewAccount(new Account("A002", "Bob", "Johnson", 7000));

        Console.WriteLine("\n📌 Danh sách tài khoản ban đầu:");
        accList.ShowAll();

        // ✅ Sắp xếp theo ID
        accList.SortByID();
        Console.WriteLine("\n📌 Danh sách sau khi sắp xếp theo ID:");
        accList.ShowAll();

        // ✅ Xóa tài khoản "A002"
        accList.Remove("A002");

        // ✅ Lưu danh sách vào file
        accList.SaveFile("accounts.dat");

        // ✅ Load danh sách từ file
        AccountList newAccList = new AccountList();
        newAccList.LoadFile("accounts.dat");

        Console.WriteLine("\n📌 Danh sách sau khi tải từ file:");
        newAccList.ShowAll();
    }
}
