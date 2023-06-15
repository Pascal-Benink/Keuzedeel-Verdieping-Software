using System;
using System.Diagnostics;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Specify the path to the application executable or assembly
        string appPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MusicMaster.exe");

        if (File.Exists(appPath))
        {
            try
            {
                // Close the application if it is currently running
                foreach (var process in Process.GetProcessesByName(Path.GetFileNameWithoutExtension(appPath)))
                {
                    process.Kill();
                }

                // Delete the application files
                File.Delete(appPath);

                // Optionally, delete additional files or directories associated with the application

                Console.WriteLine("Uninstall successful.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred during uninstallation: " + ex.Message);
            }
        }
        else
        {
            Console.WriteLine("Application not found.");
        }

        Console.ReadLine();
    }
}