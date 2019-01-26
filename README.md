# charity-run-tracker
Simple software to keep track of runners in a charity run

This is a C# WinForms software original written in 2015 for a charity run organisised by my school.
It was written for .NET 3.5 but should work in ever .NET Framework above.
It it far from perfect but gets the job done.

This programm includes
 * a form to track (and count) runners by a number
 * a form to create runners
 * a form display informations about a runner
 * a form to display the current top 10 runners


Please keep in mind that is was written for a german school and because of that there are a few words in german, even though the source code is (mostly) in english.

# setup
This programm needs a connection to a MySQL Server. It won't work offline!
To initialisize the database: Import the databaseshema.sql into your MySQL Server.
Make sure to provide a user with SELECT, UPDATE and INSERT rights.

Before building the programm you have to change myConnectionString in Form1.cs to use the correct values for your database!
Be aware that everyone with your distributed software can read these values!
To be safe, you should create a system to read these values out of a config file or create a webservice to write into the database.

**Also be warned that I did not take SQL-Injection into account! At the moment they are possible!**
So be careful before providing it around!
