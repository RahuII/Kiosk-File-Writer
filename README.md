# Kiosk-File-Writer
Kiosk - File Writer

You need to write a non-blocking console user interface for a new Kiosk system. A non-blocking system does not block the user interface while executing a blocking code such as writing to a file. The Kiosk system will show the following menu to the user:
```
1. Write "Hello World"
2. Write Current Date
3. Write OS Version
```
If the user enters '1', '2' or '3' write "Hello World", current date-time or OS version (Environment.OSVersion.VersionString) respectively to the file. 

Use this class to write to the file -
```csharp
    public class BackgroundOperation
    {
        public async Task WriteToFileAsync(string message)
        {
            await Task.Delay(3000);
            await File.WriteAllTextAsync("tmp.txt", message);
        }
    }
```
![image](https://user-images.githubusercontent.com/68543024/220087906-de053cef-94a0-4439-8977-48472e4ea366.png)
![image](https://user-images.githubusercontent.com/68543024/220087946-27f64d06-a762-4488-9247-b89bf2877f95.png)
![image](https://user-images.githubusercontent.com/68543024/220087990-f5f727b7-7014-4fe8-90df-24bc629b228f.png)
