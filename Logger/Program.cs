using Logger.Concrete;
using Logger.Concrete.Commands;
//Logger class instance

LogHelper logHelper = new LogHelper();

//Database types
Database postgreSqlDatabase = new Database("POSTGRESQL");

//Load command types
LoadCommand loadCommand = new LoadCommand(postgreSqlDatabase);
RestoreCommand restoreCommand = new RestoreCommand(postgreSqlDatabase);
ClearCommand clearCommand = new ClearCommand(postgreSqlDatabase);

//Load log helper
logHelper.LoadCommands.Add("POSTGRESQL", loadCommand);
logHelper.RestoreCommands.Add("POSTGRESQL", restoreCommand);
logHelper.ClearCommands.Add("POSTGRESQL", clearCommand);

//log helper actions
logHelper.Restore("POSTGRESQL");
logHelper.Restore("POSTGRESQL");
logHelper.Restore("POSTGRESQL");
logHelper.Load("POSTGRESQL");
logHelper.Load("POSTGRESQL");
logHelper.UndoAction();
logHelper.UndoAction();
logHelper.UndoAction();
logHelper.UndoAction();
logHelper.UndoAction();