using CompositeDesignPattern.ElectronicExample;
using CompositeDesignPattern.filesystem;
using CompositeDesignPattern.FileSystemProject.Leaf;
using CompositeDesignPattern.FileSystemProject;
using CompositeDesignPattern.FileSystemProject.Composite;
using System;
namespace CompositeDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileSystemProject();
        }

        static void FileSystemProject()
        {
            FileSystemItem MyBook = new FileItem("MyBook.txt", 12000);
            FileSystemItem MyVideo = new FileItem("MyVideo.mp4", 1000000);
            FileSystemItem MyMusic = new FileItem("MyMusic.mp3", 20000);
            FileSystemItem MyResume = new FileItem("MyResume.pdf", 18000);
            FileSystemItem MySoftware = new FileItem("MySoftware.exe", 250000);
            FileSystemItem MyDocument = new FileItem("MyDocument.doc", 87000000);

            //Create the Root Directory i.e. Composite Object 
            CompositeDirectory RootDirectory = new CompositeDirectory("RootDirectory");

            //Add 2 More Folders i.e. two more composite objects  
            CompositeDirectory Folder1 = new CompositeDirectory("Folder1");
            CompositeDirectory Folder2 = new CompositeDirectory("Folder2");
            //Add the above two folders under Root Directory
            RootDirectory.AddComponent(Folder1);
            RootDirectory.AddComponent(Folder1);
            //Add files to Folder 1   
            Folder1.AddComponent(MyBook);
            Folder1.AddComponent(MyVideo);
            //Create a Sub Folder1  
            CompositeDirectory SubFolder1 = new CompositeDirectory("Sub Folder1");
            //Add files under Sub Folder1  
            SubFolder1.AddComponent(MyMusic);
            SubFolder1.AddComponent(MyResume);
            //Add Sub Folder1 under Folder 1
            Folder1.AddComponent(SubFolder1);
            //Add files to folder 2  
            Folder2.AddComponent(MySoftware);
            Folder2.AddComponent(MyDocument);
            Console.WriteLine("Composite Objects:");
            Console.WriteLine($"Total size of (RootDirectory): {RootDirectory.GetSizeInKB()} KB");
            Console.WriteLine($"Total size of (Folder 1): {Folder1.GetSizeInKB()}KB");
            Console.WriteLine($"Total size of (Folder 2): {Folder2.GetSizeInKB()}KB");
            Console.WriteLine($"Total size of (SubFolder 1): {SubFolder1.GetSizeInKB()}KB");
            Console.WriteLine("\nLeaf Objects:");
            Console.WriteLine($"Total size of MyVideo File: {MyVideo.GetSizeInKB()}KB");
            Console.WriteLine($"Total size of MyResume File: {MyResume.GetSizeInKB()}KB");
            Console.WriteLine($"Total size of MyBook File: {MyBook.GetSizeInKB()}KB");
            Console.WriteLine($"Total size of MyDocument File: {MyDocument.GetSizeInKB()}KB");
        }
        static void ElectronicExample()
        {
            // The client code works with all of the components (Both Leaf and Composite) via the base interface i.e. IComponent.
            // IComponent means the class that implements the IComponent Interface

            //Creating Leaf Objects or you can say child objects
            Component hardDisk = new Leaf("Hard Disk", 2000);
            Component ram = new Leaf("RAM", 3000);
            Component cpu = new Leaf("CPU", 2000);
            Component mouse = new Leaf("Mouse", 2000);
            Component keyboard = new Leaf("Keyboard", 2000);

            //Creating Composite Objects
            Composite motherBoard = new Composite("MotherBoard");
            Composite cabinet = new Composite("Cabinet");
            Composite peripherals = new Composite("Peripherals");
            Composite computer = new Composite("Computer");

            //Creating Tree Structure i.e. Adding Child Components inside the Composite Component
            //Adding CPU and RAM in Mother Board
            motherBoard.AddComponent(cpu);
            motherBoard.AddComponent(ram);
            
            cabinet.AddComponent(motherBoard);
            cabinet.AddComponent(hardDisk);
            
            peripherals.AddComponent(mouse);
            peripherals.AddComponent(keyboard);
            
            computer.AddComponent(cabinet);
            computer.AddComponent(peripherals);
            
            Console.WriteLine("Price of Computer Composite Components");
            computer.DisplayPrice();
          
            Console.WriteLine("\nPrice of Keyboard Child or Leaf Component:");
            keyboard.DisplayPrice();

            
            Console.WriteLine("\nPrice of Cabinet Composite Component:");
            cabinet.DisplayPrice();


        }
        static void filesystem()
        {
            FileSystemComponent file1 = new File("File1.txt");
            FileSystemComponent file2 = new File("File2.txt");
            FileSystemComponent file3 = new File("File3.txt");

            Directory dir1 = new Directory("Directory1");
            dir1.Add(file1);
            dir1.Add(file2);

            Directory dir2 = new Directory("Directory2");
            dir2.Add(dir1);
            dir2.Add(file3);

            dir2.Display(" ");
        }
    }
}
