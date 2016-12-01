@ECHO off
SET DBFILENAME=WebForm.mdf
SET DBLOGFILENAME=WebForm.ldf
SET INITSCRIPT=initDB.sql
SET SERVERNAME=np:\\.\pipe\LOCALDB#E9747A5E\tsql\query

REM Connect to localdb instance over named pipes rather than tcp

REM This version assumes you have the named pipe address for the server
REM already in the environment variable SERVERNAME
REM You can get this name by starting the server and asking for info
::sqllocaldb start MSSQLLocalDB
::sqllocaldb info MSSQLLocalDB
REM Then set the variable, i.e. your version of
::SET SERVERNAME="np:\\.\pipe\LOCALDB#833C8B5F\tsql\query"

IF "%SERVERNAME%"=="" EXIT /b

IF EXIST %DBFILENAME% del %DBFILENAME%
IF EXIST %DBLOGFILENAME% del %DBLOGFILENAME%
REM Run script to create and initialize database, both files and db in master
sqlcmd -S %SERVERNAME% -v dbdir="%CD%" -i %INITSCRIPT% -b

REM Uses this technique to inject full path: stackoverflow.com/questions/139245/relative-path-in-t-sql (mateuscb)
