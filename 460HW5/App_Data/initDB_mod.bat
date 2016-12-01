@ECHO off
SET DBFILENAME=WebForm.mdf
SET DBLOGFILENAME=WebForm_log.ldf
SET INITSCRIPT=initDB.sql

SET SERVERNAME=CS460LOCALDB
SET SERVERVERSION=12.0		REM 2014 ?
::SET SERVERVERSION=13.0		REM 2016 ?

REM Create and start instance of localdb, Version 12
sqllocaldb create %SERVERNAME% %SERVERVERSION% -s

REM If it succeeds, continue
if %errorlevel% neq 0 exit /b

REM If db and db files already exist, detach them first in Visual Studio Server Explorer

REM If db already exists and is attached, detach it first
::sqlcmd -S "(localdb)\MSSQLLocalDB" -Q "EXEC sp_detach_db [%CD%\%DBFILENAME%],[true]"
IF EXIST %DBFILENAME% del %DBFILENAME%
IF EXIST %DBLOGFILENAME% del %DBLOGFILENAME%
REM Run script to create and initialize database, both files and db in master
sqlcmd -S "(localdb)\%SERVERNAME%" -v dbdir="%CD%" -i %INITSCRIPT% -b

REM Uses this technique to inject full path: stackoverflow.com/questions/139245/relative-path-in-t-sql (mateuscb)

REM Stop and delete localdb instance
sqllocaldb stop %SERVERNAME%
sqllocaldb delete %SERVERNAME%
