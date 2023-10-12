using OOP_lab_5;
using OOP_lab_5.Loggers;

InventoryController inventoryController = new InventoryController();

inventoryController.ActivateRebootControll();

ConsoleLogger consoleLogger = new ConsoleLogger();
FileLogger fileLogger = new FileLogger();

try {
    throw new Exception();
} catch(Exception err) {
    consoleLogger.AddLog(err.Message, DateTime.Now);
    fileLogger.AddLog(err.Message, DateTime.Now);

    Console.Write(consoleLogger[0]);
} 


